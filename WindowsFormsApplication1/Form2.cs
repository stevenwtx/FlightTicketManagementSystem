using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsApplication1.FakeList<>;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flight newflight = new Flight(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,Int32.Parse(textBox6.Text),double.Parse(textBox7.Text),Int32.Parse(textBox8.Text));
            Program.FlightList.Append(newflight);
            Program.flightDic.Add(textBox1.Text, Program.flightindex);
            Program.flightindex++;
            MessageBox.Show("添加成功");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
           // Flight test = Program.FlightList.GetElem(1);
            //MessageBox.Show(test.FlightNum);
        }

       
    }
}
