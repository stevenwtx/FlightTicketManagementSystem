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
    public partial class Form7 : Form
    {
        private Flight flight;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String num = comboBox1.Text;
            flight = Program.FlightList.GetElem(Program.flightDic[num]);
            textBox1.Text = flight.From;
            textBox2.Text = flight.Arrival;
            textBox3.Text = flight.GetOff;
            textBox4.Text = flight.ArrivalTime;
            textBox5.Text = ""+flight.Prices;
            textBox6.Text = ""+flight.Discount;
            textBox7.Text = "" + flight.left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flight.From = textBox1.Text;
            flight.Arrival = textBox2.Text;
            flight.GetOff = textBox3.Text;
            flight.ArrivalTime = textBox4.Text;
            flight.Prices = Int32.Parse(textBox5.Text);
            flight.Discount = double.Parse(textBox6.Text);
            flight.left = Int32.Parse(textBox7.Text);
            MessageBox.Show("修改成功");
            String num = comboBox1.Text;
            flight = Program.FlightList.GetElem(Program.flightDic[num]);
            textBox1.Text = flight.From;
            textBox2.Text = flight.Arrival;
            textBox3.Text = flight.GetOff;
            textBox4.Text = flight.ArrivalTime;
            textBox5.Text = "" + flight.Prices;
            textBox6.Text = "" + flight.Discount;
            textBox7.Text = "" + flight.left;
        }
    }
}
