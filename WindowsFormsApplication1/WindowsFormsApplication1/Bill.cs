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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, num5,sum;
            num1 = Int32.Parse(label6.Text);
            num2 = Int32.Parse(label7.Text);
            num3 = Int32.Parse(label8.Text);
            num4 = Int32.Parse(label9.Text);
            num5 = Int32.Parse(label10.Text);
            sum = num1 + num2 + num3 + num4 + num5;
            label11.Text = sum.ToString();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            label1.Text = FastFood.SetValueForCombo1;
            label2.Text = FastFood.SetValueForCombo2;
            label3.Text = FastFood.SetValueForCombo3;
            label4.Text = FastFood.SetValueForCombo4;
            label5.Text = FastFood.SetValueForCombo5;
            label6.Text = FastFood.SetValueForCombo6;
            label7.Text = FastFood.SetValueForCombo7;
            label8.Text = FastFood.SetValueForCombo8;
            label9.Text = FastFood.SetValueForCombo9;
            label10.Text = FastFood.SetValueForCombo10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mpage mp = new mpage();
            mp.Show();
        }
    }
}
