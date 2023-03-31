using SV2AIR.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SV2AIR
{
    public partial class Form2_1 : Form
    {
        public Form2_1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            uC_addflights1.Visible = true;
            uC_addflights1.BringToFront();
        }

        private void Form2_1_Load(object sender, EventArgs e)
        {
            uC_addflights1.Visible = false;
            uC_modifyflights1.Visible = false;
            //uC_viewpassenger1.Visible = false;
            uC_viewflights1.Visible = false;
            uC_deleteflight1.Visible = false;
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            uC_modifyflights1.Visible = true;
            uC_modifyflights1.BringToFront();
        }

       

      
        private void uC_viewflights1_Load(object sender, EventArgs e)
        {
           
        }

        private void flightviewbutton_Click(object sender, EventArgs e)
        {
            uC_viewflights1.Visible = true;
            uC_viewflights1.BringToFront();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_deleteflight1.Visible = true;
            uC_deleteflight1.BringToFront();
        }

        private void uC_deleteflight1_Load(object sender, EventArgs e)
        {

        }
    }
}
