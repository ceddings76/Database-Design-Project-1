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
    public partial class Main_Menu : Form
    {
        //private string server = "localhost";
       // private string database = "library";
        //private string uid = "root";
        //private string password = "admin";
        private MySqlConnection Connection = new MySqlConnection("SERVER=localhost;DATABASE=library;UID=root;PASSWORD=admin;");


        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

            if (this.OpenConnection() == true)
            {
                Load_Book_View();


                DataGridViewColumn column = dataGridView1.Columns["ISBN"];
                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DataGridViewColumn column2 = dataGridView1.Columns["Title"];
                //column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DataGridViewColumn column3 = dataGridView1.Columns["Name"];
                //column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                column.Width = 100;
                column2.Width = 350;
                column3.Width = 200;
            }
            else
            {
                MessageBox.Show("There is an issue with your SQL connection.");
            }
        

        }

        private void SearchBookbtn_Click(object sender, EventArgs e)
        {
            string search = SearchBox1.Text;

            Load_Book_View_Search(search);

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

        private void BorrBtn_Click(object sender, EventArgs e)
        {
            Borrower form2 = new Borrower();
            form2.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void Loanbtn_Click(object sender, EventArgs e)
        {
            Loans form3 = new Loans();
            form3.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            string ISBN = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            
            bool Book_Out = Check_Book(ISBN);
            
            if (Book_Out == true)
            {
                CheckOutGrp.Show();
                ISBNDispBox.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
                TitleDispBox.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
                MessageBox.Show("Enter a user's Card ID into the text box and click the enter button.");
            }
            else
                MessageBox.Show("This book is already checked out.  Sorry.");
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {            
            string Card_ID = CardTxtBox.Text;
            string ISBN = ISBNDispBox.Text;
            string Date = DateTime.Now.ToString("yyyy-MM-dd");

            
            bool Card_ID_Check = Verify_Card_ID(Card_ID);

           string Query = "insert into book_loans(ISBN, Card_ID, Date_out) values ('" + ISBN + "', '" + Card_ID + "', '" + Date + "');";

            if (Card_ID_Check == true)
            {
                bool Check = Check_Borrower(Card_ID);

                if (Check == true)
                {
                    Execute_Check_Out(ISBN, Card_ID, Date);
                }
                else
                {
                    MessageBox.Show("The user has already has 3 books checked out.");
                }
                ISBNDispBox.Clear();
                CardTxtBox.Clear();
                TitleDispBox.Clear();
                CheckOutGrp.Hide();
                Load_Book_View();
            }
            else
            {
                MessageBox.Show("There is no borrower with that card id.  Please try again.");
                CardTxtBox.Clear();
            }           
        }

        private bool Check_Borrower(string Card_ID)
        {
            string Query = "select count(*) from book_loans where Card_ID = '" + Card_ID + "' and Date_In is NULL;";

            try
            {
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                int count = Convert.ToInt32(Command.ExecuteScalar());

                MessageBox.Show("The borrower has " + count.ToString()+ " books checked out.");
                                
                if (count < 3)
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

        private bool Check_Book(string ISBN)
        {
            string Query = "select count(*) from book_loans where ISBN = '" + ISBN + "' and Date_In is NULL;";

            try
            {
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                int count = Convert.ToInt32(Command.ExecuteScalar());

                if (count == 0)
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

        private void FinesBtn_Click(object sender, EventArgs e)
        {
            Fines form4 = new Fines();
            form4.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void Load_Book_View()
        {
            try
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from book_available", Connection);
                DataSet Data1 = new DataSet();
                Adapter.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_Book_View_Search(string Search)
        {
            try
            {
                string searchQuery = "select * from book_available where ISBN like '%" + Search + "%' or Title like '%"
                    + Search + "%' or Name like '%" + Search + "%';";
                MySqlDataAdapter Adap = new MySqlDataAdapter(searchQuery, Connection);
                DataSet Data1 = new DataSet();
                Adap.Fill(Data1);
                dataGridView1.DataSource = Data1.Tables[0];

                /*
                DataGridViewColumn column = dataGridView1.Columns["ISBN"];
                DataGridViewColumn column2 = dataGridView1.Columns["Title"];
                DataGridViewColumn column3 = dataGridView1.Columns["Name"];

                column.Width = 100;
                column2.Width = 350;
                column3.Width = 200;*/

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Execute_Check_Out(string ISBN, string Card_ID, string Date)
        {
            string Query = "insert into book_loans(ISBN, Card_ID, Date_out) values ('" + ISBN + "', '" + Card_ID + "', '" + Date + "');";

            try
            {
                MySqlCommand Comm = new MySqlCommand(Query, Connection);
                MySqlDataReader Reader;
                Reader = Comm.ExecuteReader();
                MessageBox.Show("Check Out Complete.");
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            CardTxtBox.Clear();
            ISBNDispBox.Clear();
            TitleDispBox.Clear();
            CheckOutGrp.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SearchBox1.Clear();
            if (CheckOutGrp.Visible == true)
            {
                CardTxtBox.Clear();
                ISBNDispBox.Clear();
                TitleDispBox.Clear();
                CheckOutGrp.Hide();
            }
            Load_Book_View();
        }

        private bool Verify_Card_ID(string Card_ID)
        {
            string Query = "select count(*) from borrower where Card_ID = '" + Card_ID + "';";

            try
            {
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                int count = Convert.ToInt32(Command.ExecuteScalar());

                if (count == 1)
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

        
    }
}
