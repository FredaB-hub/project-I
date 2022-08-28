namespace Shoprite_Inventory_Management_System
{
    partial class Admin_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.catDataGridView = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.catAddButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).BeginInit();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 540);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(729, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.Location = new System.Drawing.Point(4, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "DashBoard";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(3, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Product";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.productButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(4, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Account";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.accountButtonClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(5, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(4, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sales";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.Lavender;
            this.categoryButton.Location = new System.Drawing.Point(3, 216);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(127, 45);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.catButtonClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Location = new System.Drawing.Point(139, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 141);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productPanel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.accountPanel);
            this.panel2.Controls.Add(this.dashboardpanel);
            this.panel2.Controls.Add(this.categoryPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(139, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 475);
            this.panel2.TabIndex = 3;
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.BackColor = System.Drawing.Color.White;
            this.dashboardpanel.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardpanel.Location = new System.Drawing.Point(2, 0);
            this.dashboardpanel.Name = "dashboardpanel";
            this.dashboardpanel.Size = new System.Drawing.Size(870, 448);
            this.dashboardpanel.TabIndex = 7;
            // 
            // categoryPanel
            // 
            this.categoryPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.categoryPanel.Controls.Add(this.button9);
            this.categoryPanel.Controls.Add(this.catDataGridView);
            this.categoryPanel.Controls.Add(this.button8);
            this.categoryPanel.Location = new System.Drawing.Point(2, 3);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(870, 448);
            this.categoryPanel.TabIndex = 6;
            this.categoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.categoryPanel_Paint);
            // 
            // catDataGridView
            // 
            this.catDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDataGridView.Location = new System.Drawing.Point(14, 47);
            this.catDataGridView.Name = "catDataGridView";
            this.catDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.catDataGridView.Size = new System.Drawing.Size(616, 205);
            this.catDataGridView.TabIndex = 5;
            this.catDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDataGridView_CellContentClick);
            this.catDataGridView.Click += new System.EventHandler(this.Form1_Load);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Add Category";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.catbuttonClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 448);
            this.panel4.TabIndex = 7;
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.productPanel.Controls.Add(this.label5);
            this.productPanel.Controls.Add(this.catAddButton);
            this.productPanel.Controls.Add(this.productDataGridView);
            this.productPanel.Location = new System.Drawing.Point(0, 3);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(870, 448);
            this.productPanel.TabIndex = 1;
            this.productPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(14, 47);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(858, 157);
            this.productDataGridView.TabIndex = 5;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            this.productDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productDataGridView_CellMouseClick);
            this.productDataGridView.Click += new System.EventHandler(this.FormLoad);
            this.productDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productDataGridView_CellContentClick);
            // 
            // catAddButton
            // 
            this.catAddButton.Location = new System.Drawing.Point(14, 14);
            this.catAddButton.Name = "catAddButton";
            this.catAddButton.Size = new System.Drawing.Size(137, 23);
            this.catAddButton.TabIndex = 4;
            this.catAddButton.Text = "Add Product";
            this.catAddButton.UseVisualStyleBackColor = true;
            this.catAddButton.Click += new System.EventHandler(this.productButton);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(1, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(871, 456);
            this.panel5.TabIndex = 6;
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.Honeydew;
            this.accountPanel.Controls.Add(this.button10);
            this.accountPanel.Controls.Add(this.button1);
            this.accountPanel.Controls.Add(this.accountDataGridView);
            this.accountPanel.Location = new System.Drawing.Point(2, 3);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(870, 448);
            this.accountPanel.TabIndex = 6;
            this.accountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accountPanel_Paint);
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Location = new System.Drawing.Point(14, 47);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.Size = new System.Drawing.Size(854, 195);
            this.accountDataGridView.TabIndex = 5;
            this.accountDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountDataGridView_CellContentClick);
            this.accountDataGridView.Click += new System.EventHandler(this.form);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.accountbuttonClick);
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "SHOPRITE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "INVENTORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "MANAGEMENT";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(524, 270);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Add Category";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(638, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Add Product";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(560, 289);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "Add Account";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Admin_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 546);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freda";
            this.Load += new System.EventHandler(this.Admin_Screen_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).EndInit();
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.accountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button catAddButton;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.DataGridView catDataGridView;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.Panel dashboardpanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button10;
    }
}

