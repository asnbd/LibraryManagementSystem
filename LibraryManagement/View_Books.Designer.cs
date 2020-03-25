namespace LibraryManagement
{
    partial class View_Books
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.department_combo_search = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_tbox = new System.Windows.Forms.TextBox();
            this.edit_book_panel = new System.Windows.Forms.Panel();
            this.department_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.purchase_date_picker = new System.Windows.Forms.DateTimePicker();
            this.quantity_tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.price_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.publisher_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.author_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.book_title_tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.edit_book_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
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
            this.panel1.TabIndex = 1;
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
            this.department_combo_search.SelectedIndexChanged += new System.EventHandler(this.Department_combo_SelectedIndexChanged);
            this.department_combo_search.SelectedValueChanged += new System.EventHandler(this.Department_combo_SelectedValueChanged);
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
            // edit_book_panel
            // 
            this.edit_book_panel.AutoSize = true;
            this.edit_book_panel.Controls.Add(this.department_combo);
            this.edit_book_panel.Controls.Add(this.label8);
            this.edit_book_panel.Controls.Add(this.updateBtn);
            this.edit_book_panel.Controls.Add(this.purchase_date_picker);
            this.edit_book_panel.Controls.Add(this.quantity_tbox);
            this.edit_book_panel.Controls.Add(this.label7);
            this.edit_book_panel.Controls.Add(this.label6);
            this.edit_book_panel.Controls.Add(this.price_tbox);
            this.edit_book_panel.Controls.Add(this.label5);
            this.edit_book_panel.Controls.Add(this.publisher_tbox);
            this.edit_book_panel.Controls.Add(this.label4);
            this.edit_book_panel.Controls.Add(this.author_tbox);
            this.edit_book_panel.Controls.Add(this.label3);
            this.edit_book_panel.Controls.Add(this.book_title_tbox);
            this.edit_book_panel.Controls.Add(this.label2);
            this.edit_book_panel.Location = new System.Drawing.Point(261, 358);
            this.edit_book_panel.Name = "edit_book_panel";
            this.edit_book_panel.Size = new System.Drawing.Size(834, 234);
            this.edit_book_panel.TabIndex = 2;
            this.edit_book_panel.Visible = false;
            // 
            // department_combo
            // 
            this.department_combo.FormattingEnabled = true;
            this.department_combo.Location = new System.Drawing.Point(119, 151);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(189, 21);
            this.department_combo.TabIndex = 5;
            this.department_combo.Text = "All";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Department";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(639, 156);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // purchase_date_picker
            // 
            this.purchase_date_picker.Location = new System.Drawing.Point(525, 28);
            this.purchase_date_picker.Name = "purchase_date_picker";
            this.purchase_date_picker.Size = new System.Drawing.Size(189, 20);
            this.purchase_date_picker.TabIndex = 13;
            // 
            // quantity_tbox
            // 
            this.quantity_tbox.Location = new System.Drawing.Point(525, 112);
            this.quantity_tbox.Name = "quantity_tbox";
            this.quantity_tbox.Size = new System.Drawing.Size(189, 20);
            this.quantity_tbox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price";
            // 
            // price_tbox
            // 
            this.price_tbox.Location = new System.Drawing.Point(525, 70);
            this.price_tbox.Name = "price_tbox";
            this.price_tbox.Size = new System.Drawing.Size(189, 20);
            this.price_tbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Purchase Date";
            // 
            // publisher_tbox
            // 
            this.publisher_tbox.Location = new System.Drawing.Point(119, 112);
            this.publisher_tbox.Name = "publisher_tbox";
            this.publisher_tbox.Size = new System.Drawing.Size(189, 20);
            this.publisher_tbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Publisher";
            // 
            // author_tbox
            // 
            this.author_tbox.Location = new System.Drawing.Point(119, 70);
            this.author_tbox.Name = "author_tbox";
            this.author_tbox.Size = new System.Drawing.Size(189, 20);
            this.author_tbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            // 
            // book_title_tbox
            // 
            this.book_title_tbox.Location = new System.Drawing.Point(119, 28);
            this.book_title_tbox.Name = "book_title_tbox";
            this.book_title_tbox.Size = new System.Drawing.Size(189, 20);
            this.book_title_tbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title";
            // 
            // View_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 604);
            this.Controls.Add(this.edit_book_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Books";
            this.Text = "View_Books";
            this.Load += new System.EventHandler(this.View_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.edit_book_panel.ResumeLayout(false);
            this.edit_book_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox search_tbox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel edit_book_panel;
        private System.Windows.Forms.TextBox quantity_tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox publisher_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox author_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox book_title_tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker purchase_date_picker;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox department_combo_search;
        private System.Windows.Forms.ComboBox department_combo;
    }
}