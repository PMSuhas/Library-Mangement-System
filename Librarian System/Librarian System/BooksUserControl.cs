using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librarian_System
{
	public partial class BooksUserControl : UserControl
	{
		private static BooksUserControl _instance;
		public static BooksUserControl Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new BooksUserControl();
				}
				return _instance;
			}
		}
		public BooksUserControl()
		{
			InitializeComponent();
		}


		SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=lib_database;Integrated Security=True");

		private void BooksUserControl_Load(object sender, EventArgs e)
		{
			refresh_Data_GridView();
		}

		private void Updatebutton_Click(object sender, EventArgs e)
		{
		}

		public void refresh_Data_GridView()
		{

			try
			{
				SqlCommand cmd = new SqlCommand("[ShowAllBooksData_sp]", con);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter DA = new SqlDataAdapter(cmd);
				DataSet DS = new DataSet();
				DA.Fill(DS);

				con.Open();
				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show("		<<<Inavlid SQL Operation>>>: \n" + ex);
				}
				con.Close();

				dataGridView1.DataSource = DS.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
		}

		private void Addbutton_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("[BooksAdd_sp]", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@accno", AccNotextBox.Text);
			cmd.Parameters.AddWithValue("@isbn",ISBNtextBox.Text);
			cmd.Parameters.AddWithValue("@name",NametextBox.Text);
			cmd.Parameters.AddWithValue("@author",AuthortextBox.Text);
			cmd.Parameters.AddWithValue("@publisher",PublishertextBox.Text);
			cmd.Parameters.AddWithValue("@did",Depeartment_combobox.Text);


			con.Open();
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("		<<<Invalid SQL operation>>>: \n" + ex);
			}
			con.Close();
			refresh_Data_GridView();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ISBNlabel_Click(object sender, EventArgs e)
		{

		}

		private void Authorlabel_Click(object sender, EventArgs e)
		{

		}

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("[BooksDelete_sp]", con);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@accno", AccNotextBox.Text);

				con.Open();
				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show("		<<<Invalid SQL Operation>>>: \n" + ex);
				}
				con.Close();

				refresh_Data_GridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
		}

		private void BookSearchtextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void SearchBookButton_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("[SearchBook_sp]", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@accno", BookSearchtextBox.Text);
				SqlDataAdapter DA = new SqlDataAdapter(cmd);
				DataSet DS = new DataSet();
				DA.Fill(DS);
				
				con.Open();
				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show("		<<<Inavlid SQL Operation>>>: \n" + ex);
				}
				con.Close();

				dataGridView1.DataSource = DS.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			BookSearchtextBox.Text =null;
			AccNotextBox.Text= null;
			ISBNtextBox.Text = null;
			NametextBox.Text = null;
			PublishertextBox.Text = null;
			AuthortextBox.Text = null;
			Depeartment_combobox.Text = null;
		}
	}
}
