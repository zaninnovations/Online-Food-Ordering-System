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
    public partial class Create_Account : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Faizan Ramzan\Desktop\Fakeha\WindowsFormsApplication1\WindowsFormsApplication1\New folder\Food Odering System.mdf;Integrated Security=True;Connect Timeout=30");
        public Create_Account()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login l = new Login();
            l.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into FLogin values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
         
            MessageBox.Show("Account created successfully");

           
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }
    }
}
