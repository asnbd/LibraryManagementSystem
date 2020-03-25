using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManagement
{
    public partial class View_Student_Info : Form
    {
        SqlConnection conn = DBConn.GetInstance().GetDBConnection();
        String src_path;
        String img_file_name;
        DialogResult result;

        public View_Student_Info()
        {
            InitializeComponent();
        }

        private void View_Student_Info_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            InitDepartmentCombo();
            InitStudentDataGridView();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void InitDepartmentCombo()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT DISTINCT book_department FROM books_info";
                cmd.ExecuteNonQuery();

                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Fill(ds2);

                ds.Tables[0].Rows.Add("All");

                department_combo_search.DisplayMember = "book_department";
                department_combo_search.ValueMember = "id";
                department_combo_search.DataSource = ds.Tables[0];

                department_combo.DisplayMember = "book_department";
                department_combo.ValueMember = "id";
                department_combo.DataSource = ds2.Tables[0];

                department_combo_search.SelectedIndex = department_combo_search.FindStringExact("All");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitStudentDataGridView()
        {
            try
            {
                studentDataGridView.Columns.Clear();
                studentDataGridView.Refresh();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM student_info";

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                studentDataGridView.DataSource = dt;

                studentDataGridView.Columns.RemoveAt(6);

                studentDataGridView.Columns[0].HeaderText = "Student ID";
                studentDataGridView.Columns[1].HeaderText = "Name";
                studentDataGridView.Columns[2].HeaderText = "Email";
                studentDataGridView.Columns[3].HeaderText = "Contact";
                studentDataGridView.Columns[4].HeaderText = "Department";
                studentDataGridView.Columns[5].HeaderText = "Batch";
                studentDataGridView.Columns[6].HeaderText = "Registration Date";


                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

                imageCol.HeaderText = "Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                studentDataGridView.Columns.Add(imageCol);

                int i = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    studentDataGridView.Rows[i].Cells[7].Value = img;
                    studentDataGridView.Rows[i].Height = 100;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchStudent()
        {
            try
            {
                student_info_panel.Visible = false;

                studentDataGridView.Columns.Clear();
                studentDataGridView.Refresh();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (department_combo_search.Text == "All")
                {
                    cmd.CommandText = "SELECT * FROM student_info WHERE id like('%" + search_tbox.Text + "%') OR student_name like('%" + search_tbox.Text + "%')";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM student_info WHERE (id like('%" + search_tbox.Text + "%') OR student_name like('%" + search_tbox.Text + "%')) AND student_department = '" + department_combo_search.Text + "'";
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                studentDataGridView.DataSource = dt;

                studentDataGridView.Columns.RemoveAt(6);

                studentDataGridView.Columns[0].HeaderText = "Student ID";
                studentDataGridView.Columns[1].HeaderText = "Name";
                studentDataGridView.Columns[2].HeaderText = "Email";
                studentDataGridView.Columns[3].HeaderText = "Contact";
                studentDataGridView.Columns[4].HeaderText = "Department";
                studentDataGridView.Columns[5].HeaderText = "Batch";
                studentDataGridView.Columns[6].HeaderText = "Registration Date";


                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

                imageCol.HeaderText = "Image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                studentDataGridView.Columns.Add(imageCol);

                int i = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    studentDataGridView.Rows[i].Cells[7].Value = img;
                    studentDataGridView.Rows[i].Height = 100;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_tbox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchStudent();
        }

        private void Department_combo_search_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void StudentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(studentDataGridView.SelectedCells[0].Value.ToString());

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM student_info WHERE id = " + i + "";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    student_id_tbox.Text = dr["id"].ToString();
                    student_name_tbox.Text = dr["student_name"].ToString();
                    student_email_tbox.Text = dr["student_email"].ToString();
                    student_contact_tbox.Text = dr["student_contact"].ToString();
                    student_batch_tbox.Text = dr["student_batch"].ToString();
                    department_combo.SelectedIndex = department_combo.FindStringExact(dr["student_department"].ToString());
                }

                student_info_panel.Visible = true;
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
            result = openImageFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                studentImagePictureBox.ImageLocation = openImageFileDialog.FileName;
                studentImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void StudentDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            
        }


        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Edit");
        }

        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    String id;
                    id = studentDataGridView.SelectedCells[0].Value.ToString();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM student_info WHERE id = '" + id + "'";

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        SearchStudent();
                        MessageBox.Show("Delete Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nothing Deleted!", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Issue");
            String id = studentDataGridView.SelectedCells[0].Value.ToString();
            Issue_Book issue_Book = new Issue_Book(id);
            issue_Book.Show();
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Return");
            String id = studentDataGridView.SelectedCells[0].Value.ToString();
            Return_Book return_Book = new Return_Book(id);
            return_Book.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            String img_path = null;
            if (result == DialogResult.OK)
            {
                img_file_name = student_id_tbox.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                File.Copy(openImageFileDialog.FileName, src_path + "\\student_images\\" + img_file_name + ".jpg");
                img_path = "student_images\\" + img_file_name + ".jpg";
            }

            int i;
            i = Convert.ToInt32(studentDataGridView.SelectedCells[0].Value.ToString());

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if(img_path == null)
                {
                    cmd.CommandText = "UPDATE student_info SET student_name = '" + student_name_tbox.Text
                        + "', student_email = '" + student_email_tbox.Text
                        + "', student_contact = '" + student_contact_tbox.Text
                        + "', student_department = '" + department_combo.Text
                        + "', student_batch = '" + student_batch_tbox.Text
                        + "' WHERE id = " + i + "";
                } else
                {
                    cmd.CommandText = "UPDATE student_info SET student_name = '" + student_name_tbox.Text
                        + "', student_email = '" + student_email_tbox.Text
                        + "', student_contact = '" + student_contact_tbox.Text
                        + "', student_department = '" + department_combo.Text
                        + "', student_batch = '" + student_batch_tbox.Text
                        + "', student_image = '" + img_path
                        + "' WHERE id = " + i + "";
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully Updated 1 Student", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitStudentDataGridView();
                }
                else
                {
                    MessageBox.Show("Nothing updated.", "Nothing Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void StudentDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                studentDataGridView.CurrentCell = studentDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                studentDataGridView.Rows[e.RowIndex].Selected = true;
                studentDataGridView.Focus();
            }
        }
    }
}
