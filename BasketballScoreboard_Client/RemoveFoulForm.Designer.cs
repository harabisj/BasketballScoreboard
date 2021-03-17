namespace BasketballScoreboard_Client
{
    partial class RemoveFoulForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Karel"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveFoulForm));
            this.playersList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fouls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addFoulButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playersList
            // 
            this.playersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.fouls});
            this.playersList.FullRowSelect = true;
            this.playersList.HideSelection = false;
            this.playersList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.playersList.Location = new System.Drawing.Point(16, 15);
            this.playersList.Margin = new System.Windows.Forms.Padding(6);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(404, 519);
            this.playersList.TabIndex = 7;
            this.playersList.UseCompatibleStateImageBehavior = false;
            this.playersList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Tag = "";
            this.id.Text = "Číslo";
            this.id.Width = 42;
            // 
            // name
            // 
            this.name.Text = "Jméno";
            this.name.Width = 106;
            // 
            // fouls
            // 
            this.fouls.Text = "Fauly";
            this.fouls.Width = 58;
            // 
            // addFoulButton
            // 
            this.addFoulButton.Location = new System.Drawing.Point(15, 545);
            this.addFoulButton.Name = "addFoulButton";
            this.addFoulButton.Size = new System.Drawing.Size(404, 43);
            this.addFoulButton.TabIndex = 8;
            this.addFoulButton.Text = "Odebrat faul";
            this.addFoulButton.UseVisualStyleBackColor = true;
            this.addFoulButton.Click += new System.EventHandler(this.removeFoulButton_Click);
            // 
            // RemoveFoulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 600);
            this.Controls.Add(this.addFoulButton);
            this.Controls.Add(this.playersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveFoulForm";
            this.Text = "BSc - Odebrat faul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView playersList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader fouls;
        private System.Windows.Forms.Button addFoulButton;
    }
}