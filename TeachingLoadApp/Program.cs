using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Testing
{
    using System.Configuration;
    using MySql.Data.MySqlClient;

    namespace TeachingLoadApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Тестирование подключения к MySQL...");

                // 1. Получаем строку подключения из app.config
                string connectionString = ConfigurationManager.ConnectionStrings["TeachingLoadConnection"]?.ConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                {
                    Console.WriteLine("Ошибка: строка подключения не найдена в app.config!");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine($"Используемая строка: {connectionString.Replace("Pwd=", "Pwd=***")}");

                // 2. Пробуем подключиться
                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        Console.WriteLine("Подключаемся к MySQL...");
                        connection.Open(); // Пытаемся открыть соединение

                        Console.WriteLine("Успешно подключено!");

                        // 3. Проверяем, есть ли таблица `teachers`
                        var command = new MySqlCommand("SHOW TABLES LIKE 'teachers'", connection);
                        bool tableExists = command.ExecuteScalar() != null;

                        Console.WriteLine(tableExists
                            ? "Таблица 'teachers' найдена!"
                            : "Таблица 'teachers' не найдена!");

                        // 4. Выводим количество записей (если таблица есть)
                        if (tableExists)
                        {
                            command.CommandText = "SELECT COUNT(*) FROM teachers";
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            Console.WriteLine($"Записей в таблице: {count}");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Oшибка MySQL:");
                        Console.WriteLine($"Код: {ex.Number} | Сообщение: {ex.Message}");

                        // Возможные решения:
                        switch (ex.Number)
                        {
                            case 0:
                                Console.WriteLine("Проверьте: сервер MySQL запущен?");
                                break;
                            case 1045:
                                Console.WriteLine("Неверный логин/пароль!");
                                break;
                            case 1049:
                                Console.WriteLine("База данных не существует!");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Неизвестная ошибка:");
                        Console.WriteLine(ex.Message);
                    }
                }

                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}
