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

    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc = null;
            dc = dt.Columns.Add("姓名", Type.GetType("System.String"));
            dc = dt.Columns.Add("证件号",Type.GetType("System.String"));
            dc = dt.Columns.Add("订单号", Type.GetType("System.Int32"));
            dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("起点", Type.GetType("System.String"));
            dc = dt.Columns.Add("终点", Type.GetType("System.String"));
            dc = dt.Columns.Add("起飞时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("到达时间", Type.GetType("System.String"));
            
            int i = 1;
            dataGridView1.DataSource = dt.DefaultView;
            //dt.Rows.Clear();
            DataRow row;
            dt.Rows.Clear();
            row = dt.NewRow();
            while (i <= Program.passList.GetLength())
            {
                Passager pass = Program.passList.GetElem(i);
                Flight flight = Program.FlightList.GetElem(Program.flightDic[pass.FlightNum]);
                i++;


                row = dt.NewRow();
                {
                   
                    row[0] = pass.Name;
                    row[1] = pass.IdNum; row[2] = i - 1;
                    row[3] = pass.FlightNum;
                    row[4] = flight.From;
                    row[5] = flight.Arrival;
                    row[6] = flight.GetOff;
                    row[7] = flight.ArrivalTime;
                    
                }
                dt.Rows.Add(row);

                //dc = dt.Columns.Add("from", Type.GetType("System.String"));
                // dataGridView1.DataSource = dt;
                // listView1.Columns[1].Text=pass.FlightNum+"  "+flight.From+"  "+flight.Arrival+"  "+flight.GetOff+"  "+flight.ArrivalTime;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc = null;
            dc = dt.Columns.Add("姓名", Type.GetType("System.String"));
            dc = dt.Columns.Add("订单号", Type.GetType("System.Int32"));
            dc = dt.Columns.Add("航班号", Type.GetType("System.String"));
            dc = dt.Columns.Add("起点", Type.GetType("System.String"));
            dc = dt.Columns.Add("终点", Type.GetType("System.String"));
            dc = dt.Columns.Add("起飞时间", Type.GetType("System.String"));
            dc = dt.Columns.Add("到达时间", Type.GetType("System.String"));

            //int i = 1;
            dataGridView1.DataSource = dt.DefaultView;
            //dt.Rows.Clear();
            DataRow row;
            dt.Rows.Clear();
            string temp = textBox1.Text;
            Passager pass = Program.passList.GetElem(Program.passDic[temp]);
            if (pass == null)
            {
                MessageBox.Show("订单不存在");
            }
            else
            {

                Flight flight = Program.FlightList.GetElem(Program.flightDic[pass.FlightNum]);


                row = dt.NewRow();
                {
                    row[0] = pass.Name;
                    row[1] = Program.passDic[temp];
                    row[2] = pass.FlightNum;
                    row[3] = flight.From;
                    row[4] = flight.Arrival;
                    row[5] = flight.GetOff;
                    row[6] = flight.ArrivalTime;

                }
                dt.Rows.Add(row);

            }
            //dc = dt.Columns.Add("from", Type.GetType("System.String"));
            // dataGridView1.DataSource = dt;
            // listView1.Columns[1].Text=pass.FlightNum+"  "+flight.From+"  "+flight.Arrival+"  "+flight.GetOff+"  "+flight.ArrivalTime;

        }
    }
}
