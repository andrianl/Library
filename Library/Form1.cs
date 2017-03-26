using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        int timeLeft = 150;

        public object WhoIAm { get; private set; }

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
            }    
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wow");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(whoiamPanel);
            listPanel.Add(authPanel);
            listPanel[index].BringToFront();
        }
    }
}
