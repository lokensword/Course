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
    public partial class AddFacultyForm : Form
    {
        private readonly IFacultyService _facultyService;

        public event Action FacultyAdded;
        public AddFacultyForm(IFacultyService facultyService)
        {
            InitializeComponent();
            _facultyService = facultyService;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string shortName = shortNameTextBox.Text.Trim();
            string fullName = fullNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(shortName) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            var faculty = new Faculty
            {
                ShortName = shortName,
                FullName = fullName
            };

            try
            {
                _facultyService.Add(faculty);
                FacultyAdded?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
