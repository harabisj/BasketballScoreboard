namespace BasketballScoreboard_Client
{
    partial class GameInitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.periodLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.createGameButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teamANameTextBox = new System.Windows.Forms.TextBox();
            this.teamBNameTextBox = new System.Windows.Forms.TextBox();
            this.teamAPlayersButton = new System.Windows.Forms.Button();
            this.teamBPlayersButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.periodLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Délka čtvrtiny";
            // 
            // periodLengthNumeric
            // 
            this.periodLengthNumeric.Location = new System.Drawing.Point(94, 11);
            this.periodLengthNumeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.periodLengthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.periodLengthNumeric.Name = "periodLengthNumeric";
            this.periodLengthNumeric.Size = new System.Drawing.Size(67, 20);
            this.periodLengthNumeric.TabIndex = 1;
            this.periodLengthNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "minut";
            // 
            // createGameButton
            // 
            this.createGameButton.Location = new System.Drawing.Point(12, 136);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(229, 23);
            this.createGameButton.TabIndex = 3;
            this.createGameButton.Text = "Spustit hru";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.createGameButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Týmy:";
            // 
            // teamANameTextBox
            // 
            this.teamANameTextBox.Location = new System.Drawing.Point(13, 79);
            this.teamANameTextBox.Name = "teamANameTextBox";
            this.teamANameTextBox.Size = new System.Drawing.Size(148, 20);
            this.teamANameTextBox.TabIndex = 5;
            this.teamANameTextBox.TextChanged += new System.EventHandler(this.teamANameTextBox_TextChanged);
            // 
            // teamBNameTextBox
            // 
            this.teamBNameTextBox.Location = new System.Drawing.Point(13, 105);
            this.teamBNameTextBox.Name = "teamBNameTextBox";
            this.teamBNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.teamBNameTextBox.TabIndex = 6;
            this.teamBNameTextBox.TextChanged += new System.EventHandler(this.teamBNameTextBox_TextChanged);
            // 
            // teamAPlayersButton
            // 
            this.teamAPlayersButton.Location = new System.Drawing.Point(167, 78);
            this.teamAPlayersButton.Name = "teamAPlayersButton";
            this.teamAPlayersButton.Size = new System.Drawing.Size(75, 23);
            this.teamAPlayersButton.TabIndex = 7;
            this.teamAPlayersButton.Text = "Hráči";
            this.teamAPlayersButton.UseVisualStyleBackColor = true;
            this.teamAPlayersButton.Click += new System.EventHandler(this.teamAPlayersButton_Click);
            // 
            // teamBPlayersButton
            // 
            this.teamBPlayersButton.Location = new System.Drawing.Point(167, 104);
            this.teamBPlayersButton.Name = "teamBPlayersButton";
            this.teamBPlayersButton.Size = new System.Drawing.Size(75, 23);
            this.teamBPlayersButton.TabIndex = 8;
            this.teamBPlayersButton.Text = "Hráči";
            this.teamBPlayersButton.UseVisualStyleBackColor = true;
            this.teamBPlayersButton.Click += new System.EventHandler(this.teamBPlayersButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Počet timeoutů";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(94, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // GameInitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 166);
            this.Controls.Add(this.teamBPlayersButton);
            this.Controls.Add(this.teamAPlayersButton);
            this.Controls.Add(this.teamBNameTextBox);
            this.Controls.Add(this.teamANameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createGameButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.periodLengthNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GameInitForm";
            this.Text = "Nastavení hry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameInitForm_FormClosing);
            this.Load += new System.EventHandler(this.GameInitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown periodLengthNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamANameTextBox;
        private System.Windows.Forms.TextBox teamBNameTextBox;
        private System.Windows.Forms.Button teamAPlayersButton;
        private System.Windows.Forms.Button teamBPlayersButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

