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
using TeachingLoadApp.DataAccess;
using TeachingLoadApp.DataAccess.Repositories;

namespace TeachingLoadApp.UserInterface.Forms
{
    public partial class AdminForm : Form
    {
        private readonly ITeacherService _teacherService;
        private readonly ISubjectService _subjectService;
        private readonly IGroupService _groupService;
        private readonly IFacultyService _facultyService;
        private readonly ILoadService _loadService;

        public AdminForm()
        {
            InitializeComponent();

            var context = DbHandler.CreateContext();
            _teacherService = new TeacherService(new TeacherRepository(context));
            _subjectService = new SubjectService(new SubjectRepository(context));
            _groupService = new GroupService(new GroupRepository(context));
            _facultyService = new FacultyService(new FacultyRepository(context));
            _loadService = new LoadService(new LoadRepository(context));

            LoadTeachers(teachersGrid);
            LoadSubjects(subjectsGrid);
            LoadGroups(groupsGrid);
            LoadFaculties(facultiesGrid);
            LoadLoads(loadsGrid);
        }

        private void LoadTeachers(DataGridView grid)
        {
            var data = _teacherService.GetAll().Select(t => new
            {
                t.Id,
                ФИО = $"{t.LastName} {t.FirstName[0]}. {t.MiddleName[0]}",
                Лимит = t.LoadLimit
            }).ToList();
            grid.DataSource = data;
        }

        private void LoadSubjects(DataGridView grid)
        {
            var data = _subjectService.GetAll().Select(s => new
            {
                s.Id,
                Название = s.Name,
                Часы = s.Hours
            }).ToList();
            grid.DataSource = data;
        }

        private void LoadGroups(DataGridView grid)
        {
            var data = _groupService.GetAll().Select(g => new
            {
                g.Id,
                Название = g.Name,
                Факультет = _facultyService.GetById(g.FacultyId)?.ShortName
            }).ToList();
            grid.DataSource = data;
        }

        private void LoadFaculties(DataGridView grid)
        {
            var data = _facultyService.GetAll().Select(f => new
            {
                f.Id,
                Сокращение = f.ShortName,
                Название = f.FullName
            }).ToList();
            grid.DataSource = data;
        }

        private void LoadLoads(DataGridView grid)
        {
            var data = _loadService.GetAll().Select(l => new
            {
                l.Id,
                Преподаватель = _teacherService.GetById(l.TeacherId)?.LastName,
                Семестр = l.Semestr,
                Часы = l.LoadHours
            }).ToList();
            grid.DataSource = data;
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            var form = new AddTeacherForm();
            form.TeacherAdded += () => LoadTeachers(teachersGrid);
            form.ShowDialog();
        }
    }
}
