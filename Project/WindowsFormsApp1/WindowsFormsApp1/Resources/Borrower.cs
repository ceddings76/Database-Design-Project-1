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

    public partial class Borrower : Form
    {
        private MySqlConnection Connection = new MySqlConnection("SERVER=localhost;DATABASE=library;UID=root;PASSWORD=admin;");
        //private MySqlDataAdapter Adapter = new MySqlDataAdapter();
        

        public Borrower()
        {
            InitializeComponent();
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

        private void Borrower_Load_1(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                Load_Borrower_View();
            }
            else
            {
                MessageBox.Show("There is an issue with your connection.");
            }

            DataGridViewColumn column1 = dataGridView1.Columns["Card_ID"];
            DataGridViewColumn column2 = dataGridView1.Columns["SSN"];
            DataGridViewColumn column3 = dataGridView1.Columns["Bname"];
            DataGridViewColumn column4 = dataGridView1.Columns["Address"];
            DataGridViewColumn column5 = dataGridView1.Columns["Phone"];
            DataGridViewColumn column6 = dataGridView1.Columns["Email"];
            
            /*
            column1.Width = 40;
            column2.Width = 75;
            column3.Width = 100;
            column4.Width = 200;
            column5.Width = 100;
            column6.Width = 150;*/

        }

        private void SrchBtn_Click(object sender, EventArgs e)
        {
            string search = SrchBxTxt.Text;

            Load_Borrower_Search(search);

        }

        private void AddBrrwrBtn_Click(object sender, EventArgs e)
        {
            string Name = NameTxt.Text;
            string SSN = SSNTxt.Text;
            string Address = AddressTxt.Text;
            string Phone = PhoneTxt.Text;
            string Email = EmailTxt.Text;

            bool SSN_Unique = Check_SSN(SSN);
            
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(SSN) && !string.IsNullOrEmpty(Address))
            {
                SSN = Format_SSN(SSN);

                if (SSN_Unique == true)
                {
                    Execute_Add_Borrower(Name, SSN, Address, Phone, Email);
                }
                else
                {
                    MessageBox.Show("The SSN number provided is already in use.  Please enter another SSN or update the existing record.");
                }     
            }
            else
            {
                MessageBox.Show("The values for Name, SSN, and Address must be filled in.");
            }

            NameTxt.Clear();
            SSNTxt.Clear();
            AddressTxt.Clear();
            PhoneTxt.Clear();
            EmailTxt.Clear();
            Load_Borrower_View();
            
        }

        private bool Check_SSN(string SSN)
        {
            string Query = "select count(*) from borrower where SSN = '" + SSN + "';";

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

        private string Format_SSN(string SSN)
        {
           string NewSSN = "";

            if (SSN.Length <= 11 && SSN.Length > 8)
            {
                if (SSN[3] != '-' && SSN[6] != '-' && SSN[5] != '-')
                {
                    NewSSN = string.Join("-", SSN.Substring(0, 3), SSN.Substring(3, 2), SSN.Substring(5, 4));
                }
                else if (SSN[3] == '-' && SSN[6] != '-')
                {
                    NewSSN = string.Join("-", SSN.Substring(0, 6), SSN.Substring(6, 4));
                }
                else if (SSN[3] != '-' && SSN[5] == '-')
                {
                    NewSSN = string.Join("-", SSN.Substring(0, 3), SSN.Substring(3, 7));
                }
                else if (SSN[3] == '-' && SSN[6] == '-')
                {
                    NewSSN = SSN;
                }
                else
                {
                    MessageBox.Show("The format for the SSN is not recognized please try again.");
                    SSNTxt.Clear();
                }
            }
            else if (SSN.Length > 11)
            {
                MessageBox.Show("The length of the SSN exceeds the maximum, please try again.");
                SSNTxt.Clear();
            }
            else
            {
                MessageBox.Show("The length of the SSN is to short, please try again.");
                SSNTxt.Clear();
            }

            return NewSSN;
        }

        private void Load_Borrower_View()
        {
            string Query = "select * from borrower_view";
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

        private void Load_Borrower_Search(string Search)
        {
            try
            {
                string searchQuery = "select * from borrower_view where Card_ID like '%" + Search + "%' or SSN like '%"
                    + Search + "%' or Name like '%" + Search + "%' or Email like '%" + Search + "%' or Phone like '%"
                    + Search + "%' or Address like '%" + Search + "%';";

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

        private void Execute_Add_Borrower(string Name, string SSN, string Address, string Phone, string Email)
        {
            string InsertQuery = "insert into borrower (SSN, Bname, Address, Phone, Email)" +
                       " values ('" + SSN + "', '" + Name + "', '" + Address + "', '" + Phone + "', '" + Email + "');";
            try
            {
                MySqlCommand Comm = new MySqlCommand(InsertQuery, Connection);
                MySqlDataReader Reader;
                Reader = Comm.ExecuteReader();
                MessageBox.Show("Data Inserted and Saved");
                Reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearSrchBtn_Click(object sender, EventArgs e)
        {
            SrchBxTxt.Clear();
            Load_Borrower_View();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            NameTxt.Clear();
            SSNTxt.Clear();
            AddressTxt.Clear();
            PhoneTxt.Clear();
            EmailTxt.Clear();
        }

        private void RtrnBtn_Click(object sender, EventArgs e)
        {
            CloseConnection();
            Main_Menu Form1 = new Main_Menu();
            Form1.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

    }


}
