namespace BrokerBuddy
{
    public partial class MainWindow
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
            this.conFirstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.conLastNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.busLocationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Greeting.Location = new System.Drawing.Point(187, 329);
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
            this.Search.Size = new System.Drawing.Size(120, 61);
            this.Search.TabIndex = 6;
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
            this.ListAll.TabIndex = 7;
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
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // custNameBox
            // 
            this.custNameBox.Location = new System.Drawing.Point(12, 108);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(120, 23);
            this.custNameBox.TabIndex = 1;
            this.custNameBox.TextChanged += new System.EventHandler(this.custNameBox_TextChanged);
            this.custNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custNameBox_KeyDown);
            // 
            // busNameBox
            // 
            this.busNameBox.Location = new System.Drawing.Point(12, 161);
            this.busNameBox.Name = "busNameBox";
            this.busNameBox.Size = new System.Drawing.Size(120, 23);
            this.busNameBox.TabIndex = 2;
            this.busNameBox.TextChanged += new System.EventHandler(this.busNameBox_TextChanged);
            this.busNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.busNameBox_KeyDown);
            // 
            // conFirstNameBox
            // 
            this.conFirstNameBox.Location = new System.Drawing.Point(12, 217);
            this.conFirstNameBox.Name = "conFirstNameBox";
            this.conFirstNameBox.Size = new System.Drawing.Size(120, 23);
            this.conFirstNameBox.TabIndex = 3;
            this.conFirstNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.conFirstNameBox_KeyDown);
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
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact First Name";
            // 
            // conLastNameBox
            // 
            this.conLastNameBox.Location = new System.Drawing.Point(12, 273);
            this.conLastNameBox.Name = "conLastNameBox";
            this.conLastNameBox.Size = new System.Drawing.Size(120, 23);
            this.conLastNameBox.TabIndex = 4;
            this.conLastNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.conLastNameBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact Last Name";
            // 
            // busLocationBox
            // 
            this.busLocationBox.Location = new System.Drawing.Point(12, 329);
            this.busLocationBox.Name = "busLocationBox";
            this.busLocationBox.Size = new System.Drawing.Size(120, 23);
            this.busLocationBox.TabIndex = 5;
            this.busLocationBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.busLocationBox_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Location";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.busLocationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conLastNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conFirstNameBox);
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
        private TextBox conFirstNameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox conLastNameBox;
        private Label label4;
        private TextBox busLocationBox;
        private Label label5;
    }
}