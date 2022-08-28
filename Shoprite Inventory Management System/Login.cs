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
    public partial class Login : Form
    {
        MySqlDataReader reader;
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            String statement = $"SELECT Role FROM User";
            MySqlCommand cmd = new MySqlCommand(statement, sqlConnection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                roleComboBox.Items.Add(name);
            }
        }

        private void loginButton(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);

            if (userTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
            {
                sqlConnection.Open();
                string statement = $"SELECT * FROM User WHERE Username = '"+ userTextBox.Text +"' and Password = '"+ passwordTextBox.Text+"' and Role = '"+roleComboBox.SelectedItem+"'";
                MySqlCommand command = new MySqlCommand(statement, sqlConnection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (roleComboBox.SelectedItem.ToString() == "Admin")
                    {
                        Admin_Screen admin = new Admin_Screen();
                        admin.Show();
                    }
                    else if (roleComboBox.SelectedItem.ToString() == "Attendant")
                    {
                        Attendant_Screen attendant = new Attendant_Screen();
                        attendant.Show();
                    }
                    else
                    {
                        MessageBox.Show("Can't Authorise access");
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No Account avilable with this username, password and role ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
