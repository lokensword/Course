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
    public partial class AddGroupForm : Form
    {
        private readonly IGroupService _groupService;
        private readonly IFacultyService _facultyService;

        public event Action GroupAdded;
        public AddGroupForm(IGroupService groupService, IFacultyService facultyService)
        {
            InitializeComponent();
            _groupService = groupService;
            _facultyService = facultyService;
            LoadFaculties();
        }
        private void LoadFaculties()
        {
            var faculties = _facultyService.GetAll().ToList();
            facultyComboBox.DisplayMember = "ShortName";
            facultyComboBox.ValueMember = "Id";
            facultyComboBox.DataSource = faculties;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string groupName = nameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Enter group name");
                return;
            }

            var selectedFaculty = facultyComboBox.SelectedItem as Faculty;
            if (selectedFaculty == null)
            {
                MessageBox.Show("Choose falucty");
                return;
            }

            var group = new Group
            {
                Name = groupName,
                FacultyId = selectedFaculty.Id
            };

            try
            {
                _groupService.Add(group);
                GroupAdded?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
