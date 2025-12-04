namespace DB_UserControl
{
    partial class Form1
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
            DB_UserControl.Subject subject1 = new DB_UserControl.Subject();
            DB_UserControl.Subject subject2 = new DB_UserControl.Subject();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.userControlSubjectInsert = new DB_UserControl.UserControlSubject();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.userControlSubjectUpdate = new DB_UserControl.UserControlSubject();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.Location = new System.Drawing.Point(13, 13);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(334, 524);
            this.listBoxSubjects.TabIndex = 0;
            this.listBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.listBoxSubjects_SelectedIndexChanged);
            // 
            // userControlSubjectInsert
            // 
            this.userControlSubjectInsert.Location = new System.Drawing.Point(20, 19);
            subject1.Hours = 0;
            subject1.Id = 0;
            subject1.Name = "";
            subject1.Teacher = null;
            subject1.TeacherId = 0;
            this.userControlSubjectInsert.MySubject = subject1;
            this.userControlSubjectInsert.Name = "userControlSubjectInsert";
            this.userControlSubjectInsert.Size = new System.Drawing.Size(230, 179);
            this.userControlSubjectInsert.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.userControlSubjectInsert);
            this.groupBox1.Location = new System.Drawing.Point(353, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 247);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie przedmiotów";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(113, 205);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(120, 23);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Dodaj do bazy";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.userControlSubjectUpdate);
            this.groupBox2.Location = new System.Drawing.Point(353, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 247);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edycja przedmiotów";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(113, 205);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Aktualizuj";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // userControlSubjectUpdate
            // 
            this.userControlSubjectUpdate.Location = new System.Drawing.Point(20, 19);
            subject2.Hours = 0;
            subject2.Id = 0;
            subject2.Name = "";
            subject2.Teacher = null;
            subject2.TeacherId = 0;
            this.userControlSubjectUpdate.MySubject = subject2;
            this.userControlSubjectUpdate.Name = "userControlSubjectUpdate";
            this.userControlSubjectUpdate.Size = new System.Drawing.Size(230, 179);
            this.userControlSubjectUpdate.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(466, 520);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń z bazy";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 555);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxSubjects);
            this.Name = "Form1";
            this.Text = "Baza danych";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSubjects;
        private UserControlSubject userControlSubjectInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonUpdate;
        private UserControlSubject userControlSubjectUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

