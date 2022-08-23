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
            this.Greeting = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.ListAll = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Greeting.Location = new System.Drawing.Point(115, 174);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(534, 86);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Have a great day!";
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(10, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 61);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ListAll
            // 
            this.ListAll.Location = new System.Drawing.Point(91, 9);
            this.ListAll.Name = "ListAll";
            this.ListAll.Size = new System.Drawing.Size(75, 61);
            this.ListAll.TabIndex = 2;
            this.ListAll.Text = "List All";
            this.ListAll.UseVisualStyleBackColor = true;
            this.ListAll.Click += new System.EventHandler(this.ListAll_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(172, 9);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 61);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListAll);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Greeting);
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
    }
}