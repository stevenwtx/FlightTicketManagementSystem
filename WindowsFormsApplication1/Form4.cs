using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public static string tempnum;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataColumn dc = null;
            // dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("起点", Type.GetType("System.String"));
            dc = dt.Columns.Add("终点", Type.GetType("System.String"));
            dc = dt.Columns.Add("起飞时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("到达时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("票价", Type.GetType("System.Double"));
            dc = dt.Columns.Add("折扣", Type.GetType("System.Double"));
            dc = dt.Columns.Add("余票", Type.GetType("System.Int32"));
            dataGridView1.DataSource = dt.DefaultView;
            Flight flight = Program.FlightList.GetElem(Program.flightDic[textBox1.Text]);
            DataRow row;
            dt.Rows.Clear();
            row = dt.NewRow();
            row[0] = flight.FlightNum;
            row[1] = flight.From;
            row[2] = flight.Arrival;
            row[3] = flight.GetOff;
            row[4] = flight.ArrivalTime;
            row[5] = flight.Prices;
            row[6] = flight.Discount;
            row[7] = flight.left;
            dt.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc = null;
            // dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("起点", Type.GetType("System.String"));
            dc = dt.Columns.Add("终点", Type.GetType("System.String"));
            dc = dt.Columns.Add("起飞时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("到达时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("票价", Type.GetType("System.Double"));
            dc = dt.Columns.Add("折扣", Type.GetType("System.Double"));
            dc = dt.Columns.Add("余票", Type.GetType("System.Int32"));
            dataGridView1.DataSource = dt.DefaultView;
            // Flight flight = Program.FlightList.GetElem(Program.flightDic[textBox1.Text]);
            DataRow row;
            dt.Rows.Clear();
            int i = 1;
            while (i <= Program.FlightList.GetLength())
            {
                Flight flight = Program.FlightList.GetElem(i);
                i++;
                if (flight.From.Equals(textBox2.Text) && flight.Arrival.Equals(textBox3.Text))
                {
                    row = dt.NewRow();
                    row[0] = flight.FlightNum;
                    row[1] = flight.From;
                    row[2] = flight.Arrival;
                    row[3] = flight.GetOff;
                    row[4] = flight.ArrivalTime;
                    row[5] = flight.Prices;
                    row[6] = flight.Discount;
                    row[7] = flight.left;
                    dt.Rows.Add(row);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc = null;
            // dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("起点", Type.GetType("System.String"));
            dc = dt.Columns.Add("终点", Type.GetType("System.String"));
            dc = dt.Columns.Add("起飞时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("到达时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("票价", Type.GetType("System.Double"));
            dc = dt.Columns.Add("折扣", Type.GetType("System.Double"));
            dc = dt.Columns.Add("余票", Type.GetType("System.Int32"));
            dataGridView1.DataSource = dt.DefaultView;
           // Flight flight = Program.FlightList.GetElem(Program.flightDic[textBox1.Text]);
            DataRow row;
            dt.Rows.Clear();
            int i = 1;
            while (i <= Program.FlightList.GetLength())
            {
                Flight flight = Program.FlightList.GetElem(i);
                i++;
                row = dt.NewRow();
                row[0] = flight.FlightNum;
                row[1] = flight.From;
                row[2] = flight.Arrival;
                row[3] = flight.GetOff;
                row[4] = flight.ArrivalTime;
                row[5] = flight.Prices;
                row[6] = flight.Discount;
                row[7] = flight.left;
                dt.Rows.Add(row);
            }
        }
    }
}
