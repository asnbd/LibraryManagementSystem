namespace LibraryManagement
{
    partial class View_Student_Info
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
            this.components = new System.ComponentModel.Container();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.department_combo_search = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_tbox = new System.Windows.Forms.TextBox();
            this.student_info_panel = new System.Windows.Forms.Panel();
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
            this.label8 = new System.Windows.Forms.Label();
            this.student_name_tbox = new System.Windows.Forms.TextBox();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.student_info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.studentDataGridView.Location = new System.Drawing.Point(261, 12);
            this.studentDataGridView.MultiSelect = false;
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(919, 367);
            this.studentDataGridView.TabIndex = 0;
            this.studentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellClick);
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            this.studentDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentDataGridView_CellMouseDown);
            this.studentDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentDataGridView_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItemDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 76);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.IssueBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.ReturnBookToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemDelete.Text = "Delete";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.ToolStripMenuItemDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.department_combo_search);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.search_tbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 115);
            this.panel1.TabIndex = 2;
            this.panel1.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Department";
            // 
            // department_combo_search
            // 
            this.department_combo_search.FormattingEnabled = true;
            this.department_combo_search.Location = new System.Drawing.Point(72, 47);
            this.department_combo_search.Name = "department_combo_search";
            this.department_combo_search.Size = new System.Drawing.Size(160, 21);
            this.department_combo_search.TabIndex = 3;
            this.department_combo_search.Text = "All";
            this.department_combo_search.SelectedValueChanged += new System.EventHandler(this.Department_combo_search_SelectedValueChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(157, 74);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // search_tbox
            // 
            this.search_tbox.Location = new System.Drawing.Point(72, 20);
            this.search_tbox.Name = "search_tbox";
            this.search_tbox.Size = new System.Drawing.Size(160, 20);
            this.search_tbox.TabIndex = 0;
            this.search_tbox.Tag = "";
            this.search_tbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_tbox_KeyUp);
            // 
            // student_info_panel
            // 
            this.student_info_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.student_info_panel.Controls.Add(this.department_combo);
            this.student_info_panel.Controls.Add(this.browseBtn);
            this.student_info_panel.Controls.Add(this.studentImagePictureBox);
            this.student_info_panel.Controls.Add(this.saveBtn);
            this.student_info_panel.Controls.Add(this.label7);
            this.student_info_panel.Controls.Add(this.student_id_tbox);
            this.student_info_panel.Controls.Add(this.label6);
            this.student_info_panel.Controls.Add(this.student_batch_tbox);
            this.student_info_panel.Controls.Add(this.label5);
            this.student_info_panel.Controls.Add(this.student_contact_tbox);
            this.student_info_panel.Controls.Add(this.label4);
            this.student_info_panel.Controls.Add(this.student_email_tbox);
            this.student_info_panel.Controls.Add(this.label3);
            this.student_info_panel.Controls.Add(this.label2);
            this.student_info_panel.Controls.Add(this.label8);
            this.student_info_panel.Controls.Add(this.student_name_tbox);
            this.student_info_panel.Location = new System.Drawing.Point(261, 385);
            this.student_info_panel.Name = "student_info_panel";
            this.student_info_panel.Size = new System.Drawing.Size(919, 152);
            this.student_info_panel.TabIndex = 3;
            this.student_info_panel.Visible = false;
            // 
            // department_combo
            // 
            this.department_combo.FormattingEnabled = true;
            this.department_combo.Location = new System.Drawing.Point(250, 53);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(159, 21);
            this.department_combo.TabIndex = 6;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(250, 80);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 14;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // studentImagePictureBox
            // 
            this.studentImagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.studentImagePictureBox.Name = "studentImagePictureBox";
            this.studentImagePictureBox.Size = new System.Drawing.Size(113, 123);
            this.studentImagePictureBox.TabIndex = 15;
            this.studentImagePictureBox.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(694, 100);
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
            this.label7.Location = new System.Drawing.Point(122, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Student ID";
            // 
            // student_id_tbox
            // 
            this.student_id_tbox.Enabled = false;
            this.student_id_tbox.Location = new System.Drawing.Point(250, 0);
            this.student_id_tbox.Name = "student_id_tbox";
            this.student_id_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_id_tbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Student Batch";
            // 
            // student_batch_tbox
            // 
            this.student_batch_tbox.Location = new System.Drawing.Point(610, 52);
            this.student_batch_tbox.Name = "student_batch_tbox";
            this.student_batch_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_batch_tbox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Contact";
            // 
            // student_contact_tbox
            // 
            this.student_contact_tbox.Location = new System.Drawing.Point(610, 26);
            this.student_contact_tbox.Name = "student_contact_tbox";
            this.student_contact_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_contact_tbox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Email";
            // 
            // student_email_tbox
            // 
            this.student_email_tbox.Location = new System.Drawing.Point(610, 0);
            this.student_email_tbox.Name = "student_email_tbox";
            this.student_email_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_email_tbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Student Name";
            // 
            // student_name_tbox
            // 
            this.student_name_tbox.Location = new System.Drawing.Point(250, 26);
            this.student_name_tbox.Name = "student_name_tbox";
            this.student_name_tbox.Size = new System.Drawing.Size(159, 20);
            this.student_name_tbox.TabIndex = 4;
            // 
            // View_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 549);
            this.Controls.Add(this.student_info_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentDataGridView);
            this.Name = "View_Student_Info";
            this.Text = "View_Student_Info";
            this.Load += new System.EventHandler(this.View_Student_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.student_info_panel.ResumeLayout(false);
            this.student_info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox department_combo_search;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_tbox;
        private System.Windows.Forms.Panel student_info_panel;
        private System.Windows.Forms.ComboBox department_combo;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox student_name_tbox;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}