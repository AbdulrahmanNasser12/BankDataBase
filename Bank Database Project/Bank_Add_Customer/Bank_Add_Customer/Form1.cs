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

namespace Bank_Add_Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bankDataSet.CUSTOMER' table. You can move, or remove it, as needed.

            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(this.textBox1.Text);
            int input2 = Convert.ToInt32(this.textBox2.Text);
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            sqlCommand.CommandText = "insert into CUSTOMER values('" + input1 + "','" + input2 + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "')";
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The The Customer Added Successfuly");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.bankDataSet.CUSTOMER);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(this.textBox1.Text);
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("delete from CUSTOMER where SSN= '" + input + "'", sqlConnection);
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The Customer Deleted Successfuly");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(this.textBox1.Text);
            int input2 = Convert.ToInt32(this.textBox2.Text);
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("UPDATE CUSTOMER SET BNUM = '"+ input2 + "'  WHERE SSN= '" + input + "'", sqlConnection);
            myCommand.ExecuteNonQuery();
            myCommand = new SqlCommand("UPDATE CUSTOMER SET FNAME = '" + textBox3.Text.ToString() + "'  WHERE SSN= '" + input + "'", sqlConnection); ;
            myCommand.ExecuteNonQuery();
            myCommand = new SqlCommand("UPDATE CUSTOMER SET LNAME = '" + textBox4.Text.ToString() + "'  WHERE SSN= '" + input + "'", sqlConnection); ;
            myCommand.ExecuteNonQuery();
            myCommand = new SqlCommand("UPDATE CUSTOMER SET CITY = '" + textBox5.Text.ToString() + "'  WHERE SSN= '" + input + "'", sqlConnection); ;
            myCommand.ExecuteNonQuery();
            myCommand = new SqlCommand("UPDATE CUSTOMER SET STREET = '" + textBox6.Text.ToString() + "'  WHERE SSN= '" + input + "'", sqlConnection); ;
            myCommand.ExecuteNonQuery();
            myCommand = new SqlCommand("UPDATE CUSTOMER SET DISTRICT = '" + textBox7.Text.ToString() + "'  WHERE SSN= '" + input + "'", sqlConnection); ;
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The Customer Updated Successfuly");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32(this.textBox11.Text);
            int input2 = Convert.ToInt32(this.textBox1.Text);
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            sqlCommand.CommandText = "insert into ACCOUNT values('" + input1 + "','" + input2 + "','" + textBox10.Text.ToString() + "','" + textBox9.Text.ToString() + "')";
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Account Added Successfuly");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            int input = Convert.ToInt32(this.textBox11.Text);
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = myCommand = new SqlCommand("UPDATE ACCOUNT SET LOAN_TYPE = '" + textBox10.Text.ToString() + "'  WHERE ANUM= '" + input + "'", sqlConnection); ;
            myCommand.ExecuteNonQuery();
            myCommand = new SqlCommand("UPDATE ACCOUNT SET BALANCE = '" + textBox9.Text.ToString() + "'  WHERE ANUM= '" + input + "'", sqlConnection); ;
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The Account Updated Successfuly");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(this.textBox11.Text);
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-A5LRT35I;Initial Catalog=Bank;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("delete from ACCOUNT where ANUM= '" + input + "'", sqlConnection);
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The Account Deleted Successfuly");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.aCCOUNTTableAdapter.Fill(this.bankDataSet.ACCOUNT);
        }
    }
}
