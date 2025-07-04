namespace TeachingLoadApp.UserInterface.Forms.Subforms
{
    partial class AddLoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLoadForm));
            this.loadHoursTextBox = new System.Windows.Forms.TextBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadHoursTextBox
            // 
            this.loadHoursTextBox.Location = new System.Drawing.Point(98, 90);
            this.loadHoursTextBox.Name = "loadHoursTextBox";
            this.loadHoursTextBox.Size = new System.Drawing.Size(121, 22);
            this.loadHoursTextBox.TabIndex = 0;
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(98, 60);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(121, 24);
            this.semesterComboBox.TabIndex = 1;
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(98, 30);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(121, 24);
            this.teacherComboBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(98, 119);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Load Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Semester";
            // 
            // AddLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.loadHoursTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddLoadForm";
            this.Text = "Add Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loadHoursTextBox;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}