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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.passDic.ContainsKey(textBox2.Text)) {
                Passager pass = Program.passList.GetElem(Program.passDic[textBox2.Text]);
                if (textBox1.Text.Equals(pass.Name))
                {
                    if (!Program.passList.IsEmpty())
                    {   
                        Passager depass= Program.passList.Delete(Program.passDic[textBox2.Text]);
                        Program.passDic.Remove(textBox2.Text);
                        MessageBox.Show("删除成功");
                        this.Dispose();
                    }else
                    {
                        MessageBox.Show("无任何订单");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("身份证号与姓名不符");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("无此订单");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
