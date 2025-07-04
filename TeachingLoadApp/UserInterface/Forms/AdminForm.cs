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
using TeachingLoadApp.Models;
using TeachingLoadApp.UserInterface.Forms.Subforms;

namespace TeachingLoadApp.UserInterface.Forms
{

    public partial class AdminForm : Form
    {
        private readonly IUserService _userService;
        private readonly ITeacherService _teacherService;
        private readonly ISubjectService _subjectService;
        private readonly IGroupService _groupService;
        private readonly IFacultyService _facultyService;
        private readonly ILoadService _loadService;

        public AdminForm(   IUserService userService,
                            ITeacherService teacherService,
                            ISubjectService subjectService,
                            IGroupService groupService,
                            IFacultyService facultyService,
                            ILoadService loadService)
        {
            InitializeComponent();
            
            _userService = userService;
            _teacherService = teacherService;
            _subjectService = subjectService;
            _groupService = groupService;
            _facultyService = facultyService;
            _loadService = loadService;

            LoadTeachers(teachersGrid);
            LoadSubjects(subjectsGrid);
            LoadGroups(groupsGrid);
            LoadFaculties(facultiesGrid);
            LoadLoads(loadsGrid);   
        }

        private void LoadTeachers(DataGridView grid)
        {
            /*
             * grid.DataSource = _teacherService.GetAll().Select(t => new
            {
                t.Id,
                ФИО = $"{t.LastName} {t.FirstName[0]}. {t.MiddleName[0]}",
                Лимит = t.LoadLimit
            }).ToList();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            grid.Columns["Id"].ReadOnly = true;
            grid.Columns["ФИО"].ReadOnly = true;
            grid.Columns["Лимит"].ReadOnly = false;
            */
            grid.DataSource = _teacherService.GetAll();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void LoadSubjects(DataGridView grid)
        {
            /*
            grid.DataSource = _subjectService.GetAll().Select(s => new
            {
                s.Id,
                Название = s.Name,
                Часы = s.Hours
            }).ToList();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            grid.Columns["Id"].ReadOnly = true;
            grid.Columns["Название"].ReadOnly = false;
            grid.Columns["Часы"].ReadOnly = false;
            */
            grid.DataSource = _subjectService.GetAll();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void LoadGroups(DataGridView grid)
        {
            /*
            grid.DataSource = _groupService.GetAll().Select(g => new
            {
                g.Id,
                Название = g.Name,
                Факультет = _facultyService.GetById(g.FacultyId)?.ShortName
            }).ToList();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            grid.Columns["Id"].ReadOnly = true;
            grid.Columns["Факультет"].ReadOnly = true;
            */
            grid.DataSource = _groupService.GetAll();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void LoadFaculties(DataGridView grid)
        {
            /*
            grid.DataSource = _facultyService.GetAll().Select(f => new
            {
                f.Id,
                Сокращение = f.ShortName,
                Название = f.FullName
            }).ToList();

            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            grid.Columns["Id"].ReadOnly = true;
            */
            grid.DataSource = _facultyService.GetAll();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void LoadLoads(DataGridView grid)
        {

            /*grid.DataSource = _loadService.GetAll().Select(l => new
            {
                l.Id,
                Преподаватель = _teacherService.GetById(l.TeacherId)?.LastName,
                Семестр = l.Semestr,
                Часы = l.LoadHours
            }).ToList();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            grid.Columns["Id"].ReadOnly = true;
            grid.Columns["Преподаватель"].ReadOnly = true;
            grid.Columns["Семестр"].ReadOnly = true;
            */
            grid.DataSource = _loadService.GetAll();
            grid.ReadOnly = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        private bool TryGetSelectedObject<T>(DataGridView grid, out T obj) where T : class
        {
            obj = null;

            if (grid.SelectedCells.Count == 0)
                return false;

            int rowIndex = grid.SelectedCells[0].RowIndex;
            var row = grid.Rows[rowIndex];

            if (row.DataBoundItem is T boundObject)
            {
                obj = boundObject;
                return true;
            }

            return false;
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            var form = new AddTeacherForm(_teacherService, _userService);
            form.TeacherAdded += () => LoadTeachers(teachersGrid);
            form.ShowDialog();
        }
        private bool ConfirmDelete(string message)
        {
            return MessageBox.Show(message, "Submit", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedObject<Teacher>(teachersGrid, out var teacher))
            {
                MessageBox.Show("Choose teacher");
                return;
            }

            if (ConfirmDelete("Are you sure?"))
            {
                _teacherService.Delete(teacher.Id);
                LoadTeachers(teachersGrid);
                LoadLoads(loadsGrid);
            }
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedObject<Subject>(subjectsGrid, out var subject))
            {
                MessageBox.Show("Choose subject");
                return;
            }

            if (ConfirmDelete("Are you sure?"))
            {
                _subjectService.Delete(subject.Id);
                LoadSubjects(subjectsGrid);
            }
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedObject<Group>(groupsGrid, out var group))
            {
                MessageBox.Show("Choose group");
                return;
            }

            if (ConfirmDelete("Are you sure?"))
            {
                _groupService.Delete(group.Id);
                LoadGroups(groupsGrid);
            }
        }

        private void deleteFacultyButton_Click(object sender, EventArgs e)
        {

            if (!TryGetSelectedObject<Faculty>(facultiesGrid, out var faculty))
            {
                MessageBox.Show("Choose faculty");
                return;
            }

            if (ConfirmDelete("Are you sure?"))
            {
                _facultyService.Delete(faculty.Id);
                LoadFaculties(facultiesGrid);
                LoadGroups(groupsGrid);
            }
        }

        private void deleteLoadButton_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedObject<Load>(loadsGrid, out var load))
            {
                MessageBox.Show("Choose load");
                return;
            }

            if (ConfirmDelete("Are you sure?"))
            {
                _loadService.Delete(load.Id);
                LoadLoads(loadsGrid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updTeacherButton_Click(object sender, EventArgs e)
        {

        }

        private void teachersGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = teachersGrid.Rows[e.RowIndex];

            if (row.DataBoundItem is Teacher teacher)
            {
                _teacherService.Update(teacher);
            }
        }

        private void subjectsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = subjectsGrid.Rows[e.RowIndex];

            if (row.DataBoundItem is Subject subject)
            {
                _subjectService.Update(subject);
            }
        }

        private void groupsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = groupsGrid.Rows[e.RowIndex];

            if (row.DataBoundItem is Group group)
            {
                _groupService.Update(group);
            }
        }

        private void facultiesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = facultiesGrid.Rows[e.RowIndex];

            if (row.DataBoundItem is Faculty faculty)
            {
                _facultyService.Update(faculty);
            }
        }

        private void loadsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = loadsGrid.Rows[e.RowIndex];

            if (row.DataBoundItem is Load load)
            {
                _loadService.Update(load);
            }
        }

        private void addLoadButton_Click(object sender, EventArgs e)
        {
            var form = new AddLoadForm(_loadService, _teacherService);
            form.LoadAdded += () => LoadLoads(loadsGrid);
            form.ShowDialog();
        }

        private void teachersGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = teachersGrid.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.DataBoundItem is Teacher teacher)
            {
                if (teacher.Id == 0)
                {
                    _teacherService.Add(teacher);
                }
                else
                {
                    _teacherService.Update(teacher);
                }
            }
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            var form = new AddSubjectForm(_subjectService);
            form.SubjectAdded += () => LoadSubjects(subjectsGrid);
            form.ShowDialog();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            var form = new AddGroupForm(_groupService, _facultyService);
            form.GroupAdded += () => LoadGroups(groupsGrid);
            form.ShowDialog();
        }

        private void addFacultyButton_Click(object sender, EventArgs e)
        {
            var form = new AddFacultyForm(_facultyService);
            form.FacultyAdded += () => LoadFaculties(facultiesGrid);
            form.ShowDialog();
        }

        private void subjectsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = subjectsGrid.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.DataBoundItem is Subject subject)
            {
                if (subject.Id == 0)
                {
                    _subjectService.Add(subject);
                }
                else
                {
                    _subjectService.Update(subject);
                }
            }
        }

        private void groupsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = groupsGrid.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.DataBoundItem is Group group)
            {
                if (group.Id == 0)
                {
                    _groupService.Add(group);
                }
                else
                {
                    _groupService.Update(group);
                }
            }
        }

        private void facultiesGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = facultiesGrid.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.DataBoundItem is Faculty faculty)
            {
                if (faculty.Id == 0)
                {
                    _facultyService.Add(faculty);
                }
                else
                {
                    _facultyService.Update(faculty);
                }
            }
        }

        private void loadsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = loadsGrid.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.DataBoundItem is Load load)
            {
                if (load.Id == 0)
                {
                    _loadService.Add(load);
                }
                else
                {
                    _loadService.Update(load);
                }
            }
        }
    }
}
