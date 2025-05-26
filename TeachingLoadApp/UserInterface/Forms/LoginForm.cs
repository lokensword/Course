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
using TeachingLoadApp.Context;
using TeachingLoadApp.DataAccess.Repositories;

namespace TeachingLoadApp
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        public LoginForm()
        {
            InitializeComponent();
            var context = DbHandler.CreateContext();
            _userService = new UserService(new UserRepository(context));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text.Trim();
            var password = passwordTextBox.Text;

            if (_userService.Login(login, password))
            {
                var isAdmin = _userService.IsAdmin(login);
                var userId = _userService.GetUserId(login).Value;

                if (isAdmin)
                    new AdminForm(userId).Show();
                else
                    new TeacherForm(userId).Show();

                this.Hide();
            }
            else
            {
                debugLabel.Text = "Неверный логин или пароль.";
                debugLabel.Visible = true;
            }
        }
    }
}
