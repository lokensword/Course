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
using TeachingLoadApp.Models;

namespace TeachingLoadApp.UserInterface.Forms
{
    public partial class TeacherForm : Form
    {
        private readonly ITeacherService _teacherService;
        private readonly ILoadService _loadService;
        private readonly IClassInLoadService _classInLoadService;
        private readonly IClassService _classService;
        private readonly ISubjectService _subjectService;
        private readonly IGroupService _groupService;
        private readonly int _teacherId;

        public TeacherForm( int teacherId, 
                            ITeacherService teacherService, 
                            ILoadService loadService, 
                            IClassInLoadService classInLoadService, 
                            IClassService classService, 
                            ISubjectService subjectService, 
                            IGroupService groupService)
        {
            InitializeComponent();
            _teacherService = teacherService;
            _loadService = loadService;
            _classInLoadService = classInLoadService;
            _classService = classService;
            _subjectService = subjectService;
            _groupService = groupService;
            _teacherId = teacherId;

            LoadTeacher();
        }
        private void LoadTeacher()
        {
            var teacher = _teacherService.GetById(_teacherId);
            teacherNameLabel.Text = $"Преподаватель: {teacher.LastName} {teacher.FirstName[0]}. {teacher.MiddleName[0]}.";
            semesterComboBox.SelectedIndex = 0; // триггерит загрузку нагрузки
        }

        private void semestrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = semesterComboBox.SelectedItem.ToString();

            var loads = _loadService.GetByTeacherId(_teacherId)
                                    .Where(l => l.Semestr == semester)
                                    .ToList();

            var rows = new List<object>();

            foreach (var load in loads)
            {
                var classInLoads = _classInLoadService.GetByLoadId(load.Id);
                foreach (var cil in classInLoads)
                {
                    var cls = _classService.GetById(cil.ClassId);
                    if (cls == null) continue;

                    var subject = _subjectService.GetById(cls.SubjectId);
                    var group = _groupService.GetById(cls.GroupId);
                    if (subject == null || group == null) continue;

                    rows.Add(new
                    {
                        Group = group.Name,
                        Subject = subject.Name,
                        Type = cls.Type,
                        Hours = cls.ClassHours
                    });
                }
            }

            loadGridView.DataSource = rows;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
