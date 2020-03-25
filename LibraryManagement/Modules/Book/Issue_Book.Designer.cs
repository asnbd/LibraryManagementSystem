namespace LibraryManagement
{
    partial class Issue_Book
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
            this.search_student_tbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.student_name_tbox = new System.Windows.Forms.TextBox();
            this.student_department_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_batch_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.student_email_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_contact_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.book_name_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_issue = new System.Windows.Forms.DateTimePicker();
            this.student_info_panel = new System.Windows.Forms.Panel();
            this.listBox_books = new System.Windows.Forms.ListBox();
            this.issueBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.student_info_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.student_info_panel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.search_student_tbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 351);
            this.panel1.TabIndex = 0;
            // 
            // search_student_tbox
            // 
            this.search_student_tbox.Location = new System.Drawing.Point(9, 28);
            this.search_student_tbox.Name = "search_student_tbox";
            this.search_student_tbox.Size = new System.Drawing.Size(163, 20);
            this.search_student_tbox.TabIndex = 0;
            this.search_student_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_student_tbox_KeyDown);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(97, 54);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search Student";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name";
            // 
            // student_name_tbox
            // 
            this.student_name_tbox.Enabled = false;
            this.student_name_tbox.Location = new System.Drawing.Point(86, 7);
            this.student_name_tbox.Name = "student_name_tbox";
            this.student_name_tbox.Size = new System.Drawing.Size(179, 20);
            this.student_name_tbox.TabIndex = 4;
            // 
            // student_department_tbox
            // 
            this.student_department_tbox.Enabled = false;
            this.student_department_tbox.Location = new System.Drawing.Point(86, 33);
            this.student_department_tbox.Name = "student_department_tbox";
            this.student_department_tbox.Size = new System.Drawing.Size(179, 20);
            this.student_department_tbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // student_batch_tbox
            // 
            this.student_batch_tbox.Enabled = false;
            this.student_batch_tbox.Location = new System.Drawing.Point(86, 59);
            this.student_batch_tbox.Name = "student_batch_tbox";
            this.student_batch_tbox.Size = new System.Drawing.Size(179, 20);
            this.student_batch_tbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Batch";
            // 
            // student_email_tbox
            // 
            this.student_email_tbox.Enabled = false;
            this.student_email_tbox.Location = new System.Drawing.Point(86, 85);
            this.student_email_tbox.Name = "student_email_tbox";
            this.student_email_tbox.Size = new System.Drawing.Size(179, 20);
            this.student_email_tbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // student_contact_tbox
            // 
            this.student_contact_tbox.Enabled = false;
            this.student_contact_tbox.Location = new System.Drawing.Point(86, 111);
            this.student_contact_tbox.Name = "student_contact_tbox";
            this.student_contact_tbox.Size = new System.Drawing.Size(179, 20);
            this.student_contact_tbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Issue Date";
            // 
            // book_name_tbox
            // 
            this.book_name_tbox.Location = new System.Drawing.Point(86, 164);
            this.book_name_tbox.Name = "book_name_tbox";
            this.book_name_tbox.Size = new System.Drawing.Size(179, 20);
            this.book_name_tbox.TabIndex = 16;
            this.book_name_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Book_name_tbox_KeyDown);
            this.book_name_tbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Book_name_tbox_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Book Name";
            // 
            // dateTimePicker_issue
            // 
            this.dateTimePicker_issue.Location = new System.Drawing.Point(86, 138);
            this.dateTimePicker_issue.Name = "dateTimePicker_issue";
            this.dateTimePicker_issue.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_issue.TabIndex = 14;
            // 
            // student_info_panel
            // 
            this.student_info_panel.Controls.Add(this.listBox_books);
            this.student_info_panel.Controls.Add(this.dateTimePicker_issue);
            this.student_info_panel.Controls.Add(this.label8);
            this.student_info_panel.Controls.Add(this.book_name_tbox);
            this.student_info_panel.Controls.Add(this.label2);
            this.student_info_panel.Controls.Add(this.student_name_tbox);
            this.student_info_panel.Controls.Add(this.label7);
            this.student_info_panel.Controls.Add(this.label3);
            this.student_info_panel.Controls.Add(this.student_contact_tbox);
            this.student_info_panel.Controls.Add(this.student_department_tbox);
            this.student_info_panel.Controls.Add(this.label6);
            this.student_info_panel.Controls.Add(this.label4);
            this.student_info_panel.Controls.Add(this.student_email_tbox);
            this.student_info_panel.Controls.Add(this.student_batch_tbox);
            this.student_info_panel.Controls.Add(this.label5);
            this.student_info_panel.Controls.Add(this.issueBtn);
            this.student_info_panel.Location = new System.Drawing.Point(209, 19);
            this.student_info_panel.Name = "student_info_panel";
            this.student_info_panel.Size = new System.Drawing.Size(272, 315);
            this.student_info_panel.TabIndex = 18;
            this.student_info_panel.Visible = false;
            // 
            // listBox_books
            // 
            this.listBox_books.FormattingEnabled = true;
            this.listBox_books.Location = new System.Drawing.Point(86, 184);
            this.listBox_books.Name = "listBox_books";
            this.listBox_books.Size = new System.Drawing.Size(179, 95);
            this.listBox_books.TabIndex = 18;
            this.listBox_books.Visible = false;
            this.listBox_books.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_books_MouseClick);
            this.listBox_books.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBox_books_KeyDown);
            // 
            // issueBtn
            // 
            this.issueBtn.Location = new System.Drawing.Point(190, 285);
            this.issueBtn.Name = "issueBtn";
            this.issueBtn.Size = new System.Drawing.Size(75, 23);
            this.issueBtn.TabIndex = 17;
            this.issueBtn.Text = "Issue Book";
            this.issueBtn.UseVisualStyleBackColor = true;
            this.issueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // Issue_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 371);
            this.Controls.Add(this.panel1);
            this.Name = "Issue_Book";
            this.Text = "Issue_Book";
            this.Load += new System.EventHandler(this.Issue_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.student_info_panel.ResumeLayout(false);
            this.student_info_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox search_student_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox student_name_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_name_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox student_contact_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_email_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox student_batch_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_department_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_issue;
        private System.Windows.Forms.Panel student_info_panel;
        private System.Windows.Forms.ListBox listBox_books;
        private System.Windows.Forms.Button issueBtn;
    }
}