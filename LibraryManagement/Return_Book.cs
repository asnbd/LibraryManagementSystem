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
    public partial class Return_Book : Form
    {
        private int mode = 0;
        SqlConnection conn = DBConn.GetInstance().GetDBConnection();

        public Return_Book(String id)
        {
            InitializeComponent();

            if (id != null)
            {
                //MessageBox.Show(id.ToString());
                mode = 1;
                student_id_tbox.Text = id;
            }
        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if (mode == 1)
            {
                student_id_tbox.Enabled = false;
                searchBooksBtn.Visible = false;
                searchBooks();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchBooksBtn_Click(object sender, EventArgs e)
        {
            searchBooks();
        }

        public void fill_grid(string id)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM issue_book where student_id = '" + id.ToString() + "' AND book_return_date=''";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    bookGridPanel.Visible = true;
                    dataGridView1.DataSource = dt;
                } else
                {
                    bookGridPanel.Visible = false;
                    MessageBox.Show("There is no book issued to this member", "Nothing Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (mode == 1)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            infoPanel.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM issue_book where id = " + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                lbl_bookName.Text = dr["book_name"].ToString();
                lbl_issueDate.Text = dr["book_issue_date"].ToString();
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE issue_book SET book_return_date = '" + dateTimePicker1.Value.ToString() + "' WHERE id = " + i + "";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "UPDATE books_info SET available_quantity = available_quantity+1 WHERE book_name = '" + lbl_bookName.Text + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Book return success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fill_grid(student_id_tbox.Text);

                infoPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Student_id_tbox_TextChanged(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
            dataGridView1.DataSource = null;
        }

        private void Student_id_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBooks();
            }
        }

        private void searchBooks()
        {
            fill_grid(student_id_tbox.Text);

            infoPanel.Visible = false;
        }
    }
}
