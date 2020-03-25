namespace LibraryManagement
{
    partial class Add_Student_Info
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.department_combo = new System.Windows.Forms.ComboBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.studentImagePictureBox = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.student_id_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.student_batch_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_contact_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.student_email_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.student_name_tbox = new System.Windows.Forms.TextBox();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.department_combo);
            this.panel1.Controls.Add(this.browseBtn);
            this.panel1.Controls.Add(this.studentImagePictureBox);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.student_id_tbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.student_batch_tbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.student_contact_tbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.student_email_tbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.student_name_tbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 223);
            this.panel1.TabIndex = 0;
            // 
            // department_combo
            // 
            this.department_combo.FormattingEnabled = true;
            this.department_combo.Location = new System.Drawing.Point(143, 64);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(159, 21);
            this.department_combo.TabIndex = 6;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(440, 9);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 14;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // studentImagePictureBox
            // 
            this.studentImagePictureBox.Location = new System.Drawing.Point(402, 38);
            this.studentImagePictureBox.Name = "studentImagePictureBox";
            this.studentImagePictureBox.Size = new System.Drawing.Size(113, 123);
            this.studentImagePictureBox.TabIndex = 15;
            this.studentImagePictureBox.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(440, 180);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save Info";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Student ID";
            // 
            // student_id_tbox
            // 
            this.student_id_tbox.Location = new System.Drawing.Point(143, 11);
            this.student_id_tbox.Name = "student_id_tbox";
            this.student_id_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_id_tbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Student Batch";
            // 
            // student_batch_tbox
            // 
            this.student_batch_tbox.Location = new System.Drawing.Point(143, 141);
            this.student_batch_tbox.Name = "student_batch_tbox";
            this.student_batch_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_batch_tbox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Contact";
            // 
            // student_contact_tbox
            // 
            this.student_contact_tbox.Location = new System.Drawing.Point(143, 115);
            this.student_contact_tbox.Name = "student_contact_tbox";
            this.student_contact_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_contact_tbox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Email";
            // 
            // student_email_tbox
            // 
            this.student_email_tbox.Location = new System.Drawing.Point(143, 89);
            this.student_email_tbox.Name = "student_email_tbox";
            this.student_email_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_email_tbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name";
            // 
            // student_name_tbox
            // 
            this.student_name_tbox.Location = new System.Drawing.Point(143, 37);
            this.student_name_tbox.Name = "student_name_tbox";
            this.student_name_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_name_tbox.TabIndex = 4;
            // 
            // Add_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 245);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Student_Info";
            this.Text = "Add_Student_Info";
            this.Load += new System.EventHandler(this.Add_Student_Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.PictureBox studentImagePictureBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox student_id_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_batch_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox student_contact_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_email_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox student_name_tbox;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ComboBox department_combo;
    }
}