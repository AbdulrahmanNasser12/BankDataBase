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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(this.textBox1.Text);
            int input2 = Convert.ToInt32(this.textBox2.Text);
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            sqlCommand.CommandText = "insert into ACCOUNT values('" + input1 + "','" + input2 + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')";
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Sign Up Operation Completed Successfuly");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet2.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.bankDataSet2.ACCOUNT);
            // TODO: This line of code loads data into the 'bankDataSet2.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter1.Fill(this.bankDataSet2.LOAN);
            // TODO: This line of code loads data into the 'bankDataSet1.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter.Fill(this.bankDataSet1.LOAN);
            // TODO: This line of code loads data into the 'bankDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.aCCOUNTTableAdapter.Fill(this.bankDataSet2.ACCOUNT);

        }
    }
}
