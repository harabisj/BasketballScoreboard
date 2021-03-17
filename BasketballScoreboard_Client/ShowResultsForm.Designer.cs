namespace BasketballScoreboard_Client
{
    partial class ShowResultsForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Karel"}, -1);
            this.teamANameLabel = new System.Windows.Forms.Label();
            this.teamAPlayersList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fouls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamAScoreLabel = new System.Windows.Forms.Label();
            this.teamBPlayersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamBScoreLabel = new System.Windows.Forms.Label();
            this.teamBNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamANameLabel
            // 
            this.teamANameLabel.AutoSize = true;
            this.teamANameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamANameLabel.Location = new System.Drawing.Point(12, 9);
            this.teamANameLabel.Name = "teamANameLabel";
            this.teamANameLabel.Size = new System.Drawing.Size(103, 29);
            this.teamANameLabel.TabIndex = 0;
            this.teamANameLabel.Text = "Team A";
            // 
            // teamAPlayersList
            // 
            this.teamAPlayersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.fouls});
            this.teamAPlayersList.FullRowSelect = true;
            this.teamAPlayersList.HideSelection = false;
            this.teamAPlayersList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.teamAPlayersList.Location = new System.Drawing.Point(17, 51);
            this.teamAPlayersList.Margin = new System.Windows.Forms.Padding(6);
            this.teamAPlayersList.Name = "teamAPlayersList";
            this.teamAPlayersList.Size = new System.Drawing.Size(404, 519);
            this.teamAPlayersList.TabIndex = 8;
            this.teamAPlayersList.UseCompatibleStateImageBehavior = false;
            this.teamAPlayersList.View = System.Windows.Forms.View.Details;
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
            // teamAScoreLabel
            // 
            this.teamAScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAScoreLabel.Location = new System.Drawing.Point(272, 9);
            this.teamAScoreLabel.Name = "teamAScoreLabel";
            this.teamAScoreLabel.Size = new System.Drawing.Size(149, 36);
            this.teamAScoreLabel.TabIndex = 0;
            this.teamAScoreLabel.Text = "0";
            this.teamAScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.teamAScoreLabel.UseCompatibleTextRendering = true;
            // 
            // teamBPlayersList
            // 
            this.teamBPlayersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.teamBPlayersList.FullRowSelect = true;
            this.teamBPlayersList.HideSelection = false;
            this.teamBPlayersList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.teamBPlayersList.Location = new System.Drawing.Point(460, 54);
            this.teamBPlayersList.Margin = new System.Windows.Forms.Padding(6);
            this.teamBPlayersList.Name = "teamBPlayersList";
            this.teamBPlayersList.Size = new System.Drawing.Size(404, 519);
            this.teamBPlayersList.TabIndex = 11;
            this.teamBPlayersList.UseCompatibleStateImageBehavior = false;
            this.teamBPlayersList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Číslo";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jméno";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fauly";
            this.columnHeader3.Width = 58;
            // 
            // teamBScoreLabel
            // 
            this.teamBScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBScoreLabel.Location = new System.Drawing.Point(715, 12);
            this.teamBScoreLabel.Name = "teamBScoreLabel";
            this.teamBScoreLabel.Size = new System.Drawing.Size(149, 36);
            this.teamBScoreLabel.TabIndex = 9;
            this.teamBScoreLabel.Text = "0";
            this.teamBScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.teamBScoreLabel.UseCompatibleTextRendering = true;
            // 
            // teamBNameLabel
            // 
            this.teamBNameLabel.AutoSize = true;
            this.teamBNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBNameLabel.Location = new System.Drawing.Point(455, 12);
            this.teamBNameLabel.Name = "teamBNameLabel";
            this.teamBNameLabel.Size = new System.Drawing.Size(104, 29);
            this.teamBNameLabel.TabIndex = 10;
            this.teamBNameLabel.Text = "Team B";
            // 
            // ShowResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 585);
            this.Controls.Add(this.teamBPlayersList);
            this.Controls.Add(this.teamBScoreLabel);
            this.Controls.Add(this.teamBNameLabel);
            this.Controls.Add(this.teamAPlayersList);
            this.Controls.Add(this.teamAScoreLabel);
            this.Controls.Add(this.teamANameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowResultsForm";
            this.Text = "Výsledky hry";
            this.Load += new System.EventHandler(this.ShowResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamANameLabel;
        private System.Windows.Forms.ListView teamAPlayersList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader fouls;
        private System.Windows.Forms.Label teamAScoreLabel;
        private System.Windows.Forms.ListView teamBPlayersList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label teamBScoreLabel;
        private System.Windows.Forms.Label teamBNameLabel;
    }
}