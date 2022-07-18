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
	public partial class TransactionUserControl : UserControl
	{
		private static TransactionUserControl _instance;
		public static TransactionUserControl Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new TransactionUserControl();
				}
				return _instance;
			}
		}
		public TransactionUserControl()
		{
			InitializeComponent();
		}
		public string Book1, Book2, Borrower;

		SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=lib_database;Integrated Security=True");
		public SqlCommand cmd;
		public SqlDataReader dr;

		private void TransactionUserControl_Load(object sender, EventArgs e)
		{
			refresh_Data_GridView_transact();
		}

		public void refresh_Data_GridView_transact()
		{

			try
			{
				SqlCommand cmd = new SqlCommand("[Show_Transaction_logdata_sp]", con);
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
				this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			SearchBookbutton.PerformClick();
			SearchBorrowerButton.PerformClick();
			if ((AccNotextBox.Text != Book1) && (AccNotextBox.Text != Book2))
			{
				MessageBox.Show("The borrower has not borrowed the book");
			}
			
			//all is well,so continue return process
			try
			{
				if (Book1 ==AccNotextBox.Text)
				{
					//accno must be updated in the book1 slot
					cmd = new SqlCommand("Transact_Update_Book1_sp", con);
				}
				else
				{
					//accno must be updated in the book2 slot
					cmd = new SqlCommand("Transact_Update_Book2_sp", con);
				}
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@accno", (object)DBNull.Value);
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
			// now we also update the borrower's id in the books table

			cmd = new SqlCommand("Transact_Update_Borrower_sp", con);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@accno", AccNotextBox.Text);
			cmd.Parameters.AddWithValue("@brid", (object)DBNull.Value);

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

			cmd = new SqlCommand("transaction_delete_sp", con);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@bkid", AccNotextBox.Text);
			cmd.Parameters.AddWithValue("@brid", BorrowerIDtextBox.Text);

			con.Open();
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				MessageBox.Show("		<<<Invalid SQL Operation>>>: \n" + ex);
			}
			con.Close();
			/*this completes the entire transaction , so now to update the values,we perform the click event on both the buttons so that the user can see the changes made*/
			SearchBookbutton.PerformClick();
			SearchBorrowerButton.PerformClick();
			MessageBox.Show("Succesfully returned");
		}

		private void SearchBookbutton_Click(object sender, EventArgs e)
		{
			con.Open();
			String syntax = "SELECT borrower FROM Books where accno= '" + AccNotextBox.Text + "'";
			cmd = new SqlCommand(syntax, con);
			dr = cmd.ExecuteReader();
			dr.Read();
			BorrowerIDfilllabel.Text = Borrower = dr[0].ToString();
			con.Close();
		}

		private void IssueBookbutton_Click(object sender, EventArgs e)
		{
			//see if book is borrowed by someone
			SearchBookbutton.PerformClick();
			if (Borrower != "")
			{
				//someone has borrowed the book
				MessageBox.Show("Book is already borrowed by some other Borrower with borrower id : \n" + Borrower);
				return;
			}
			//see if borrower has already taken two books
			SearchBorrowerButton.PerformClick();
			if ((Book1 != "") && (Book2 != ""))
			{
				//borrower has already borrowed maximum number of books
				MessageBox.Show("Borrower has already borrowed maximum number of books.");
				return;
			}
			//all is well,so continue issue process
			//first set the value of book1 or book2 as the accno of the book being issued
			try
			{
				if(Book1=="")
				{
					//accno must be updated in the book1 slot
					cmd = new SqlCommand("Transact_Update_Book1_sp", con);
				}
				else
				{
					//accno must be updated in the book2 slot
					cmd = new SqlCommand("Transact_Update_Book2_sp", con);
				}
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@accno", AccNotextBox.Text);
				cmd.Parameters.AddWithValue("@brid", BorrowerIDtextBox.Text);

				con.Open();
				try
				{
					cmd.ExecuteNonQuery();
				}
				catch(Exception ex)
				{
					MessageBox.Show("		<<<Invalid SQL Operation>>>: \n" + ex);
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("" + ex);
			}
			// now we also update the borrower's id in the books table

			cmd = new SqlCommand("Transact_Update_Borrower_sp", con);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@accno", AccNotextBox.Text);
			cmd.Parameters.AddWithValue("@brid", BorrowerIDtextBox.Text);

			con.Open();
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				MessageBox.Show("		<<<Invalid SQL Operation>>>: \n" + ex);
			}
			con.Close();

			//now we need to insert thhe issue details into the transaction table
			cmd = new SqlCommand("transaction_insert_sp", con);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@bkid", AccNotextBox.Text);
			cmd.Parameters.AddWithValue("@brid", BorrowerIDtextBox.Text);

			con.Open();
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				MessageBox.Show("		<<<Invalid SQL Operation>>>: \n" + ex);
			}
			con.Close();

			/*this completes the entire transaction , so now to update the values,we perform the click event on both the buttons so that the user can see the changes made*/
			SearchBookbutton.PerformClick();
			SearchBorrowerButton.PerformClick();
			MessageBox.Show("Succesfully issued");

		}

		private void Clearbutton_Click(object sender, EventArgs e)
		{
			BorrowerIDtextBox.Text = "";
			Book1filllabel.Text = "";
			Book2fillabel.Text = "";
			AccNotextBox.Text = "";
			BorrowerIDfilllabel.Text = "";
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ShowLogoftranbutton_Click(object sender, EventArgs e)
		{
			refresh_Data_GridView_transact();
		}

		private void Book1label_Click(object sender, EventArgs e)
		{

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			//to get book 1
			con.Open();
			String syntax = "SELECT Book1 FROM Borrowers where brid='"+BorrowerIDtextBox.Text+"'";
			cmd = new SqlCommand(syntax, con);
			dr = cmd.ExecuteReader();
			dr.Read();
			Book1filllabel.Text = Book1 = dr[0].ToString();
			con.Close();
			//to get book 2
			con.Open();
			syntax = "SELECT Book2 FROM Borrowers where brid='" + BorrowerIDtextBox.Text + "'";
			cmd = new SqlCommand(syntax, con);
			dr = cmd.ExecuteReader();
			dr.Read();
			Book2fillabel.Text = Book2 = dr[0].ToString();
			con.Close();
			
		}
	}
}
