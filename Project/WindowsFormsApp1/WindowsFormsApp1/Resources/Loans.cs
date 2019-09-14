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
    public partial class Loans : Form
    {
        private MySqlConnection Connection = new MySqlConnection("SERVER=localhost;DATABASE=library;UID=root;PASSWORD=admin;");

        public Loans()
        {
            InitializeComponent();
        }

        private void Loans_Load(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                Load_Loan_View();
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

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            CloseConnection();
            Main_Menu Form1 = new Main_Menu();
            Form1.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
            //Close();
            
        }

        private void SrchLoanBtn_Click(object sender, EventArgs e)
        {
            string search = SrchLoanBox.Text;

            Load_Loan_View_Search(search);
        }

        private void CheckInBtn_Click(object sender, EventArgs e)
        {
            string Loan_ID = dataGridView1.CurrentRow.Cells["Loan_ID"].Value.ToString();

            bool Check = Check_Book_Due_Date(Loan_ID);

            if (Check == true)
            {
                CheckInGBox.Show();
                ISBNTxtBox.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
                CardIDTxtBox.Text = dataGridView1.CurrentRow.Cells["Card_ID"].Value.ToString();
                BorrTxtBox.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                DateInTxtBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                MessageBox.Show("Please verify the information is correct.");
            }
            else
                MessageBox.Show("The loan has already been completed.");

        }

        private bool Check_Book_Due_Date(string Loan_ID)
        {
            string Query = "select count(*) from book_loans where Loan_ID = '" + Loan_ID + "' and Date_In is NULL;";

            try
            {
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                int count = Convert.ToInt32(Command.ExecuteScalar());

                //MessageBox.Show(count.ToString());

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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ISBNTxtBox.Clear();
            CardIDTxtBox.Clear();
            BorrTxtBox.Clear();
            DateInTxtBox.Clear();
            CheckInGBox.Hide();
            Load_Loan_View();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            string Loan_ID = dataGridView1.CurrentRow.Cells["Loan_ID"].Value.ToString();
            string Date =DateTime.Now.ToString("yyyy-MM-dd");
                       
            string Query = "update book_loans set Date_In = '" + Date + "' where Loan_ID = '"+ Loan_ID +"';";
                        
            try
            {
                MySqlCommand Comm = new MySqlCommand(Query, Connection);
                MySqlDataReader Reader;
                Reader = Comm.ExecuteReader();
                MessageBox.Show("Check In Complete.");
                Reader.Close();
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Loan_View();
            CheckInGBox.Hide();

        }

        private void Load_Loan_View()
        {
             string Query = "select * from loan_view where Date_In is null;";
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

        private void Load_Loan_View_Search(string SearchText)
        {
            try
            {
                string searchQuery = "select * from loan_view " +
                    "where ISBN like '%" + SearchText + "%' or Card_ID like '%" + SearchText + "%' or Name like '%" + SearchText + "%'" + 
                    "and Date_In is null;";
                MySqlDataAdapter Adap = new MySqlDataAdapter(searchQuery, Connection);
                DataSet Data1 = new DataSet();
                Adap.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            SrchLoanBox.Clear();
            Load_Loan_View();

            if(CheckInGBox.Visible == true)
            {
                ISBNTxtBox.Clear();
                CardIDTxtBox.Clear();
                BorrTxtBox.Clear();
                DateInTxtBox.Clear();
                CheckInGBox.Hide();
            }
            if(AllLoanGrpBox.Visible == true)
            {
                SrchAllTxtBox.Clear();
                AllLoanGrpBox.Hide();
            }

        }

        private void ShowAllLoanBtn_Click(object sender, EventArgs e)
        {
            Load_Loan_View_All();
            AllLoanGrpBox.Show();

        }

        private void Load_Loan_View_All()
        {
            string Query = "select * from loan_view;";
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

        private void SrchAllBtn_Click(object sender, EventArgs e)
        {
            string SearchText = SrchAllTxtBox.Text;
            Load_Search_Loan_All(SearchText);
            
        }

        private void Load_Search_Loan_All(string SearchText)
        {
            try
            {
                string searchQuery = "select * from loan_view " +
                    "where Card_ID like '%" + SearchText + "%' or Name like '%" + SearchText + "%';";
                MySqlDataAdapter Adap = new MySqlDataAdapter(searchQuery, Connection);
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
            AllLoanGrpBox.Hide();
            Load_Loan_View();
        }
    }
}
