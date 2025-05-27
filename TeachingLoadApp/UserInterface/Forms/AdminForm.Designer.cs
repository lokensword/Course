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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.teachersTabPage = new System.Windows.Forms.TabPage();
            this.subjectsTabPage = new System.Windows.Forms.TabPage();
            this.groupsTabPage = new System.Windows.Forms.TabPage();
            this.facultiesTabPage = new System.Windows.Forms.TabPage();
            this.loadTabPage = new System.Windows.Forms.TabPage();
            this.teachersGrid = new System.Windows.Forms.DataGridView();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.subjectsGrid = new System.Windows.Forms.DataGridView();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.groupsGrid = new System.Windows.Forms.DataGridView();
            this.facultiesGrid = new System.Windows.Forms.DataGridView();
            this.deleteFacultyButton = new System.Windows.Forms.Button();
            this.addFacultyButton = new System.Windows.Forms.Button();
            this.deleteLoadButton = new System.Windows.Forms.Button();
            this.addLoadButton = new System.Windows.Forms.Button();
            this.loadsGrid = new System.Windows.Forms.DataGridView();
            this.deleteTeacherButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.teachersTabPage.SuspendLayout();
            this.subjectsTabPage.SuspendLayout();
            this.groupsTabPage.SuspendLayout();
            this.facultiesTabPage.SuspendLayout();
            this.loadTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesGrid)).BeginInit();
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
            this.adminTabControl.Location = new System.Drawing.Point(13, 13);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(775, 425);
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
            this.teachersTabPage.Size = new System.Drawing.Size(767, 396);
            this.teachersTabPage.TabIndex = 0;
            this.teachersTabPage.Text = "tabPage1";
            this.teachersTabPage.UseVisualStyleBackColor = true;
            // 
            // subjectsTabPage
            // 
            this.subjectsTabPage.Controls.Add(this.subjectsGrid);
            this.subjectsTabPage.Controls.Add(this.addSubjectButton);
            this.subjectsTabPage.Controls.Add(this.deleteSubjectButton);
            this.subjectsTabPage.Location = new System.Drawing.Point(4, 25);
            this.subjectsTabPage.Name = "subjectsTabPage";
            this.subjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsTabPage.Size = new System.Drawing.Size(767, 396);
            this.subjectsTabPage.TabIndex = 1;
            this.subjectsTabPage.Text = "tabPage2";
            this.subjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupsTabPage
            // 
            this.groupsTabPage.Controls.Add(this.groupsGrid);
            this.groupsTabPage.Controls.Add(this.addGroupButton);
            this.groupsTabPage.Controls.Add(this.deleteGroupButton);
            this.groupsTabPage.Location = new System.Drawing.Point(4, 25);
            this.groupsTabPage.Name = "groupsTabPage";
            this.groupsTabPage.Size = new System.Drawing.Size(767, 396);
            this.groupsTabPage.TabIndex = 2;
            this.groupsTabPage.Text = "tabPage3";
            this.groupsTabPage.UseVisualStyleBackColor = true;
            // 
            // facultiesTabPage
            // 
            this.facultiesTabPage.Controls.Add(this.addFacultyButton);
            this.facultiesTabPage.Controls.Add(this.deleteFacultyButton);
            this.facultiesTabPage.Controls.Add(this.facultiesGrid);
            this.facultiesTabPage.Location = new System.Drawing.Point(4, 25);
            this.facultiesTabPage.Name = "facultiesTabPage";
            this.facultiesTabPage.Size = new System.Drawing.Size(767, 396);
            this.facultiesTabPage.TabIndex = 3;
            this.facultiesTabPage.Text = "tabPage4";
            this.facultiesTabPage.UseVisualStyleBackColor = true;
            // 
            // loadTabPage
            // 
            this.loadTabPage.Controls.Add(this.loadsGrid);
            this.loadTabPage.Controls.Add(this.addLoadButton);
            this.loadTabPage.Controls.Add(this.deleteLoadButton);
            this.loadTabPage.Location = new System.Drawing.Point(4, 25);
            this.loadTabPage.Name = "loadTabPage";
            this.loadTabPage.Size = new System.Drawing.Size(767, 396);
            this.loadTabPage.TabIndex = 4;
            this.loadTabPage.Text = "tabPage5";
            this.loadTabPage.UseVisualStyleBackColor = true;
            // 
            // teachersGrid
            // 
            this.teachersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersGrid.Location = new System.Drawing.Point(0, 0);
            this.teachersGrid.Name = "teachersGrid";
            this.teachersGrid.RowHeadersWidth = 51;
            this.teachersGrid.RowTemplate.Height = 24;
            this.teachersGrid.Size = new System.Drawing.Size(764, 364);
            this.teachersGrid.TabIndex = 0;
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Location = new System.Drawing.Point(686, 370);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSubjectButton.TabIndex = 0;
            this.deleteSubjectButton.Text = "del";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(605, 370);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.addSubjectButton.TabIndex = 1;
            this.addSubjectButton.Text = "add";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            // 
            // subjectsGrid
            // 
            this.subjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsGrid.Location = new System.Drawing.Point(3, 3);
            this.subjectsGrid.Name = "subjectsGrid";
            this.subjectsGrid.RowHeadersWidth = 51;
            this.subjectsGrid.RowTemplate.Height = 24;
            this.subjectsGrid.Size = new System.Drawing.Size(760, 361);
            this.subjectsGrid.TabIndex = 2;
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(689, 370);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(75, 23);
            this.deleteGroupButton.TabIndex = 0;
            this.deleteGroupButton.Text = "del";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(608, 370);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(75, 23);
            this.addGroupButton.TabIndex = 1;
            this.addGroupButton.Text = "add";
            this.addGroupButton.UseVisualStyleBackColor = true;
            // 
            // groupsGrid
            // 
            this.groupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGrid.Location = new System.Drawing.Point(4, 4);
            this.groupsGrid.Name = "groupsGrid";
            this.groupsGrid.RowHeadersWidth = 51;
            this.groupsGrid.RowTemplate.Height = 24;
            this.groupsGrid.Size = new System.Drawing.Size(760, 360);
            this.groupsGrid.TabIndex = 2;
            // 
            // facultiesGrid
            // 
            this.facultiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultiesGrid.Location = new System.Drawing.Point(4, 4);
            this.facultiesGrid.Name = "facultiesGrid";
            this.facultiesGrid.RowHeadersWidth = 51;
            this.facultiesGrid.RowTemplate.Height = 24;
            this.facultiesGrid.Size = new System.Drawing.Size(760, 360);
            this.facultiesGrid.TabIndex = 0;
            // 
            // deleteFacultyButton
            // 
            this.deleteFacultyButton.Location = new System.Drawing.Point(689, 370);
            this.deleteFacultyButton.Name = "deleteFacultyButton";
            this.deleteFacultyButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFacultyButton.TabIndex = 1;
            this.deleteFacultyButton.Text = "del";
            this.deleteFacultyButton.UseVisualStyleBackColor = true;
            // 
            // addFacultyButton
            // 
            this.addFacultyButton.Location = new System.Drawing.Point(608, 370);
            this.addFacultyButton.Name = "addFacultyButton";
            this.addFacultyButton.Size = new System.Drawing.Size(75, 23);
            this.addFacultyButton.TabIndex = 2;
            this.addFacultyButton.Text = "add";
            this.addFacultyButton.UseVisualStyleBackColor = true;
            // 
            // deleteLoadButton
            // 
            this.deleteLoadButton.Location = new System.Drawing.Point(689, 370);
            this.deleteLoadButton.Name = "deleteLoadButton";
            this.deleteLoadButton.Size = new System.Drawing.Size(75, 23);
            this.deleteLoadButton.TabIndex = 0;
            this.deleteLoadButton.Text = "del";
            this.deleteLoadButton.UseVisualStyleBackColor = true;
            // 
            // addLoadButton
            // 
            this.addLoadButton.Location = new System.Drawing.Point(608, 370);
            this.addLoadButton.Name = "addLoadButton";
            this.addLoadButton.Size = new System.Drawing.Size(75, 23);
            this.addLoadButton.TabIndex = 1;
            this.addLoadButton.Text = "add";
            this.addLoadButton.UseVisualStyleBackColor = true;
            // 
            // loadsGrid
            // 
            this.loadsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadsGrid.Location = new System.Drawing.Point(4, 4);
            this.loadsGrid.Name = "loadsGrid";
            this.loadsGrid.RowHeadersWidth = 51;
            this.loadsGrid.RowTemplate.Height = 24;
            this.loadsGrid.Size = new System.Drawing.Size(760, 360);
            this.loadsGrid.TabIndex = 2;
            // 
            // deleteTeacherButton
            // 
            this.deleteTeacherButton.Location = new System.Drawing.Point(686, 370);
            this.deleteTeacherButton.Name = "deleteTeacherButton";
            this.deleteTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTeacherButton.TabIndex = 4;
            this.deleteTeacherButton.Text = "del";
            this.deleteTeacherButton.UseVisualStyleBackColor = true;
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(605, 370);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.addTeacherButton.TabIndex = 5;
            this.addTeacherButton.Text = "add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminTabControl);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.adminTabControl.ResumeLayout(false);
            this.teachersTabPage.ResumeLayout(false);
            this.subjectsTabPage.ResumeLayout(false);
            this.groupsTabPage.ResumeLayout(false);
            this.facultiesTabPage.ResumeLayout(false);
            this.loadTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesGrid)).EndInit();
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