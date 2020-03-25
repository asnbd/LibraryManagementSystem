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
    public partial class View_Books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NBOJDLR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Pooling=False");

        public View_Books()
        {
            InitializeComponent();
        }

        private void View_Books_Load(object sender, EventArgs e)
        {
            DisplayBooks();
            InitDepartmentCombo();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            edit_book_panel.Visible = false;
            SearchBook();
        }

        private void Search_tbox_KeyUp(object sender, KeyEventArgs e)
        {
            edit_book_panel.Visible = false;
            SearchBook();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                if (book_title_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Book Title");
                    book_title_tbox.Focus();
                    return;
                }
                else if (author_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Book Author");
                    author_tbox.Focus();
                    return;
                }
                else if (publisher_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Book Publisher");
                    publisher_tbox.Focus();
                    return;
                }
                else if (department_combo.Text == "")
                {
                    MessageBox.Show("Please enter Department");
                    department_combo.Focus();
                    return;
                }
                else if (purchase_date_picker.Value.ToString() == "")
                {
                    MessageBox.Show("Please enter Book Purchase Date");
                    purchase_date_picker.Focus();
                    return;
                }
                else if (price_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Book Price");
                    price_tbox.Focus();
                    return;
                }
                else if (quantity_tbox.Text == "")
                {
                    MessageBox.Show("Please enter Book Quantity");
                    quantity_tbox.Focus();
                    return;
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE books_info SET book_name = '" + book_title_tbox.Text +
                    "', book_author = '" + author_tbox.Text +
                    "',book_publisher = '" + publisher_tbox.Text +
                    "',book_purchase_date = '" + purchase_date_picker.Value +
                    "',book_department = '" + department_combo.Text +
                    "',book_price = " + price_tbox.Text +
                    ", book_quantity = " + quantity_tbox.Text + " WHERE id = " + i + "";

                if (cmd.ExecuteNonQuery() > 0)
                {
                    DisplayBooks();
                    MessageBox.Show("Update Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nothing Updated!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
                edit_book_panel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_book_panel.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE id = " + i + "";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    book_title_tbox.Text = dr["book_name"].ToString();
                    author_tbox.Text = dr["book_author"].ToString();
                    publisher_tbox.Text = dr["book_publisher"].ToString();
                    purchase_date_picker.Value = Convert.ToDateTime(dr["book_purchase_date"].ToString());
                    price_tbox.Text = dr["book_price"].ToString();
                    quantity_tbox.Text = dr["book_quantity"].ToString();
                    department_combo.SelectedIndex = department_combo.FindStringExact(dr["book_department"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayBooks()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBook()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if(department_combo_search.Text == "All")
                {
                    cmd.CommandText = "SELECT * FROM books_info WHERE book_name like('%" + search_tbox.Text + "%') OR book_author like('%" + search_tbox.Text + "%') OR book_publisher like('%" + search_tbox.Text + "%')";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM books_info WHERE (book_name like('%" + search_tbox.Text + "%') OR book_author like('%" + search_tbox.Text + "%') OR book_publisher like('%" + search_tbox.Text + "%')) AND book_department = '" + department_combo_search.Text + "'";
                }
                
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitDepartmentCombo()
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

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Department_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void Department_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
