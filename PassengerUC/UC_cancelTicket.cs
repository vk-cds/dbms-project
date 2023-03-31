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

using static SV2AIR.DataSet1;

namespace SV2AIR.PassengerUC
{
    public partial class UC_cancelTicket : UserControl
    {
        public UC_cancelTicket()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();

            //display flightid and userid
            String tid = tidlabel.Text;
            String query = "select * from ticket where ticket_id =" + tid + "";
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd.ExecuteReader();

            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    String fid= reader1["flight_id"].ToString();
                    fnolabel.Text = fid;

                    String userid = reader1["user_id"].ToString();
                    useridlabel.Text = userid;
                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }

            // display passnger name
            String uid = useridlabel.Text;
            String query2 = "select * from passenger where user_id =" + uid + "";
            OracleCommand cmd2 = new OracleCommand(query2, con);
            OracleDataReader rea;
            rea = cmd2.ExecuteReader();
            if (rea.HasRows)
            {
                while (rea .Read())
                {
                    String pname = rea["first_name"].ToString();
                    pnamelabel.Text = pname;
                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }



            //display dept time....
            String fno = fnolabel.Text;
            String query3 = "select * from flights where flight_id =" + fno + "";
            OracleCommand cmd3 = new OracleCommand(query3, con);
            OracleDataReader read1;
            read1 = cmd3.ExecuteReader();
            if (read1.HasRows)
            {
                while (read1.Read())
                {
                    String deptfrom = read1["dept_from"].ToString();
                    departfromlabel.Text = deptfrom;

                    String arriveat = read1["arrive_at"].ToString();
                    arriveatlabel.Text = arriveat;
                }

            }
            else
            {
                MessageBox.Show("No Data In DataBase");
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        { //delete ticket record
            String tid = tidlabel.Text;
            OracleConnection con = new OracleConnection("User Id = SV2RESERVATION ; Password = sv2air ; Data Source=XE");
            con.Open();
            String query = "DELETE from ticket where ticket_id=" + tid + " ";
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader1;
            reader1 = cmd.ExecuteReader();


            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Success!");
            }
            else
            {

                MessageBox.Show("Record not deleted");
            }


            //delete passenger record
            String uid = useridlabel.Text;
            String query2 = "DELETE from passenger where user_id=" + uid + " ";
            OracleCommand cmd1 = new OracleCommand(query2, con);
            OracleDataReader read1;
            read1 = cmd1.ExecuteReader();


            int rowsUpdate = cmd1.ExecuteNonQuery();
            if (rowsUpdate == 0)
            {
                MessageBox.Show("Success!");
            }
            else
            {

                MessageBox.Show("Record not deleted");
            }



            con.Dispose();
        }

        private void UC_cancelTicket_Load(object sender, EventArgs e)
        {
            panel1.Visible= false;
        }
    }
}
