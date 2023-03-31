using SV2AIR.PassengerUC;
using System;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace SV2AIR
{
    public partial class form2_2 : Form
    {
        public form2_2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

       

        private void bookbutton_Click(object sender, EventArgs e)
        {
            uC_booktickets1.Visible = true;
            uC_booktickets1.BringToFront();

        }

       
        

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            
            uC_cancelTicket1.Visible = true;
            uC_cancelTicket1.BringToFront();
        }

        private void form2_2_Load(object sender, EventArgs e)
        {
            //cancelbutton.Visible = false;
            uC_cancelTicket1.Visible = false;
            uC_booktickets1.Visible = false;
            //uC_printtick1.Visible = false;
        }

      
    }
}
