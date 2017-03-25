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

        public Form1()
        {
            InitializeComponent();
            Label startingText = new Label();
            timer1.Start();

            Label WhoIAm = new Label();
            WhoIAm.AutoSize = true;
            WhoIAm.Width = 140;
            WhoIAm.Text = "Хто я?";
            WhoIAm.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            WhoIAm.Font = new System.Drawing.Font("Calibri Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            WhoIAm.Left = (this.ClientSize.Width - WhoIAm.Width) / 2;
            WhoIAm.Top = (this.ClientSize.Height - WhoIAm.Height) / 2 - 90;
            this.Controls.Add(WhoIAm);
        }

        int timeLeft = 150;
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
            }    
   
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void decButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wow");
        }
    }
}
