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

namespace LibraryManagement
{
    public partial class Issue_Book : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NBOJDLR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Pooling=False");

        int mode = 0;

        public Issue_Book(String id)
        {
            InitializeComponent();

            if(id != null)
            {
                //MessageBox.Show(id.ToString());
                mode = 1;
                search_student_tbox.Text = id;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchStudent(search_student_tbox.Text);
        }

        private void Issue_Book_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            conn.Open();

            if(mode == 1)
            {
                search_student_tbox.Enabled = false;
                searchBtn.Visible = false;
                SearchStudent(search_student_tbox.Text);
            }
        }

        private void SearchStudent(String sid)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM student_info WHERE id = '" + sid + "'";

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student ID not found", "Issue Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    student_info_panel.Visible = false;
                }
                else
                {
                    student_info_panel.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        student_name_tbox.Text = dr["student_name"].ToString();
                        student_department_tbox.Text = dr["student_department"].ToString();
                        student_batch_tbox.Text = dr["student_batch"].ToString();
                        student_email_tbox.Text = dr["student_email"].ToString();
                        student_contact_tbox.Text = dr["student_contact"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_student_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchStudent(search_student_tbox.Text);
            } else
            {
                student_info_panel.Visible = false;
            }
        }

        private void Book_name_tbox_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            listBox_books.Items.Clear();

            if(e.KeyCode != Keys.Enter)
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM books_info WHERE book_name like('%" + book_name_tbox.Text + "%')";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    count = dt.Rows.Count;

                    if (count > 0)
                    {
                        listBox_books.Visible = true;
                        foreach (DataRow dr in dt.Rows)
                        {
                            listBox_books.Items.Add(dr["book_name"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Book_name_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox_books.Focus();
                listBox_books.SelectedIndex = 0;
            }
        }

        private void ListBox_books_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                book_name_tbox.Text = listBox_books.SelectedItem.ToString();
                listBox_books.Visible = false;
            }
        }

        private void ListBox_books_MouseClick(object sender, MouseEventArgs e)
        {
            book_name_tbox.Text = listBox_books.SelectedItem.ToString();
            listBox_books.Visible = false;
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int book_qty = 0;
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT * FROM books_info WHERE book_name = '" + book_name_tbox.Text + "'";

                cmd2.ExecuteNonQuery();

                DataTable dt2 = new DataTable();
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                sda2.Fill(dt2);

                foreach (DataRow dr2 in dt2.Rows)
                {
                    book_qty = Convert.ToInt32(dr2["available_quantity"].ToString());
                }

                if (book_qty > 0)
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO issue_book values('" + search_student_tbox.Text + "', '" + book_name_tbox.Text + "', '" + dateTimePicker_issue.Value.ToString() + "', '')";

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        SqlCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "UPDATE books_info SET available_quantity = available_quantity - 1 WHERE book_name = '" + book_name_tbox.Text + "'";

                        if (cmd1.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Book Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Available Quantity Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Book Not Available!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
