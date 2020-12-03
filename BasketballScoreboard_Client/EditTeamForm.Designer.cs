namespace BasketballScoreboard_Client
{
    partial class EditTeamForm
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
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.playersList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerIdNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerIdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(50, 67);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(139, 23);
            this.addPlayerButton.TabIndex = 8;
            this.addPlayerButton.Text = "Přidat hráče";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Location = new System.Drawing.Point(12, 419);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(96, 23);
            this.removePlayerButton.TabIndex = 7;
            this.removePlayerButton.Text = "Odebrat hráče";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // playersList
            // 
            this.playersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name});
            this.playersList.HideSelection = false;
            this.playersList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.playersList.Location = new System.Drawing.Point(12, 141);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(204, 272);
            this.playersList.TabIndex = 6;
            this.playersList.UseCompatibleStateImageBehavior = false;
            this.playersList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Tag = "";
            this.id.Text = "Číslo";
            this.id.Width = 52;
            // 
            // name
            // 
            this.name.Text = "Jméno";
            this.name.Width = 146;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(12, 9);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(88, 16);
            this.teamNameLabel.TabIndex = 9;
            this.teamNameLabel.Text = "Název týmu";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(50, 42);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.playerNameTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerIdNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addPlayerButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.playerNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nový hráč";
            // 
            // playerIdNumeric
            // 
            this.playerIdNumeric.Location = new System.Drawing.Point(50, 17);
            this.playerIdNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.playerIdNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerIdNumeric.Name = "playerIdNumeric";
            this.playerIdNumeric.Size = new System.Drawing.Size(139, 20);
            this.playerIdNumeric.TabIndex = 13;
            this.playerIdNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jméno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Číslo";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(114, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Hotovo";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditTeamForm
            // 
            this.AcceptButton = this.addPlayerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 452);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.playersList);
            this.Name = "EditTeamForm";
            this.Text = "Upravit hráče";
            this.Load += new System.EventHandler(this.EditTeamForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerIdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.ListView playersList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown playerIdNumeric;
        private System.Windows.Forms.Button saveButton;
    }
}