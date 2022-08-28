namespace Shoprite_Inventory_Management_System
{
    partial class Attendant_Screen
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
            this.productPanel = new System.Windows.Forms.Panel();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.catAddButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.catDataGridView = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(139, 540);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(743, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 43);
            this.button7.TabIndex = 7;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "DashBoard";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Product";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Account";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sales";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(4, 201);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(125, 42);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(139, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 105);
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
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productPanel.Controls.Add(this.productDataGridView);
            this.productPanel.Controls.Add(this.catAddButton);
            this.productPanel.Location = new System.Drawing.Point(0, 3);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(870, 448);
            this.productPanel.TabIndex = 1;
            this.productPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(2, 0);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(858, 157);
            this.productDataGridView.TabIndex = 5;
            // 
            // catAddButton
            // 
            this.catAddButton.BackColor = System.Drawing.Color.Lavender;
            this.catAddButton.Location = new System.Drawing.Point(603, 176);
            this.catAddButton.Name = "catAddButton";
            this.catAddButton.Size = new System.Drawing.Size(158, 34);
            this.catAddButton.TabIndex = 4;
            this.catAddButton.Text = "Add Product";
            this.catAddButton.UseVisualStyleBackColor = false;
            this.catAddButton.Click += new System.EventHandler(this.catAddButton_Click);
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
            this.accountPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.accountPanel.Controls.Add(this.accountDataGridView);
            this.accountPanel.Controls.Add(this.button1);
            this.accountPanel.Location = new System.Drawing.Point(2, 3);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(870, 448);
            this.accountPanel.TabIndex = 6;
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Location = new System.Drawing.Point(14, 47);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.Size = new System.Drawing.Size(854, 195);
            this.accountDataGridView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.BackColor = System.Drawing.Color.White;
            this.dashboardpanel.Location = new System.Drawing.Point(2, 0);
            this.dashboardpanel.Name = "dashboardpanel";
            this.dashboardpanel.Size = new System.Drawing.Size(870, 448);
            this.dashboardpanel.TabIndex = 7;
            // 
            // categoryPanel
            // 
            this.categoryPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.categoryPanel.Controls.Add(this.catDataGridView);
            this.categoryPanel.Controls.Add(this.button8);
            this.categoryPanel.Location = new System.Drawing.Point(2, 3);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(870, 448);
            this.categoryPanel.TabIndex = 6;
            // 
            // catDataGridView
            // 
            this.catDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDataGridView.Location = new System.Drawing.Point(14, 47);
            this.catDataGridView.Name = "catDataGridView";
            this.catDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.catDataGridView.Size = new System.Drawing.Size(616, 205);
            this.catDataGridView.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Add Category";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 448);
            this.panel4.TabIndex = 7;
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
            this.label1.Location = new System.Drawing.Point(281, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHOPRITE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "INVENTORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "MANAGEMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "SYSTEM";
            // 
            // Attendant_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Attendant_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freda";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.accountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}