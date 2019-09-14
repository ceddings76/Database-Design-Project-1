using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Resources
{
    public partial class Fines : Form
    {
        private MySqlConnection Connection = new MySqlConnection("SERVER=localhost;DATABASE=library;UID=root;PASSWORD=admin;");

        public Fines()
        {
            InitializeComponent();
        }

        private void Fines_Load(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                Load_Fine_View();
            }
            else
            {
                MessageBox.Show("There is an issue with your SQL connection.");
            }
        }

        private bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //two most common errors 0: cannot connect to server and invalid user id/password
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid User Id or Password.");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void SrchFineBtn_Click(object sender, EventArgs e)
        {
            string search = SrchBox.Text;

            Load_Fine_Search(search);
        }

        private void PayFineBtn_Click(object sender, EventArgs e)
        {
            string Card_ID = dataGridView1.CurrentRow.Cells["Card_ID"].Value.ToString();

            string Query = "select * from fine_view_all_unpaid where Card_ID like '%" + Card_ID + "%';";

            try
            {
                MySqlDataAdapter Adap = new MySqlDataAdapter(Query, Connection);
                DataSet Data1 = new DataSet();
                Adap.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];

                FinPayBtn.Show();
                MessageBox.Show("Select the fine corresponding to the book checked out and click execute.");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            FinPayBtn.Show();
            CancelBtn.Show();

        }

        private void FinPayBtn_Click(object sender, EventArgs e)
        {
            string Loan_ID = dataGridView1.CurrentRow.Cells["Loan_ID"].Value.ToString();
            
            bool Check = Check_Book_In(Loan_ID);

            if (Check == true)
            {
                Execute_Pay_Fine(Loan_ID);
            }
            else
                MessageBox.Show("The book has not been checked in.");
            Load_Fine_View();
            FinPayBtn.Hide();
            CancelBtn.Hide();
        }

        private bool Check_Book_In(string Loan_ID)
        {
            string Query = "select count(*) from book_loans where Loan_ID = '"+Loan_ID+"' and Date_In is not null;";

            try
            {
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                int count = Convert.ToInt32(Command.ExecuteScalar());
                
                if (count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void UpdateFineBtn_Click(object sender, EventArgs e)
        {
            string Query1 = "insert into fines (Loan_ID, Days_over) select book_loans.Loan_ID, datediff(curdate(), book_loans.Due_Date) " +
                "from book_loans, fines where fines.Paid = '0'and datediff(curdate(), book_loans.Due_Date) > '0' and Date_In is null " +
                "on duplicate key update Days_over = datediff(curdate(), book_loans.Due_Date);";

            string Query2 = "insert into fines (Loan_ID, Days_over) select book_loans.Loan_ID, datediff(book_loans.Date_In, book_loans.Due_Date) " +
                "from book_loans, fines where fines.Paid = '0' and datediff(book_loans.Date_In, book_loans.Due_Date) > '0' and Date_In is not null " +
                "on duplicate key update Days_over = datediff(book_loans.Date_In, book_loans.Due_Date);";

            try
            {
                MySqlCommand Comm = new MySqlCommand(Query1, Connection);
                MySqlDataReader Reader;
                Reader = Comm.ExecuteReader();
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlCommand Comm = new MySqlCommand(Query2, Connection);
                MySqlDataReader Reader;
                Reader = Comm.ExecuteReader();
                Reader.Close();
                MessageBox.Show("Update Complete");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Fine_View();
           
        }

        private void Load_Fine_View()
        {
            string Query = "select * from fine_view;";
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter( Query, Connection);
                DataSet Data1 = new DataSet();
                Adapter.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Load_Fine_Search(string Search)
        {
            string Query = "select * from fine_view where Card_ID like '%" + Search + "%' or Bname like '%" + Search + "%';";

            try
            {
                MySqlDataAdapter Adap = new MySqlDataAdapter(Query, Connection);
                DataSet Data1 = new DataSet();
                Adap.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Execute_Pay_Fine(string Loan_ID)
        {
            string Query = "update fines set Paid = '1' where Loan_ID = '" + Loan_ID + "';";

            try
            {
                MySqlCommand Comm = new MySqlCommand(Query, Connection);
                MySqlDataReader Reader;
                Reader = Comm.ExecuteReader();
                MessageBox.Show("The fine is marked as Paid.");
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SrchBox.Clear();
            Load_Fine_View();
            if(SrchAllFinesGrp.Visible == true)
            {
                SrchAllTxtBox.Clear();
                SrchAllFinesGrp.Hide();
            }
            Load_Fine_View();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            FinPayBtn.Hide();
            CancelBtn.Hide();
            Load_Fine_View();
        }

        private void Load_All_Fine_View()
        {
            string Query = "select * from all_fines_view;";
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Query, Connection);
                DataSet Data1 = new DataSet();
                Adapter.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShwAllFinesBtn_Click(object sender, EventArgs e)
        {
            Load_All_Fine_View();
            SrchAllFinesGrp.Show();
        }

        private void RtrnBtn_Click(object sender, EventArgs e)
        {
            CloseConnection();
            Main_Menu Form1 = new Main_Menu();
            Form1.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void SrchAllBtn_Click(object sender, EventArgs e)
        {
            string Search = SrchAllTxtBox.Text;
            Load_Fine_Search_All(Search);
        }

        private void Load_Fine_Search_All(string Search)
        {
            string Query = "select * from all_fines_view where Card_ID like '%" + Search + "%' or Name like '%" + Search + "%';";

            try
            {
                MySqlDataAdapter Adap = new MySqlDataAdapter(Query, Connection);
                DataSet Data1 = new DataSet();
                Adap.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClrAllBtn_Click(object sender, EventArgs e)
        {
            SrchAllTxtBox.Clear();
            SrchAllFinesGrp.Hide();
            Load_Fine_View();
        }
    }
}
