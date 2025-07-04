namespace TeachingLoadApp.UserInterface.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.teachersTabPage = new System.Windows.Forms.TabPage();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.deleteTeacherButton = new System.Windows.Forms.Button();
            this.teachersGrid = new System.Windows.Forms.DataGridView();
            this.subjectsTabPage = new System.Windows.Forms.TabPage();
            this.subjectsGrid = new System.Windows.Forms.DataGridView();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.groupsTabPage = new System.Windows.Forms.TabPage();
            this.groupsGrid = new System.Windows.Forms.DataGridView();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.facultiesTabPage = new System.Windows.Forms.TabPage();
            this.addFacultyButton = new System.Windows.Forms.Button();
            this.deleteFacultyButton = new System.Windows.Forms.Button();
            this.facultiesGrid = new System.Windows.Forms.DataGridView();
            this.loadTabPage = new System.Windows.Forms.TabPage();
            this.loadsGrid = new System.Windows.Forms.DataGridView();
            this.addLoadButton = new System.Windows.Forms.Button();
            this.deleteLoadButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.teachersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGrid)).BeginInit();
            this.subjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsGrid)).BeginInit();
            this.groupsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).BeginInit();
            this.facultiesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesGrid)).BeginInit();
            this.loadTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.teachersTabPage);
            this.adminTabControl.Controls.Add(this.subjectsTabPage);
            this.adminTabControl.Controls.Add(this.groupsTabPage);
            this.adminTabControl.Controls.Add(this.facultiesTabPage);
            this.adminTabControl.Controls.Add(this.loadTabPage);
            this.adminTabControl.Location = new System.Drawing.Point(12, 13);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1244, 653);
            this.adminTabControl.TabIndex = 0;
            // 
            // teachersTabPage
            // 
            this.teachersTabPage.Controls.Add(this.addTeacherButton);
            this.teachersTabPage.Controls.Add(this.deleteTeacherButton);
            this.teachersTabPage.Controls.Add(this.teachersGrid);
            this.teachersTabPage.Location = new System.Drawing.Point(4, 25);
            this.teachersTabPage.Name = "teachersTabPage";
            this.teachersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.teachersTabPage.Size = new System.Drawing.Size(1236, 624);
            this.teachersTabPage.TabIndex = 0;
            this.teachersTabPage.Text = "Teachers";
            this.teachersTabPage.UseVisualStyleBackColor = true;
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(1027, 595);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(84, 23);
            this.addTeacherButton.TabIndex = 5;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // deleteTeacherButton
            // 
            this.deleteTeacherButton.Location = new System.Drawing.Point(1117, 595);
            this.deleteTeacherButton.Name = "deleteTeacherButton";
            this.deleteTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTeacherButton.TabIndex = 4;
            this.deleteTeacherButton.Text = "Delete";
            this.deleteTeacherButton.UseVisualStyleBackColor = true;
            this.deleteTeacherButton.Click += new System.EventHandler(this.deleteTeacherButton_Click);
            // 
            // teachersGrid
            // 
            this.teachersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.teachersGrid.Location = new System.Drawing.Point(0, 0);
            this.teachersGrid.Name = "teachersGrid";
            this.teachersGrid.RowHeadersWidth = 51;
            this.teachersGrid.RowTemplate.Height = 24;
            this.teachersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.teachersGrid.Size = new System.Drawing.Size(1192, 589);
            this.teachersGrid.TabIndex = 0;
            this.teachersGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.teachersGrid_CellEndEdit);
            this.teachersGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.teachersGrid_RowValidating);
            // 
            // subjectsTabPage
            // 
            this.subjectsTabPage.Controls.Add(this.subjectsGrid);
            this.subjectsTabPage.Controls.Add(this.addSubjectButton);
            this.subjectsTabPage.Controls.Add(this.deleteSubjectButton);
            this.subjectsTabPage.Location = new System.Drawing.Point(4, 25);
            this.subjectsTabPage.Name = "subjectsTabPage";
            this.subjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsTabPage.Size = new System.Drawing.Size(1236, 624);
            this.subjectsTabPage.TabIndex = 1;
            this.subjectsTabPage.Text = "Subjects";
            this.subjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // subjectsGrid
            // 
            this.subjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsGrid.Location = new System.Drawing.Point(3, 3);
            this.subjectsGrid.Name = "subjectsGrid";
            this.subjectsGrid.RowHeadersWidth = 51;
            this.subjectsGrid.RowTemplate.Height = 24;
            this.subjectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.subjectsGrid.Size = new System.Drawing.Size(1190, 586);
            this.subjectsGrid.TabIndex = 2;
            this.subjectsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectsGrid_CellEndEdit);
            this.subjectsGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.subjectsGrid_RowValidating);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(1025, 595);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(87, 23);
            this.addSubjectButton.TabIndex = 1;
            this.addSubjectButton.Text = "Add";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Location = new System.Drawing.Point(1118, 595);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSubjectButton.TabIndex = 0;
            this.deleteSubjectButton.Text = "Delete";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // groupsTabPage
            // 
            this.groupsTabPage.Controls.Add(this.groupsGrid);
            this.groupsTabPage.Controls.Add(this.addGroupButton);
            this.groupsTabPage.Controls.Add(this.deleteGroupButton);
            this.groupsTabPage.Location = new System.Drawing.Point(4, 25);
            this.groupsTabPage.Name = "groupsTabPage";
            this.groupsTabPage.Size = new System.Drawing.Size(1236, 624);
            this.groupsTabPage.TabIndex = 2;
            this.groupsTabPage.Text = "Groups";
            this.groupsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupsGrid
            // 
            this.groupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGrid.Location = new System.Drawing.Point(4, 4);
            this.groupsGrid.Name = "groupsGrid";
            this.groupsGrid.RowHeadersWidth = 51;
            this.groupsGrid.RowTemplate.Height = 24;
            this.groupsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.groupsGrid.Size = new System.Drawing.Size(1187, 588);
            this.groupsGrid.TabIndex = 2;
            this.groupsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupsGrid_CellEndEdit);
            this.groupsGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.groupsGrid_RowValidating);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(1026, 598);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(84, 23);
            this.addGroupButton.TabIndex = 1;
            this.addGroupButton.Text = "Add";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(1116, 598);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(75, 23);
            this.deleteGroupButton.TabIndex = 0;
            this.deleteGroupButton.Text = "Delete";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // facultiesTabPage
            // 
            this.facultiesTabPage.Controls.Add(this.addFacultyButton);
            this.facultiesTabPage.Controls.Add(this.deleteFacultyButton);
            this.facultiesTabPage.Controls.Add(this.facultiesGrid);
            this.facultiesTabPage.Location = new System.Drawing.Point(4, 25);
            this.facultiesTabPage.Name = "facultiesTabPage";
            this.facultiesTabPage.Size = new System.Drawing.Size(1236, 624);
            this.facultiesTabPage.TabIndex = 3;
            this.facultiesTabPage.Text = "Faculties";
            this.facultiesTabPage.UseVisualStyleBackColor = true;
            // 
            // addFacultyButton
            // 
            this.addFacultyButton.Location = new System.Drawing.Point(1027, 598);
            this.addFacultyButton.Name = "addFacultyButton";
            this.addFacultyButton.Size = new System.Drawing.Size(84, 23);
            this.addFacultyButton.TabIndex = 2;
            this.addFacultyButton.Text = "Add";
            this.addFacultyButton.UseVisualStyleBackColor = true;
            this.addFacultyButton.Click += new System.EventHandler(this.addFacultyButton_Click);
            // 
            // deleteFacultyButton
            // 
            this.deleteFacultyButton.Location = new System.Drawing.Point(1117, 598);
            this.deleteFacultyButton.Name = "deleteFacultyButton";
            this.deleteFacultyButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFacultyButton.TabIndex = 1;
            this.deleteFacultyButton.Text = "Delete";
            this.deleteFacultyButton.UseVisualStyleBackColor = true;
            this.deleteFacultyButton.Click += new System.EventHandler(this.deleteFacultyButton_Click);
            // 
            // facultiesGrid
            // 
            this.facultiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultiesGrid.Location = new System.Drawing.Point(4, 4);
            this.facultiesGrid.Name = "facultiesGrid";
            this.facultiesGrid.RowHeadersWidth = 51;
            this.facultiesGrid.RowTemplate.Height = 24;
            this.facultiesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.facultiesGrid.Size = new System.Drawing.Size(1188, 588);
            this.facultiesGrid.TabIndex = 0;
            this.facultiesGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultiesGrid_CellEndEdit);
            this.facultiesGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.facultiesGrid_RowValidating);
            // 
            // loadTabPage
            // 
            this.loadTabPage.Controls.Add(this.loadsGrid);
            this.loadTabPage.Controls.Add(this.addLoadButton);
            this.loadTabPage.Controls.Add(this.deleteLoadButton);
            this.loadTabPage.Location = new System.Drawing.Point(4, 25);
            this.loadTabPage.Name = "loadTabPage";
            this.loadTabPage.Size = new System.Drawing.Size(1236, 624);
            this.loadTabPage.TabIndex = 4;
            this.loadTabPage.Text = "Load";
            this.loadTabPage.UseVisualStyleBackColor = true;
            // 
            // loadsGrid
            // 
            this.loadsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadsGrid.Location = new System.Drawing.Point(3, 3);
            this.loadsGrid.Name = "loadsGrid";
            this.loadsGrid.RowHeadersWidth = 51;
            this.loadsGrid.RowTemplate.Height = 24;
            this.loadsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.loadsGrid.Size = new System.Drawing.Size(1182, 589);
            this.loadsGrid.TabIndex = 2;
            this.loadsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadsGrid_CellEndEdit);
            this.loadsGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.loadsGrid_RowValidating);
            // 
            // addLoadButton
            // 
            this.addLoadButton.Location = new System.Drawing.Point(1018, 598);
            this.addLoadButton.Name = "addLoadButton";
            this.addLoadButton.Size = new System.Drawing.Size(86, 23);
            this.addLoadButton.TabIndex = 1;
            this.addLoadButton.Text = "Add";
            this.addLoadButton.UseVisualStyleBackColor = true;
            this.addLoadButton.Click += new System.EventHandler(this.addLoadButton_Click);
            // 
            // deleteLoadButton
            // 
            this.deleteLoadButton.Location = new System.Drawing.Point(1110, 598);
            this.deleteLoadButton.Name = "deleteLoadButton";
            this.deleteLoadButton.Size = new System.Drawing.Size(75, 23);
            this.deleteLoadButton.TabIndex = 0;
            this.deleteLoadButton.Text = "Delete";
            this.deleteLoadButton.UseVisualStyleBackColor = true;
            this.deleteLoadButton.Click += new System.EventHandler(this.deleteLoadButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 678);
            this.Controls.Add(this.adminTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Admin Mode";
            this.adminTabControl.ResumeLayout(false);
            this.teachersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachersGrid)).EndInit();
            this.subjectsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsGrid)).EndInit();
            this.groupsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).EndInit();
            this.facultiesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facultiesGrid)).EndInit();
            this.loadTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage teachersTabPage;
        private System.Windows.Forms.TabPage subjectsTabPage;
        private System.Windows.Forms.TabPage groupsTabPage;
        private System.Windows.Forms.TabPage facultiesTabPage;
        private System.Windows.Forms.TabPage loadTabPage;
        private System.Windows.Forms.DataGridView teachersGrid;
        private System.Windows.Forms.DataGridView subjectsGrid;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Button deleteSubjectButton;
        private System.Windows.Forms.DataGridView groupsGrid;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.Button addFacultyButton;
        private System.Windows.Forms.Button deleteFacultyButton;
        private System.Windows.Forms.DataGridView facultiesGrid;
        private System.Windows.Forms.DataGridView loadsGrid;
        private System.Windows.Forms.Button addLoadButton;
        private System.Windows.Forms.Button deleteLoadButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button deleteTeacherButton;
    }
}