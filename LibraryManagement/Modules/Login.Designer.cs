namespace LibraryManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.username_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_icon_picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.password_tbox);
            this.panel1.Controls.Add(this.username_tbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.login_icon_picture);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 313);
            this.panel1.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(378, 225);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(115, 40);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // password_tbox
            // 
            this.password_tbox.Location = new System.Drawing.Point(378, 169);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(174, 20);
            this.password_tbox.TabIndex = 5;
            this.password_tbox.UseSystemPasswordChar = true;
            this.password_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_tbox_KeyDown);
            // 
            // username_tbox
            // 
            this.username_tbox.Location = new System.Drawing.Point(378, 131);
            this.username_tbox.Name = "username_tbox";
            this.username_tbox.Size = new System.Drawing.Size(174, 20);
            this.username_tbox.TabIndex = 4;
            this.username_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_tbox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // login_icon_picture
            // 
            this.login_icon_picture.Image = ((System.Drawing.Image)(resources.GetObject("login_icon_picture.Image")));
            this.login_icon_picture.Location = new System.Drawing.Point(44, 78);
            this.login_icon_picture.Name = "login_icon_picture";
            this.login_icon_picture.Size = new System.Drawing.Size(176, 174);
            this.login_icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_icon_picture.TabIndex = 0;
            this.login_icon_picture.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 335);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_icon_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.TextBox username_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox login_icon_picture;
    }
}

