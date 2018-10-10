using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 insertFlight = new Form2();
            // StartPosition = FormStartPosition.CenterScreen;
            insertFlight.StartPosition = FormStartPosition.CenterScreen;
            insertFlight.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 refund = new Form3();
            refund.StartPosition = FormStartPosition.CenterScreen;
            refund.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Flight flight;
            Passager passager;
            Stopwatch sw = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            using (SqlConnection conn = new SqlConnection("Server=.;Database=FlightOrderSystem;Integrated security=SSPI"))
            {
                //conn.ConnectionString = Program.connsql;
                String sql1 = "Insert into Flight values(@a,@b,@c,@d,@e,@f,@g,@h)";
                String sql2 = "Insert into passager values(@a,@b,@c,@d,@e)";
                String sql3 = "Truncate table Flight";
                String sql4 = "Truncate table passager";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(sql3, conn);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(sql4, conn);
                cmd2.ExecuteNonQuery();
                for (int i = 1; i <= Program.FlightList.GetLength(); i++)
                {
                    using (SqlCommand cmd = new SqlCommand(sql1, conn))
                    {
                        flight = Program.FlightList.GetElem(i);
                        cmd.Parameters.AddWithValue("@a", flight.FlightNum);
                        cmd.Parameters.AddWithValue("@b", flight.From);
                        cmd.Parameters.AddWithValue("@c", flight.Arrival);
                        cmd.Parameters.AddWithValue("@d", flight.GetOff);
                        cmd.Parameters.AddWithValue("@e", flight.ArrivalTime);
                        cmd.Parameters.AddWithValue("@f", flight.Prices);
                        cmd.Parameters.AddWithValue("@g", flight.Discount);
                        cmd.Parameters.AddWithValue("@h", flight.left);
                        sw.Start();
                        cmd.ExecuteNonQuery();
                    }
                }
                for(int i = 1; i <= Program.passList.GetLength(); i++)
                {
                    using (SqlCommand cmd = new SqlCommand(sql2, conn))
                    {
                        passager = Program.passList.GetElem(i);
                        cmd.Parameters.AddWithValue("@a", passager.Name);
                        cmd.Parameters.AddWithValue("@b", passager.IdNum);
                        cmd.Parameters.AddWithValue("@c", passager.FlightNum);
                        cmd.Parameters.AddWithValue("@d", passager.OrderId);
                        cmd.Parameters.AddWithValue("@e", passager.Ticketnum);
                        sw2.Start();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 query = new Form4();
            query.StartPosition = FormStartPosition.CenterScreen;
            query.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.StartPosition = FormStartPosition.CenterScreen;
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.StartPosition = FormStartPosition.CenterScreen;
            form6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.flightnum = new List<string>();
            int i = 1;
            while (i <= Program.FlightList.GetLength())
            {
                Flight flight = Program.FlightList.GetElem(i);
                Program.flightnum.Add(flight.FlightNum);
                i++;
            }

            Form7 form7 = new Form7();
            form7.StartPosition = FormStartPosition.CenterScreen;
            form7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=FlightOrderSystem;Integrated security=SSPI");
            conn.Open();
            String sql1 = "select * from Flight";
            String sql2 = "select * from passager";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            Program.flightDic = new Dictionary<String, int>();
            Program.passDic = new Dictionary<string, int>();
            while (sdr.Read())
            {
                Flight flight = new Flight((String)sdr["FlightNum"], (String)sdr["FromCity"], (String)sdr["ArrivalCity"], (String)sdr["Getofftime"], (String)sdr["Arrivaltime"], (Int32)sdr["Price"], (Double)sdr["Discount"], (Int32)sdr["LeftT"]);
                Program.FlightList.Append(flight);
                Program.flightDic.Add(flight.FlightNum, Program.flightindex);
                Program.flightindex++;
            }
            sdr.Close();
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read()) {
                Passager passager = new Passager((String)sdr2["Name"], (String)sdr2["ID"], (String)sdr2["FlightNum"], (Int32)sdr2["ordernum"], (Int32)sdr2["ticketnum"]);
                Program.passList.Append(passager);
                Program.passDic.Add(passager.IdNum, Program.passindex);
                Program.passindex++;
            }
            sdr2.Close();
            conn.Close();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = false;
        }
    }
}
