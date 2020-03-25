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
    public partial class Add_Book : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NBOJDLR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Pooling=False");
        public Add_Book()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Book_title_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(book_title_tbox.Text == "")
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


                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO books_info values('" + book_title_tbox.Text + "','"
                    + author_tbox.Text + "','"
                    + publisher_tbox.Text + "','"
                    + purchase_date_picker.Value + "', "
                    + price_tbox.Text + ","
                    + quantity_tbox.Text + ",'"
                    + department_combo.Text + "', "
                    + quantity_tbox.Text + ")";
                cmd.ExecuteNonQuery();
                conn.Close();

                book_title_tbox.Text = "";
                author_tbox.Text = "";
                publisher_tbox.Text = "";
                price_tbox.Text = "";
                quantity_tbox.Text = "";

                MessageBox.Show("Book Added Successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Book_Load(object sender, EventArgs e)
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
