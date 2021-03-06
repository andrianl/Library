﻿using System;
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
            // TODO: This line of code loads data into the 'appData.ReaderAccounts' table. You can move, or remove it, as needed.
            this.readerAccountsTableAdapter.Fill(this.appData.ReaderAccounts);
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

        private void headButton_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();         
        }

        SqlConnection Accounts = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harva\Documents\Library\Library\Database.mdf;Integrated Security=True;");
        private FormClosedEventHandler form2_FormClosed;
        void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from LibAccounts where Username = '" + loginTextBox.Text + "' and Password = '" + loginPassTextBox.Text + "'", Accounts);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                listPanel[++index].BringToFront();
            }
            else
            {
                SqlDataAdapter head = new SqlDataAdapter("Select Count (*) from HeadAccounts where Username = '" + loginTextBox.Text + "' and Password = '" + loginPassTextBox.Text + "'", Accounts);
                DataTable hdt = new DataTable();
                head.Fill(hdt);
                if (hdt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                    form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
                }
                else MessageBox.Show("Try again");
            }
        }

        private void RegLibButton_Click(object sender, EventArgs e)
        {
            Accounts.Open();
            SqlCommand cmd = Accounts.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into ReaderAccounts (Username, Password) VALUES ('" + regLibTextBox.Text + "', '" + passLibTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            Accounts.Close();

            MessageBox.Show("User added successfully");
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

     

        private void readerAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readerAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appData);
        }

        private void readerAccountsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.readerAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appData);
        }

        private void libAccountence1_Load(object sender, EventArgs e)
        {

        }

        private void libSearch1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
