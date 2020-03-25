using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Add_Student_Info : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NBOJDLR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Pooling=False");
        String src_path;
        String img_file_name;

        public Add_Student_Info()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_id_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Student ID");
                    student_id_tbox.Focus();
                    return;
                }
                else if (student_name_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Student Name");
                    student_name_tbox.Focus();
                    return;
                }
                else if (department_combo.Text == "")
                {
                    MessageBox.Show("Please select Student Department");
                    department_combo.Focus();
                    return;
                }
                else if (student_email_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Student Email");
                    student_email_tbox.Focus();
                    return;
                }
                else if (student_contact_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Student Contact No.");
                    student_contact_tbox.Focus();
                    return;
                }
                else if (student_batch_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Student Batch");
                    student_batch_tbox.Focus();
                    return;
                }

                img_file_name = student_id_tbox.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                File.Copy(openImageFileDialog.FileName, src_path + "\\student_images\\" + img_file_name + ".jpg");

                String img_path = "student_images\\" + img_file_name + ".jpg";

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO student_info values('" + student_id_tbox.Text + "','"
                    + student_name_tbox.Text + "','"
                    + student_email_tbox.Text + "','"
                    + student_contact_tbox.Text + "', '"
                    + department_combo.Text + "', '"
                    + student_batch_tbox.Text + "', '"
                    + img_path + "', "
                    + "GETDATE())";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Student Added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            src_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            openImageFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.gif, *.png) | *.jpg; *.jpeg; *.gif; *.png|JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif";
            DialogResult result = openImageFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                studentImagePictureBox.ImageLocation = openImageFileDialog.FileName;
                studentImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Add_Student_Info_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT DISTINCT book_department FROM books_info";
                cmd.ExecuteNonQuery();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                department_combo.DisplayMember = "book_department";
                department_combo.ValueMember = "id";
                department_combo.DataSource = ds.Tables[0];


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
