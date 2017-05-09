using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class LibSearch : UserControl
    {
        public LibSearch()
        {
            InitializeComponent();
        }

        SqlConnection Books = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harva\Documents\Library\Library\Database.mdf;Integrated Security=True;");

        //updating Book database 
        private void UpdateBookL_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Books", Books);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //searching some cool books
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //some code
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Books WHERE Author LIKE '" + textBox1.Text + "%'", Books);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
