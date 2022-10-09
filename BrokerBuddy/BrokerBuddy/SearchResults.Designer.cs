namespace BrokerBuddy
{
    partial class SearchResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResults));
            this.SearchResultView = new System.Windows.Forms.ListView();
            this.col_ID = new System.Windows.Forms.ColumnHeader();
            this.col_Name = new System.Windows.Forms.ColumnHeader();
            this.col_BusName = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // SearchResultView
            // 
            this.SearchResultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_Name,
            this.col_BusName});
            this.SearchResultView.FullRowSelect = true;
            this.SearchResultView.GridLines = true;
            this.SearchResultView.Location = new System.Drawing.Point(0, 0);
            this.SearchResultView.Name = "SearchResultView";
            this.SearchResultView.Size = new System.Drawing.Size(799, 449);
            this.SearchResultView.TabIndex = 0;
            this.SearchResultView.UseCompatibleStateImageBehavior = false;
            this.SearchResultView.View = System.Windows.Forms.View.Details;
            this.SearchResultView.Click += new System.EventHandler(this.SearchResultView_Click);
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            // 
            // col_Name
            // 
            this.col_Name.Text = "Name";
            this.col_Name.Width = 120;
            // 
            // col_BusName
            // 
            this.col_BusName.Text = "Business Name";
            this.col_BusName.Width = 120;
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchResultView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchResults";
            this.Text = "Search Results";
            this.ResumeLayout(false);

        }

        #endregion

        public ListView SearchResultView;
        private ColumnHeader col_ID;
        private ColumnHeader col_Name;
        private ColumnHeader col_BusName;
    }
}