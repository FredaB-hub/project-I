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
    public partial class Admin_Screen : Form
    {
        const string connectionString = "Server = localhost; Database=fredadb;User id=root;Password=Freda@@2001";
       
        MySqlDataReader reader;

        public Admin_Screen()
        {
            InitializeComponent();
        }


        
        
            private void letproductButton()
            {
            accountDataGridView.AllowUserToAddRows = false;
            accountDataGridView.Columns.Clear();

            //Adding Columns to Grid
            DataGridViewTextBoxColumn userid = new DataGridViewTextBoxColumn();
            userid.Name = "User_ID";
            userid.HeaderText = "User_ID";
            userid.DataPropertyName = "User_ID";
            userid.Width =100;
            accountDataGridView.Columns.Insert(0, userid);

            
            
            DataGridViewTextBoxColumn surname = new DataGridViewTextBoxColumn();
            surname.Name = "Surname";
            surname.HeaderText = "Surname";
            surname.DataPropertyName = "Surname";
            surname.Width =100;
            accountDataGridView.Columns.Insert(1, surname);

            
            
            DataGridViewTextBoxColumn othername = new DataGridViewTextBoxColumn();
            othername.Name = "Othername";
            othername.HeaderText = "Othername";
            othername.DataPropertyName = "Othername";
            othername.Width =100;
            accountDataGridView.Columns.Insert(2, othername);

            

            //Adding Columns to Grid
            DataGridViewTextBoxColumn username = new DataGridViewTextBoxColumn();
            username.Name = "Username";
            username.HeaderText = "Username";
            username.DataPropertyName = "Username";
            username.Width =100;
            accountDataGridView.Columns.Insert(3, username);


            //Adding Columns to Grid
            DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
            email.Name = "Email";
            email.HeaderText = "Email";
            email.DataPropertyName = "Email";
            email.Width =100;
            accountDataGridView.Columns.Insert(4, email);


            //Adding Columns to Grid
            DataGridViewTextBoxColumn phone = new DataGridViewTextBoxColumn();
            phone.Name = "PhoneNumber";
            phone.HeaderText = "PhoneNumber";
            phone.DataPropertyName = "PhoneNumber";
            phone.Width =100;
            accountDataGridView.Columns.Insert(5, phone);

            //Adding Columns to Grid
            DataGridViewTextBoxColumn gender = new DataGridViewTextBoxColumn();
            gender.Name = "Gender";
            gender.HeaderText = "Gender";
            gender.DataPropertyName = "Gender";
            gender.Width =100;
            accountDataGridView.Columns.Insert(6, gender);


            //Adding Columns to Grid
            DataGridViewTextBoxColumn role = new DataGridViewTextBoxColumn();
            role.Name = "Role";
            role.HeaderText = "Role";
            role.DataPropertyName = "Role";
            role.Width =100;
            accountDataGridView.Columns.Insert(7, role);


            //Bind the DataGridView.
            accountDataGridView.DataSource = null;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT User_ID, Surname, Othername, Username, Email , PhoneNumber,  Gender, Role FROM User", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            accountDataGridView.DataSource = dt;
                        }
                    }
                }
            }

            //Add the Button Column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Delete";
            buttonColumn.Width = 60;
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
            accountDataGridView.Columns.Insert(8, buttonColumn);


            //Add the Button Column.
            DataGridViewButtonColumn updatebuttonColumn = new DataGridViewButtonColumn();
            updatebuttonColumn.HeaderText = "Update";
            updatebuttonColumn.Width = 60;
            updatebuttonColumn.Name = "updatebuttonColumn";
            updatebuttonColumn.Text = "update";
            updatebuttonColumn.UseColumnTextForButtonValue = true;
            accountDataGridView.Columns.Insert(9, updatebuttonColumn);




        }





       

        //private void form()
        //{
        //    this.letproductButton();
        //}

        private void FormLoad(object sender, EventArgs e)
        {
            this.myBindGrid();
        }

        private void myBindGrid()
        {
            productDataGridView.AllowUserToAddRows = false;
            productDataGridView.Columns.Clear();

            //Adding Columns to Grid
            DataGridViewTextBoxColumn productid = new DataGridViewTextBoxColumn();
            productid.Name = "Product_ID";
            productid.HeaderText = "Product_ID";
            productid.DataPropertyName = "Product_ID";
            productid.Width =100;
            productDataGridView.Columns.Insert(0, productid);


            DataGridViewTextBoxColumn productname = new DataGridViewTextBoxColumn();
            productname.HeaderText = "Product_Name";
            productname.Name = "Product_Name";
            productname.DataPropertyName = "Product_Name";
            productname.Width = 100;
            productDataGridView.Columns.Insert(1, productname);

            DataGridViewTextBoxColumn categoryid = new DataGridViewTextBoxColumn();
            categoryid.HeaderText = "Category_ID";
            categoryid.Name = "Category_ID";
            categoryid.DataPropertyName = "Category_ID";
            categoryid.Width = 100;
            productDataGridView.Columns.Insert(2, categoryid);

            DataGridViewTextBoxColumn productprice = new DataGridViewTextBoxColumn();
            productprice.HeaderText = "Selling_Price";
            productprice.Name = "Selling_Price";
            productprice.DataPropertyName = "Selling_Price";
            productprice.Width = 100;
            productDataGridView.Columns.Insert(3, productprice);


            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            description.HeaderText = "Cost_Price";
            description.Name = "Cost_Price";
            description.DataPropertyName = "Cost_Price";
            description.Width = 100;
            description.CellTemplate = new DataGridViewTextBoxCell();
            productDataGridView.Columns.Insert(4, description);

            DataGridViewTextBoxColumn qunatity = new DataGridViewTextBoxColumn();
            qunatity.HeaderText = "Quantity";
            qunatity.Name = "Quantity";
            qunatity.DataPropertyName = "Quantity";
            qunatity.Width = 100;
            qunatity.CellTemplate = new DataGridViewTextBoxCell();
            productDataGridView.Columns.Insert(5, qunatity);


            DataGridViewTextBoxColumn productCode = new DataGridViewTextBoxColumn();
            productCode.HeaderText = "Product_Code";
            productCode.Name = "Product_Code";
            productCode.DataPropertyName = "Product_Code";
            productCode.Width = 100;
            productCode.CellTemplate = new DataGridViewTextBoxCell();
            productDataGridView.Columns.Insert(6, productCode);

            DataGridViewTextBoxColumn categoryname = new DataGridViewTextBoxColumn();
            categoryname.HeaderText= "PTotal_Sell";
            categoryname.Name = "PTotal_Sell";
            categoryname.DataPropertyName= "PTotal_Sell";
            categoryname.Width = 100;
            productDataGridView.Columns.Insert(7, categoryname);

            DataGridViewTextBoxColumn qunatity1 = new DataGridViewTextBoxColumn();
            qunatity1.HeaderText = "PTotal_Cost";
            qunatity1.Name = "PTotal_Cost";
            qunatity1.DataPropertyName = "PTotal_Cost";
            qunatity1.Width = 100;
            qunatity1.CellTemplate = new DataGridViewTextBoxCell();
            productDataGridView.Columns.Insert(8, qunatity1);


            //Bind the DataGridView.
            //SELECT Product.*, Category.Category_Name FROM Product JOIN Category ON Category.Category_ID = Product.Category_ID
            productDataGridView.DataSource = null;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PRODUCT;", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            productDataGridView.DataSource = dt;
                        }
                    }
                }
            }

            //Add the Button Column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Delete";
            buttonColumn.Width = 60;
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
            productDataGridView.Columns.Insert(9, buttonColumn);


            //Add the Button Column.
            DataGridViewButtonColumn updatebuttonColumn = new DataGridViewButtonColumn();
            updatebuttonColumn.HeaderText = "Update";
            updatebuttonColumn.Width = 60;
            updatebuttonColumn.Name = "updatebuttonColumn";
            updatebuttonColumn.Text = "update";
            updatebuttonColumn.UseColumnTextForButtonValue = true;
            productDataGridView.Columns.Insert(10,updatebuttonColumn);

        }

        private void BindGrid()
        {
            //Hide the last blank line.
            catDataGridView.AllowUserToAddRows = false;

            

            //Clear Columns.
            catDataGridView.Columns.Clear();


            //Add Columns.
            DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
            category.Name = "Category_ID";
            category.HeaderText = "Category_ID";
            category.DataPropertyName = "Category_ID";
            category.Width = 100;
            catDataGridView.Columns.Insert(0, category);

            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "Category_Name";
            name.Name = "Category_Name";
            name.DataPropertyName = "Category_Name";
            name.Width = 100;
            catDataGridView.Columns.Insert(1, name);

            DataGridViewTextBoxColumn country = new DataGridViewTextBoxColumn();
            country.Name = "Category_Code";
            country.HeaderText = "Category_Code";
            country.DataPropertyName = "Category_Code";
            country.Width = 100;
            catDataGridView.Columns.Insert(2, country);

            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            description.Name = "Description";
            description.HeaderText = "Description";
            description.DataPropertyName = "Description";
            description.Width = 100;
            catDataGridView.Columns.Insert(3, description);

            //Bind the DataGridView.
            catDataGridView.DataSource = null;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT Category_ID, Category_Name, Category_Code, Description FROM Category", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            //catDataGridView.ReadOnly = true;
                            catDataGridView.DataSource = dt;
                        }
                    }
                }
            }

            //Add the Button Column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Width = 60;
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Delete";
            buttonColumn.UseColumnTextForButtonValue = true;
            catDataGridView.Columns.Insert(4, buttonColumn);

            //Add the Button Column.
            DataGridViewButtonColumn updatebuttonColumn = new DataGridViewButtonColumn();
            updatebuttonColumn.HeaderText = "Update";
            updatebuttonColumn.Width = 60;
            updatebuttonColumn.Name = "updatebuttonColumn";
            updatebuttonColumn.Text = "Update";
            updatebuttonColumn.UseColumnTextForButtonValue = true;
            catDataGridView.Columns.Insert(5, updatebuttonColumn);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BindGrid();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

       

        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            categoryPanel.Show();
        }

       

        

        private void addCatButton(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.ShowDialog();
            //Generators generator = new Generators();
            //try
            //{
            //    const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001;";
            //    MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            //    sqlConnection.Open();

            //    string sqlStatement =
            //        $"INSERT INTO `Category`(`Category_Name`, `Description`,`Category_Code`) VALUES ('{catTextBox.Text}', '{catDisTextBox.Text}', '{generator.randomProductcode(5)}')";

            //    //WriteLine(sqlStatement);

            //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

            //    sqlCommand.ExecuteNonQuery();

            //    MessageBox.Show($"{this.catTextBox.Text} has been added successfully");


            //}
            //catch (Exception eb)
            //{
            //    MessageBox.Show($"An error occured {eb.StackTrace}");
            //    throw;
            //}
        }

        private void catcancelBut(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }      

        private void catButtonClick(object sender, EventArgs e)
        {
            categoryPanel.Enabled = true;
            categoryPanel.Visible= true;
            categoryPanel.BringToFront();
        }

        private void addProductButton(object sender, EventArgs e)
        {

            Screens screens = new Screens();
            screens.ShowDialog();

            //Generators generator = new Generators();
            //try
            //{
            //    const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001;";
            //    MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            //    sqlConnection.Open();

            //    string sqlStatement =
            //        $"INSERT INTO `Category`(`Category_Name`, `Description`,`Category_Code`) VALUES ('{catTextBox.Text}', '{catDisTextBox.Text}', '{generator.randomProductcode(5)}')";

            //    //WriteLine(sqlStatement);

            //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

            //    sqlCommand.ExecuteNonQuery();

            //    MessageBox.Show($"{this.catTextBox.Text} has been added successfully");


            //}
            //catch (Exception eb)
            //{
            //    MessageBox.Show($"An error occured {eb.StackTrace}");
            //    throw;
            //}
        }

        private void productButtonClick(object sender, EventArgs e)
        {
            productPanel.Enabled = true;
            productPanel.Visible = true;
            productPanel.BringToFront();
        }

        private void addAccountButton(object sender, EventArgs e)
        {
            AccountForm account = new AccountForm();
            account.ShowDialog();
            //Generators generator = new Generators();
            //try
            //{
            //    const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            //    MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            //    sqlConnection.Open();

            //    string sqlStatement =
            //        $"INSERT INTO `Category`(`Category_Name`, `Description`,`Category_Code`) VALUES ('{catTextBox.Text}', '{catDisTextBox.Text}', '{generator.randomProductcode(5)}')";

            //    //WriteLine(sqlStatement);

            //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

            //    sqlCommand.ExecuteNonQuery();

            //    MessageBox.Show($"{this.catTextBox.Text} has been added successfully");


            //}
            //catch (Exception eb)
            //{
            //    MessageBox.Show($"An error occured {eb.StackTrace}");
            //    throw;
            //}
        }

        private void accountButtonClick(object sender, EventArgs e)
        {
            accountPanel.Enabled = true;
            accountPanel.Visible = true;
            accountPanel.BringToFront();
        }

        private void productPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void catAddButton_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.ShowDialog();
        }

        private void accountbuttonClick(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
        }

        private void catbuttonClick(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.ShowDialog();
        }

        private void productButton(object sender, EventArgs e)
        {
            Screens screens = new Screens();
            screens.ShowDialog();
        }

        private void refreshButton(object sender, EventArgs e)
        {

        }

        public void refreshButtonClick(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            string statement = $"SELECT * FROM User";
            MySqlCommand command = new MySqlCommand(statement,sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            // DataSet dataSet = new DataSet();
            DataTable data = new DataTable();
            adapter.Fill(data);
            accountDataGridView.ReadOnly = true;
            accountDataGridView.DataSource = data;
            this.letproductButton();
            sqlConnection.Close();
        }

        private void categoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void catRefreshButton(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            //string statement = $"SELECT * FROM Category";
            //MySqlCommand command = new MySqlCommand(statement, sqlConnection);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataSet dataSet = new DataSet();
            //adapter.Fill(dataSet);
            //catDataGridView.ReadOnly = true;
            //catDataGridView.DataSource = dataSet.Tables[0];
            //sqlConnection.Close
            //


            string statement = $"SELECT * FROM Category";
            // MySqlCommand command = new MySqlCommand(statement, sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(statement, sqlConnection);
            // DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //catDataGridView.ReadOnly = true;
            catDataGridView.DataSource = dataTable;
        }

        public void cateButton()
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
           // sqlConnection.Open();

            string statement = $"SELECT * FROM Category";
           // MySqlCommand command = new MySqlCommand(statement, sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(statement,sqlConnection);
            // DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //catDataGridView.ReadOnly = true;
            catDataGridView.DataSource = dataTable;
          //  sqlConnection.Close();
        }

        //public void productRefreshButton(object sender, EventArgs e)
        //{
        //    const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
        //    MySqlConnection sqlConnection = new MySqlConnection(connectionString);
        //    sqlConnection.Open();

        //    string statement = $"SELECT * FROM Product";
        //    MySqlCommand command = new MySqlCommand(statement, sqlConnection);
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //    DataSet dataSet = new DataSet();
        //    adapter.Fill(dataSet);
        //    catDataGridView.ReadOnly = true;
        //    productDataGridView.DataSource = dataSet.Tables[0];
        //    sqlConnection.Close();
        //}

        public void productButton()
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            string statement = $"SELECT * FROM Product";
            MySqlCommand command = new MySqlCommand(statement, sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            productDataGridView.ReadOnly = true;
            productDataGridView.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void updateProdButton(object sender, EventArgs e)
        {

        }

        private void delProdButton(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001;";
            //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            string statement = $"DELETE FROM `Product`";

            productDataGridView.SelectedRows.Clear();
        }

        private void delAccountButton(object sender, EventArgs e)
        {
            accountDataGridView.SelectedRows.Clear();
        }

        private void updateAccButton(object sender, EventArgs e)
        {

        }

        private void updateCateButton(object sender, EventArgs e)
        {

        }

        private void deleteCateButton(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();
            CategoryForm category = new CategoryForm();
            string statement = $"DELETE FROM `Category` WHERE `Category_Name` = '"+catDataGridView.DataMember.Equals(category.catNameTextBox.Text)  +"'";
        }

        private void catDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            // sqlConnection.Open();
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = catDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete Category ID: {0}?", row.Cells["Category_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sqlConnection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM Category WHERE Category_ID = @Category_ID", sqlConnection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Category_ID", row.Cells["Category_ID"].Value);
                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }

                    this.BindGrid();
                }
            }




            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = catDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to Update Category ID: {0}?", row.Cells["Category_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sqlConnection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"UPDATE Category SET Category_Name =@Category_Name, Description=@Description WHERE Category_ID =@Category_ID", sqlConnection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Category_ID", row.Cells["Category_ID"].Value);
                            cmd.Parameters.AddWithValue("@Category_Name", row.Cells["Category_Name"].Value);
                            cmd.Parameters.AddWithValue("@Description", row.Cells["Description"].Value);
                            
                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }

                    this.BindGrid();
                }
            }



        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
           // sqlConnection.Open();
            if (e.ColumnIndex == 9)
            {
                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete Product ID: {0}?", row.Cells["Product_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sqlConnection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM Product WHERE Product_ID = @Product_ID", sqlConnection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Product_ID", row.Cells["Product_ID"].Value);
                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }

                    this.myBindGrid();
                }
            }

            
            if (e.ColumnIndex == 10)
            {
                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to Update Product ID: {0}?", row.Cells["Product_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sqlConnection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"UPDATE Product SET Product_Name =@Product_Name, Selling_Price=@Selling_Price," +
                            $"Cost_Price =@Cost_Price, Quantity=@Quantity WHERE Product_ID=@Product_ID", sqlConnection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Product_ID", row.Cells["Product_ID"].Value);
                            cmd.Parameters.AddWithValue("@Product_Name", row.Cells["Product_Name"].Value);
                            cmd.Parameters.AddWithValue("@Selling_Price", row.Cells["Selling_Price"].Value);
                            cmd.Parameters.AddWithValue("@Cost_Price", row.Cells["Cost_Price"].Value);
                            cmd.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }

                    this.myBindGrid();
                }
            }

        }

        private void accountPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accountDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            // sqlConnection.Open();
            if (e.ColumnIndex == 8)
            {
                DataGridViewRow row = accountDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete User ID: {0}?", row.Cells["User_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sqlConnection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM User WHERE User_ID = @User_ID", sqlConnection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@User_ID", row.Cells["User_ID"].Value);
                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }

                    this.letproductButton();
                }
            }


            if (e.ColumnIndex == 9)
            {
                DataGridViewRow row = accountDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to Update User ID: {0}?", row.Cells["User_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sqlConnection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"UPDATE User SET Surname =@Surname, Othername=@Othername," +
                            $"Username =@Username, Email=@Email ,PhoneNumber=@PhoneNumber, Gender=@Gender WHERE User_ID =@User_ID ", sqlConnection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@User_ID", row.Cells["User_ID"].Value);
                            cmd.Parameters.AddWithValue("@Surname", row.Cells["Surname"].Value);
                            cmd.Parameters.AddWithValue("@Othername", row.Cells["Othername"].Value);
                            cmd.Parameters.AddWithValue("@Username", row.Cells["Username"].Value);
                            cmd.Parameters.AddWithValue("@Email", row.Cells["Email"].Value);
                            cmd.Parameters.AddWithValue("@PhoneNumber", row.Cells["PhoneNumber"].Value);
                            cmd.Parameters.AddWithValue("@Gender", row.Cells["Gender"].Value);
                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }

                    this.letproductButton();
                }
            }
        }

        private void form(object sender, EventArgs e)
        {
            this.letproductButton();
        }

        private void productDataGridView_CellContentClick(object sender, MouseEventArgs e)
        {

        }

        private void productDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=fredadb;User id=root;Password=Freda@@2001";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            // sqlConnection.Open();
            if (e.ColumnIndex == 9)
            {
                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to Update Category ID: {0}?", row.Cells["Product_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sqlConnection)
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"UPDATE Product SET Product_Name =@Product_Name, Unit_Price=@Unit_Price," +
                            $"Discription =@Discription, Quantity=@Quantity ", sqlConnection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Product_ID", row.Cells["Product_ID"].Value);
                            cmd.Parameters.AddWithValue("@Product_Name", row.Cells["Product_Name"].Value);
                            cmd.Parameters.AddWithValue("@Unit_Price", row.Cells["Unit_Price"].Value);
                            cmd.Parameters.AddWithValue("@Discription", row.Cells["Quantity"].Value);
                            sqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }

                    this.myBindGrid();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashboardpanel.Enabled = true;
            dashboardpanel.Visible = true;
            dashboardpanel.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Do you want to logout"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                Admin_Screen admin = new Admin_Screen();
                admin.Hide();
               
                login.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true;
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Enabled = true;
            panel5.Visible = true;
            panel5.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CategoryForm  category = new CategoryForm();
            category.Show();
        }

        private void Admin_Screen_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AccountForm account = new AccountForm();
            account.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Screens screens = new Screens();
            screens.Show();
        }
    }
}
