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

namespace Librarian_System
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=lib_database;Integrated Security=True");
		SqlCommand cmd;
		SqlDataReader dr;
		private String getusername()
		{
			con.Open();
			String syntax = "SELECT value FROM SystemTable where property='username'";
			cmd = new SqlCommand(syntax, con);
			dr = cmd.ExecuteReader();
			dr.Read();
			String temp= dr[0].ToString();
			con.Close();
			return temp;
		}

		private String getpassword()
		{
			con.Open();
			String syntax = "SElECT value FROM SystemTable where property='password'";
			cmd = new SqlCommand(syntax, con);
			dr = cmd.ExecuteReader();
			dr.Read();
			String temp= dr[0].ToString();
			con.Close();
			return temp;

		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			String Usname = getusername(), Uspass = getpassword(), name, pass;
			name = textBox1.Text;
			pass = textBox2.Text;

			if (name.Equals(Usname) && pass.Equals(Uspass))
			{
				label3.Hide();
				MessageBox.Show("Logged in Succesfully");
				Body obj = new Body();
				this.Hide();
				obj.Show();
			}
			else
				label3.Show();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
