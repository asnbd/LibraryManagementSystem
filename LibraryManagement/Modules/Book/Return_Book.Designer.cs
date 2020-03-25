namespace LibraryManagement
{
    partial class Return_Book
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
            this.searchBooksBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.student_id_tbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_bookName = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_issueDate = new System.Windows.Forms.Label();
            this.bookGridPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.bookGridPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchBooksBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.student_id_tbox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 77);
            this.panel1.TabIndex = 0;
            // 
            // searchBooksBtn
            // 
            this.searchBooksBtn.Location = new System.Drawing.Point(3, 47);
            this.searchBooksBtn.Name = "searchBooksBtn";
            this.searchBooksBtn.Size = new System.Drawing.Size(205, 23);
            this.searchBooksBtn.TabIndex = 2;
            this.searchBooksBtn.Text = "Search Books";
            this.searchBooksBtn.UseVisualStyleBackColor = true;
            this.searchBooksBtn.Click += new System.EventHandler(this.SearchBooksBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // student_id_tbox
            // 
            this.student_id_tbox.Location = new System.Drawing.Point(3, 21);
            this.student_id_tbox.Name = "student_id_tbox";
            this.student_id_tbox.Size = new System.Drawing.Size(205, 20);
            this.student_id_tbox.TabIndex = 0;
            this.student_id_tbox.TextChanged += new System.EventHandler(this.Student_id_tbox_TextChanged);
            this.student_id_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Student_id_tbox_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(686, 326);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bookName.Location = new System.Drawing.Point(87, 14);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(0, 13);
            this.lbl_bookName.TabIndex = 2;
            this.lbl_bookName.Click += new System.EventHandler(this.Label2_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.returnBtn);
            this.infoPanel.Controls.Add(this.dateTimePicker1);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.lbl_issueDate);
            this.infoPanel.Controls.Add(this.lbl_bookName);
            this.infoPanel.Location = new System.Drawing.Point(3, 335);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(686, 153);
            this.infoPanel.TabIndex = 3;
            this.infoPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Issue Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book Name:";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(102, 96);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(200, 23);
            this.returnBtn.TabIndex = 7;
            this.returnBtn.Text = "Return Book";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Return Date:";
            // 
            // lbl_issueDate
            // 
            this.lbl_issueDate.AutoSize = true;
            this.lbl_issueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_issueDate.Location = new System.Drawing.Point(87, 39);
            this.lbl_issueDate.Name = "lbl_issueDate";
            this.lbl_issueDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_issueDate.TabIndex = 3;
            // 
            // bookGridPanel
            // 
            this.bookGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookGridPanel.Controls.Add(this.dataGridView1);
            this.bookGridPanel.Location = new System.Drawing.Point(3, 3);
            this.bookGridPanel.Name = "bookGridPanel";
            this.bookGridPanel.Size = new System.Drawing.Size(686, 326);
            this.bookGridPanel.TabIndex = 4;
            this.bookGridPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.infoPanel);
            this.panel2.Controls.Add(this.bookGridPanel);
            this.panel2.Location = new System.Drawing.Point(231, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 493);
            this.panel2.TabIndex = 5;
            // 
            // Return_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Return_Book";
            this.Text = "Return_Book";
            this.Load += new System.EventHandler(this.Return_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.bookGridPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBooksBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox student_id_tbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_issueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bookGridPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
    }
}