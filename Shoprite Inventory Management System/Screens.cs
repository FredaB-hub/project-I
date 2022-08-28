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
    public partial class Screens : Form
    {

        const string connectionString = "Server = localhost; Database=fredadb;User id=root;Password=Freda@@2001";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        public Screens()
        {
            InitializeComponent();
        }

        private void catCancelBut(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void cancelProductButton(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void productButtonClick(object sender, EventArgs e)
        {
            Generators generator = new Generators();
            try
            {
                const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001;";
                MySqlConnection sqlConnection = new MySqlConnection(connectionString);
                sqlConnection.Open();
                string text = $"SELECT Product.*, Category.Category_Name FROM Product JOIN Category ON Category.Category_ID = Product.Category_ID;";
                string name = $"Select Category_ID, Category_Name FROM Category INNER JOIN Product ON Category.Category_ID = Product.Category_ID";
                string sqlStatement =
                    $"INSERT INTO `Product`(`Product_Name`, `Selling_Price`,`Product_Code`, `Cost_Price`, `Quantity`, `Category_ID`, `PTotal_Sell`, `PTotal_Cost`) VALUES ('{nametextBox.Text}', {pricetextBox.Text}, '{generator.randomProductcode(5)}', {distextBox.Text},{quantityTextBox.Text}, {catComboBox.SelectedIndex + 1}, {(Convert.ToInt32(this.pricetextBox.Text)) * (Convert.ToInt32(quantityTextBox))}, {(Convert.ToInt32(this.distextBox.Text)) * (Convert.ToInt32(quantityTextBox))})";

                System.Console.WriteLine(sqlStatement);

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show($"{this.nametextBox.Text} has been added successfully");
                nametextBox.Clear();
                pricetextBox.Clear();
                distextBox.Clear();
                quantityTextBox.Clear();
                Admin_Screen admin = new Admin_Screen();
                admin.productButton();



            }
            catch (Exception eb)
            {
                MessageBox.Show($"An error occured {eb.StackTrace}");
                throw;
            }
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void catComboBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.click();
            //catComboBox.Items.Clear();
        }
        private void catComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            String statement = $"SELECT Category_ID, Category_Name FROM Category ORDER BY Category_ID";
            MySqlCommand cmd = new MySqlCommand(statement, sqlConnection);
            reader = cmd.ExecuteReader();
            //catComboBox.Items.Clear();
            while (reader.Read())
            {
                
                //string name = reader.GetString(1);
                catComboBox.Items.Add(reader.GetValue(1).ToString());
                //catComboBox.Items.Add(name);
                
            }

        }

        public void click()
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            String statement = $"SELECT Category_ID, Category_Name FROM Category";
            MySqlCommand cmd = new MySqlCommand(statement, sqlConnection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(1);
                catComboBox.Items.Add(name);
                reader.GetValue(1).ToString();
                catComboBox.Items.Add(reader.GetValue(1).ToString());
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
