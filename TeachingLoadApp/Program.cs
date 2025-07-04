using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachingLoadApp.BusinessLogic.Services;
using TeachingLoadApp.Context;
using TeachingLoadApp.DataAccess.Repositories;

namespace TeachingLoadApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var context = DbHandler.CreateContext();

            var userRepo = new UserRepository(context);
            var teacherRepo = new TeacherRepository(context);
            var facultyRepo = new FacultyRepository(context);
            var groupRepo = new GroupRepository(context);
            var subjectRepo = new SubjectRepository(context);
            var classRepo = new ClassRepository(context);
            var loadRepo = new LoadRepository(context);
            var classInLoadRepo = new ClassInLoadRepository(context);

            var userService = new UserService(userRepo, teacherRepo, loadRepo, classInLoadRepo);
            var teacherService = new TeacherService(teacherRepo, loadRepo, classInLoadRepo);
            var facultyService = new FacultyService(facultyRepo, groupRepo, classRepo);
            var groupService = new GroupService(groupRepo, classRepo);
            var subjectService = new SubjectService(subjectRepo, classRepo);
            var classService = new ClassService(classRepo, classInLoadRepo);
            var loadService = new LoadService(loadRepo, classInLoadRepo);
            var classInLoadService = new ClassInLoadService(classInLoadRepo);

            Application.Run(new LoginForm(
                userService, teacherService, facultyService,
                groupService, subjectService, loadService,
                classService, classInLoadService
            ));
        }
    }
}