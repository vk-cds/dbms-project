using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace SV2AIR
{
    public partial class customereg : Form
    {
        public customereg()
        {
            InitializeComponent();
        }
       
        public string Value2 { get; set; }
        private void customereg_Load(object sender, EventArgs e)
        {
            string a;
            int ab;

            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");

            con.Open();
            String query1 = "select max(user_id) as user_id from passenger";
            // MessageBox.Show(query1);
            OracleCommand cmd = new OracleCommand(query1, con);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            a = dr["user_id"].ToString();
            ab = int.Parse(a);
            ab++;

            con.Dispose();

            useridlabel.Text = ab.ToString();
        }

       

        private void registerbutton_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");

            con.Open();
            String pass = txtpass.Text;
            String fname = txtfirstname.Text;
            String lname = txtlastname.Text;
            Int64 no = Int64.Parse(txtphoneno.Text);
            String city = txtcity.Text;
            String street = txtstreet.Text;
            String state = txtstate.Text;
            String country = txtcountry.Text;
            Int64 userid = Int64.Parse(useridlabel.Text);

         //   MessageBox.Show("Connectedtodatasource");
            String query = "insert into passenger(user_id,password,first_name,last_name,phone_no,street,city,state,country) values(" + userid + ",'" + pass + " ', '" + fname + "' , '" + lname + "' ," + no + " ,'" + street + "' ,'" + city + " ' ,'" + state + " ' ,'" + country + " ')";
           // MessageBox.Show(query);
            OracleCommand cmd1 = new OracleCommand(query, con);

            int rowsUpdated = cmd1.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Record not inserted");
            }
            else
            {
                MessageBox.Show("Success!");
            }

            con.Dispose();

            String uid = useridlabel.Text;
           //i Value2 = uid;

          //  MessageBox.Show(Value2);

            ticketdetails t = new ticketdetails();
            t.Show();
            t.Value2 = uid;
            t.Value1 = Value2;
            this.Hide();
        }
    }
}
