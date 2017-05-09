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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }      

        private void AccHeadBookButton_Click(object sender, EventArgs e)
        {

        }

        private void AccHeadButton_Click(object sender, EventArgs e)
        {

        }

        
        private void SearchHeadButton_Click(object sender, EventArgs e)
        {
            HeadSearch.BringToFront();
        }

        private void NewHeadButton_Click(object sender, EventArgs e)
        {
            RegHeadPanel.BringToFront();
        }

        
    }
}
