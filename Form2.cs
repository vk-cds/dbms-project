using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace SV2AIR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
           // panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
          //  menuStrip1.Visible = false;
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            try
            {
                con.Open();

                //MessageBox.Show("Connectedtodatasource");
                String query = "select * from admin where username='" + textuser.Text + "'and password ='" + textpass.Text + "'";

               //MessageBox.Show(query);
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {  //output.Text = (string)reader1["admin_id"];

                    labelerror.Visible = false;

                    Form2_1 f21 = new Form2_1();
                    f21.Show();
                    this.Hide();
                    
                    // dashboard ds = new dashboard();
                    //this.Hide();
                    //ds.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                    labelerror.Visible = true;
                    textpass.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failedtoconnecttodatasource");

            }
        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }




        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
