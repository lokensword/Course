namespace TeachingLoadApp.UserInterface.Forms
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.loadGridView = new System.Windows.Forms.DataGridView();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "winter",
            "summer"});
            this.semesterComboBox.Location = new System.Drawing.Point(89, 13);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(121, 24);
            this.semesterComboBox.TabIndex = 0;
            this.semesterComboBox.SelectedIndexChanged += new System.EventHandler(this.semestrComboBox_SelectedIndexChanged);
            // 
            // loadGridView
            // 
            this.loadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadGridView.Location = new System.Drawing.Point(13, 43);
            this.loadGridView.Name = "loadGridView";
            this.loadGridView.RowHeadersWidth = 51;
            this.loadGridView.RowTemplate.Height = 24;
            this.loadGridView.Size = new System.Drawing.Size(750, 375);
            this.loadGridView.TabIndex = 1;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.Location = new System.Drawing.Point(535, 13);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(228, 24);
            this.teacherNameLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semester";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherNameLabel);
            this.Controls.Add(this.loadGridView);
            this.Controls.Add(this.semesterComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherForm";
            this.Text = "Teacher Mode";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.DataGridView loadGridView;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label label1;
    }
}