namespace BrokerBuddy
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Greeting = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.ListAll = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.busNameBox = new System.Windows.Forms.TextBox();
            this.conNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Greeting.Location = new System.Drawing.Point(141, 300);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(534, 86);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Have a great day!";
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(12, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 61);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ListAll
            // 
            this.ListAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListAll.Location = new System.Drawing.Point(632, 9);
            this.ListAll.Name = "ListAll";
            this.ListAll.Size = new System.Drawing.Size(75, 61);
            this.ListAll.TabIndex = 2;
            this.ListAll.Text = "List All";
            this.ListAll.UseVisualStyleBackColor = true;
            this.ListAll.Click += new System.EventHandler(this.ListAll_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(713, 9);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 61);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // custNameBox
            // 
            this.custNameBox.Location = new System.Drawing.Point(12, 108);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(120, 23);
            this.custNameBox.TabIndex = 4;
            this.custNameBox.TextChanged += new System.EventHandler(this.custNameBox_TextChanged);
            // 
            // busNameBox
            // 
            this.busNameBox.Location = new System.Drawing.Point(12, 161);
            this.busNameBox.Name = "busNameBox";
            this.busNameBox.Size = new System.Drawing.Size(120, 23);
            this.busNameBox.TabIndex = 5;
            this.busNameBox.TextChanged += new System.EventHandler(this.busNameBox_TextChanged);
            // 
            // conNameBox
            // 
            this.conNameBox.Location = new System.Drawing.Point(12, 217);
            this.conNameBox.Name = "conNameBox";
            this.conNameBox.Size = new System.Drawing.Size(120, 23);
            this.conNameBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Business Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact Name";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conNameBox);
            this.Controls.Add(this.busNameBox);
            this.Controls.Add(this.custNameBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListAll);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Greeting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Broker Buddy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Label Greeting;
        private Button Search;
        private Button ListAll;
        private Button Add;
        private TextBox custNameBox;
        private TextBox busNameBox;
        private TextBox conNameBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}