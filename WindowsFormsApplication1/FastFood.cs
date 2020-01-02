using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class FastFood : Form
    {
        public static string SetValueForCombo1 = "";
        public static string SetValueForCombo2 = "";
        public static string SetValueForCombo3 = "";
        public static string SetValueForCombo4 = "";
        public static string SetValueForCombo5 = "";
        public static string SetValueForCombo6 = "";
        public static string SetValueForCombo7 = "";
        public static string SetValueForCombo8 = "";
        public static string SetValueForCombo9 = "";
        public static string SetValueForCombo10 = "";


        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Faizan Ramzan\Desktop\Fakeha\WindowsFormsApplication1\WindowsFormsApplication1\New folder\Food Odering System.mdf;Integrated Security=True;Connect Timeout=30");
        public FastFood()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FastFood_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into FastFood values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            SetValueForCombo1 = comboBox1.Text;
            SetValueForCombo2 = comboBox2.Text;
            SetValueForCombo3 = comboBox3.Text;
            SetValueForCombo4 = comboBox4.Text;
            SetValueForCombo5 = comboBox5.Text;
            SetValueForCombo6 = comboBox6.Text;
            SetValueForCombo7 = comboBox7.Text;
            SetValueForCombo8 = comboBox8.Text;
            SetValueForCombo9 = comboBox9.Text;
            SetValueForCombo10 = comboBox10.Text;
            
            this.Hide();
            Bill b = new Bill();
            b.Show();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            MessageBox.Show(" Order received Successfully !!!!");

           // label1.Text = comboBox1.Text;
            
          }
     
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
