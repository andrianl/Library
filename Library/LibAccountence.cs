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
    public partial class LibAccountence : UserControl
    {
        public LibAccountence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Readers = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harva\Documents\Library\Library\Database.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT Id, Username, Password FROM ReaderAccounts", Readers);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
