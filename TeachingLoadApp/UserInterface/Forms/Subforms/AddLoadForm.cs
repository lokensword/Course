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
using TeachingLoadApp.Models;

namespace TeachingLoadApp.UserInterface.Forms.Subforms
{
    public partial class AddLoadForm : Form
    {
        private readonly ILoadService _loadService;
        private readonly ITeacherService _teacherService;

        public event Action LoadAdded;
        public AddLoadForm(ILoadService loadService, ITeacherService teacherService)
        {
            InitializeComponent();
            _loadService = loadService;
            _teacherService = teacherService;
            LoadTeachers();
            LoadSemesters();
        }
        private void LoadTeachers()
        {
            var teachers = _teacherService.GetAll().ToList();
            teacherComboBox.DisplayMember = nameof(Teacher.LastName);
            teacherComboBox.ValueMember = nameof(Teacher.Id);
            teacherComboBox.DataSource = teachers;
        }

        private void LoadSemesters()
        {
            semesterComboBox.Items.Add("winter");
            semesterComboBox.Items.Add("summer");
            semesterComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!(teacherComboBox.SelectedItem is Teacher selectedTeacher))
            {
                MessageBox.Show("Choose teacher");
                return;
            }

            if (semesterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Choose semestr");
                return;
            }

            if (!int.TryParse(loadHoursTextBox.Text.Trim(), out int hours) || hours <= 0)
            {
                MessageBox.Show("Incorrect format of hours");
                return;
            }

            var load = new Load
            {
                TeacherId = selectedTeacher.Id,
                Semestr = semesterComboBox.SelectedItem.ToString(),
                LoadHours = hours
            };

            try
            {
                _loadService.Add(load);
                LoadAdded?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
