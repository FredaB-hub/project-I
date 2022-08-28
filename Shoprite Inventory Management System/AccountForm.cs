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
    public partial class AccountForm : Form
    {

        const string connectionString = "Server = localhost; Database=fredadb;User id=root;Password=Freda@@2001";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader reader;
        public AccountForm()
        {
            InitializeComponent();
        }

        private void accountButtonClick(object sender, EventArgs e)
        {
            Generators generator = new Generators();
            try
            {
                const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
                
                MySqlConnection sqlConnection = new MySqlConnection(connectionString);
                sqlConnection.Open();

                string sqlStatement =
                    $"INSERT INTO `User`(`Surname`, `Othername`,`Username`,`Email`,`Password`,`PhoneNumber`,`ProfilePicture`,`Gender`,`Role`) VALUES ('{surnameTextBox.Text}', '{othernameTextBox.Text}', '{usernameTextBox.Text}','{emailTextBox.Text}','{generator.randomPassword(8).GetHashCode()}', '{telephoneTextBox.Text}','https://images.unsplash.com/photo-1499996860823-5214fcc65f8f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=466&q=80' ,'{genderComboBox.SelectedItem.ToString()}','{roleComboBox.SelectedItem.ToString()}')";

                //WriteLine(sqlStatement);

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show($"{this.surnameTextBox.Text} has been added successfully");


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
