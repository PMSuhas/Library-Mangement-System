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
	public partial class BorrowersUserControl : UserControl
	{
		private static BorrowersUserControl _instance;
		public static BorrowersUserControl Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new BorrowersUserControl();
				}
				return _instance;
			}
		}

		public BorrowersUserControl()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=lib_database;Integrated Security=True");

		private void BorrowersUserControl_Load(object sender, EventArgs e)
		{
			refresh_Data_Grid_View_Borrowers();
		}

		private void Borrowersidlabel_Click(object sender,EventArgs e)
		{

		}
		private void label1_Click(object sender,EventArgs e)
		{

		}
		public void refresh_Data_Grid_View_Borrowers()
		{
			try
			{
				SqlCommand cmd = new SqlCommand("[ShowAll_Borrowers_data_sp]", con);
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

		private void AddButton_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("[Borrowers_Add_sp]", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@brid", BorrowerIDtextBox.Text);
			cmd.Parameters.AddWithValue("@name", NametextBox.Text);
			cmd.Parameters.AddWithValue("@address", AddresstextBox.Text);
			cmd.Parameters.AddWithValue("@phone", PhonetextBox.Text);

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
			refresh_Data_Grid_View_Borrowers();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("[Borrower_Delete_sp]", con);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@brid", BorrowerIDtextBox.Text);

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

				refresh_Data_Grid_View_Borrowers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("[Search_Borrower_sp]", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@brid", BorrowerIDSearchtextBox.Text);
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
			BorrowerIDSearchtextBox.Text = "";
			BorrowerIDtextBox.Text = "";
			NametextBox.Text = "";
			AddresstextBox.Text = "";
			PhonetextBox.Text = "";
		}
	}
}
