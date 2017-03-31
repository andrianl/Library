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

namespace Library
{
    public partial class Form1 : Form
    {

        List<Panel> listPanel = new List<Panel>();
        int index;

        public Form1()
        {
            InitializeComponent();
            Label startingText = new Label();
            timer1.Start();
        }

        int timeLeft = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startingText.ForeColor = System.Drawing.Color.White;

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                if (timeLeft > 120)
                {
                    startingText.Text = "Вітання";
                }
                else if (timeLeft > 50)
                {
                    startingText.Text = "Спершу потрібно налаштувати програму";
                }
                else
                {
                    startingText.Text = "Почнемо";
                }
            }
            else
            {
                timer1.Stop();
                ActiveForm.Controls.Remove(startingText);
                startingText = null;
                whoiamPanel.Visible = true;
                authPanel.Visible = true;
                LibrarianPanel.Visible = true;
            }    
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reader selected");
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wow");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(whoiamPanel);
            listPanel.Add(authPanel);
            listPanel.Add(LibrarianPanel);
            listPanel[index].BringToFront();           
        }

        private void librarianButton_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection Accounts = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harva\Documents\Library\Library\Database.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from Accounts where Username = '" + loginTextBox.Text + "' and Password = '" + loginPassTextBox.Text + "'", Accounts);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                listPanel[++index].BringToFront();
            }
            else MessageBox.Show("Not correct");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //libAccountence1.Visible = false;
            libAccountence1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //libSearch1.Visible = false;
            libSearch1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegLibPanel.BringToFront();
        }
    }
}
