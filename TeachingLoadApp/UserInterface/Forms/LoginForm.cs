using LinqToDB.Tools;
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
using TeachingLoadApp.UserInterface.Forms;

namespace TeachingLoadApp
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly ITeacherService _teacherService;
        private readonly IFacultyService _facultyService;
        private readonly IGroupService _groupService;
        private readonly ISubjectService _subjectService;
        private readonly ILoadService _loadService;
        private readonly IClassService _classService;
        private readonly IClassInLoadService _classInLoadService;
        public LoginForm(   IUserService userService,
                            ITeacherService teacherService,
                            IFacultyService facultyService,
                            IGroupService groupService,
                            ISubjectService subjectService,
                            ILoadService loadService,
                            IClassService classService,
                            IClassInLoadService classInLoadService)
        {
            InitializeComponent();

            _userService = userService;
            _teacherService = teacherService;
            _facultyService = facultyService;
            _groupService = groupService;
            _subjectService = subjectService;
            _loadService = loadService;
            _classService = classService;
            _classInLoadService = classInLoadService;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            var user = _userService.GetAll().FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Incorrect login or password");
                return;
            }

            Hide();

            if (user.Role == "admin")
            {
                var adminForm = new AdminForm(_userService, _teacherService, _subjectService, _groupService, _facultyService, _loadService);
                adminForm.FormClosed += (s, args) => Show();
                adminForm.Show();
            }
            else
            {
                var teacher = _teacherService.GetByUserId(user.Id);
                if (teacher == null)
                {
                    MessageBox.Show("There is no link to teacher");
                    Show();
                    return;
                }

                var teacherForm = new TeacherForm(teacher.Id, _teacherService, _loadService, _classInLoadService, _classService, _subjectService, _groupService);
                teacherForm.FormClosed += (s, args) => Show();
                teacherForm.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
