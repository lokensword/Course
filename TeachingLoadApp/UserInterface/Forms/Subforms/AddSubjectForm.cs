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
    public partial class AddSubjectForm : Form
    {
        private readonly ISubjectService _subjectService;

        public event Action SubjectAdded;
        public AddSubjectForm(ISubjectService subjectService)
        {
            InitializeComponent();
            _subjectService = subjectService;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название предмета.");
                return;
            }

            if (!int.TryParse(hoursTextBox.Text.Trim(), out int hours) || hours <= 0)
            {
                MessageBox.Show("Введите корректное количество часов.");
                return;
            }

            var subject = new Subject
            {
                Name = name,
                Hours = hours
            };

            try
            {
                _subjectService.Add(subject);
                SubjectAdded?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении предмета: " + ex.Message);
            }
        }
    }
}
