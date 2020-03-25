namespace LibraryManagement
{
    partial class Add_Book
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
            this.book_title_tbox = new System.Windows.Forms.TextBox();
            this.author_tbox = new System.Windows.Forms.TextBox();
            this.publisher_tbox = new System.Windows.Forms.TextBox();
            this.price_tbox = new System.Windows.Forms.TextBox();
            this.quantity_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.purchase_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.department_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // book_title_tbox
            // 
            this.book_title_tbox.Location = new System.Drawing.Point(122, 54);
            this.book_title_tbox.Name = "book_title_tbox";
            this.book_title_tbox.Size = new System.Drawing.Size(253, 20);
            this.book_title_tbox.TabIndex = 0;
            this.book_title_tbox.TextChanged += new System.EventHandler(this.Book_title_tbox_TextChanged);
            // 
            // author_tbox
            // 
            this.author_tbox.Location = new System.Drawing.Point(122, 80);
            this.author_tbox.Name = "author_tbox";
            this.author_tbox.Size = new System.Drawing.Size(253, 20);
            this.author_tbox.TabIndex = 1;
            // 
            // publisher_tbox
            // 
            this.publisher_tbox.Location = new System.Drawing.Point(122, 106);
            this.publisher_tbox.Name = "publisher_tbox";
            this.publisher_tbox.Size = new System.Drawing.Size(253, 20);
            this.publisher_tbox.TabIndex = 2;
            // 
            // price_tbox
            // 
            this.price_tbox.Location = new System.Drawing.Point(122, 184);
            this.price_tbox.Name = "price_tbox";
            this.price_tbox.Size = new System.Drawing.Size(100, 20);
            this.price_tbox.TabIndex = 4;
            // 
            // quantity_tbox
            // 
            this.quantity_tbox.Location = new System.Drawing.Point(122, 210);
            this.quantity_tbox.Name = "quantity_tbox";
            this.quantity_tbox.Size = new System.Drawing.Size(100, 20);
            this.quantity_tbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Title";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantity";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(300, 252);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add New Book";
            // 
            // purchase_date_picker
            // 
            this.purchase_date_picker.Location = new System.Drawing.Point(122, 158);
            this.purchase_date_picker.Name = "purchase_date_picker";
            this.purchase_date_picker.Size = new System.Drawing.Size(200, 20);
            this.purchase_date_picker.TabIndex = 14;
            this.purchase_date_picker.Value = new System.DateTime(2019, 8, 27, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Department";
            // 
            // department_combo
            // 
            this.department_combo.FormattingEnabled = true;
            this.department_combo.Location = new System.Drawing.Point(122, 132);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(253, 21);
            this.department_combo.TabIndex = 17;
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 291);
            this.Controls.Add(this.department_combo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.purchase_date_picker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity_tbox);
            this.Controls.Add(this.price_tbox);
            this.Controls.Add(this.publisher_tbox);
            this.Controls.Add(this.author_tbox);
            this.Controls.Add(this.book_title_tbox);
            this.Name = "Add_Book";
            this.Text = "Add_Book";
            this.Load += new System.EventHandler(this.Add_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox book_title_tbox;
        private System.Windows.Forms.TextBox author_tbox;
        private System.Windows.Forms.TextBox publisher_tbox;
        private System.Windows.Forms.TextBox price_tbox;
        private System.Windows.Forms.TextBox quantity_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker purchase_date_picker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox department_combo;
    }
}