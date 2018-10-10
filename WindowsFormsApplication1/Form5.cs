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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.flightDic.ContainsKey(textBox1.Text))
            {
                double bill=0;
                Passager newpass = new Passager(textBox2.Text, textBox3.Text, textBox1.Text, Program.ordernum, Int32.Parse(textBox4.Text));
                
                Flight flight = Program.FlightList.GetElem(Program.flightDic[textBox1.Text]);
                if (flight.left >= Int32.Parse(textBox4.Text)){
                    flight.left -= Int32.Parse(textBox4.Text);
                    bill = (flight.Prices * 1.0) * flight.Discount*(Int32.Parse(textBox4.Text)*1.0);

                    Program.passList.Append(newpass);
                    Program.passDic.Add(textBox3.Text, Program.passindex);
                  Program.passindex++;
                    MessageBox.Show("订票成功,价格为" + bill + "。订单号为" + Program.ordernum);
                    Program.ordernum++;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("余票不足");
                }
                
            }
            else
            {
                MessageBox.Show("没有此航班");
            }
        }
    }
}
