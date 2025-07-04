using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachingLoadApp.BusinessLogic.Interfaces;
using TeachingLoadApp.BusinessLogic.Services;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.UserInterface.Forms.Subforms
{
    public partial class AddTeacherForm : Form
    {
        private readonly ITeacherService _teacherService;
        private readonly IUserService _userService;
        public event Action TeacherAdded;
        public AddTeacherForm(ITeacherService teacherService, IUserService userService)
        {
            InitializeComponent();
            _teacherService = teacherService;
            _userService = userService;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string middleName = middleNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(middleName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            if (!int.TryParse(loadLimitTextBox.Text.Trim(), out int limit) || limit <= 0)
            {
                MessageBox.Show("Incorrect limit");
                return;
            }

            try
            {
                var user = new AppUser
                {
                    Login = login,
                    Password = password,
                    Role = "user"
                };

                int userId = _userService.Add(user);

                var teacher = new Teacher
                {
                    FirstName = firstName,
                    MiddleName = middleName,
                    LastName = lastName,
                    LoadLimit = limit,
                    UserId = userId
                };

                _teacherService.Add(teacher);

                TeacherAdded?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
