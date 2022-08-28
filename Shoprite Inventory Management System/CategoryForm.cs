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

namespace Shoprite_Inventory_Management_System
{
    public partial class CategoryForm : Form
    {
        const string connectionString = "Server = localhost; Database=fredadb;User id=root;Password=Eselase12/.;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        public CategoryForm()
        {
            InitializeComponent();
        }

        public void categoryButtonClick(object sender, EventArgs e)
        {
            Generators generator = new Generators();
            try
            {
                const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
                MySqlConnection sqlConnection = new MySqlConnection(connectionString);
               

                string sqlStatement =
                    $"INSERT INTO `Category`(`Category_Name`, `Description`,`Category_Code`) VALUES ('{catNameTextBox.Text}', '{catDisTextBox.Text}', '{generator.randomProductcode(5)}')";

                //WriteLine(sqlStatement);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show($"{this.catNameTextBox.Text} has been added successfully");
                catNameTextBox.Clear();
                catDisTextBox.Clear();
                Admin_Screen admin = new Admin_Screen();
                admin.cateButton();

                
            }
            catch (Exception eb)
            {
                MessageBox.Show($"An error occured {eb.StackTrace}");
                throw;
            }

            this.Hide();
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
