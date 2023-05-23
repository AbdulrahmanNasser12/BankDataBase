using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Sign_up
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(this.textBox1.Text);
            int input2 = Convert.ToInt32(this.textBox2.Text);
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            sqlCommand.CommandText = "insert into EMPLOYEE values('" + input1 + "','" + input2 + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')";
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Sign Up Operation Completed Successfuly");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.eMPLOYEETableAdapter.Fill(this.bankDataSet1.EMPLOYEE);

        }
    }
}
