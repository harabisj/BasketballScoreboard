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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInitForm));
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
            this.defaultTimeoutsNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.periodLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultTimeoutsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Délka čtvrtiny";
            // 
            // periodLengthNumeric
            // 
            this.periodLengthNumeric.Location = new System.Drawing.Point(188, 21);
            this.periodLengthNumeric.Margin = new System.Windows.Forms.Padding(6);
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
            this.periodLengthNumeric.Size = new System.Drawing.Size(134, 31);
            this.periodLengthNumeric.TabIndex = 1;
            this.periodLengthNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.periodLengthNumeric.ValueChanged += new System.EventHandler(this.periodLengthNumeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "minut";
            // 
            // createGameButton
            // 
            this.createGameButton.Location = new System.Drawing.Point(24, 262);
            this.createGameButton.Margin = new System.Windows.Forms.Padding(6);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(458, 44);
            this.createGameButton.TabIndex = 3;
            this.createGameButton.Text = "Spustit hru";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.createGameButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Týmy:";
            // 
            // teamANameTextBox
            // 
            this.teamANameTextBox.Location = new System.Drawing.Point(26, 152);
            this.teamANameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.teamANameTextBox.Name = "teamANameTextBox";
            this.teamANameTextBox.Size = new System.Drawing.Size(292, 31);
            this.teamANameTextBox.TabIndex = 5;
            this.teamANameTextBox.TextChanged += new System.EventHandler(this.teamANameTextBox_TextChanged);
            // 
            // teamBNameTextBox
            // 
            this.teamBNameTextBox.Location = new System.Drawing.Point(26, 202);
            this.teamBNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.teamBNameTextBox.Name = "teamBNameTextBox";
            this.teamBNameTextBox.Size = new System.Drawing.Size(292, 31);
            this.teamBNameTextBox.TabIndex = 6;
            this.teamBNameTextBox.TextChanged += new System.EventHandler(this.teamBNameTextBox_TextChanged);
            // 
            // teamAPlayersButton
            // 
            this.teamAPlayersButton.Location = new System.Drawing.Point(334, 150);
            this.teamAPlayersButton.Margin = new System.Windows.Forms.Padding(6);
            this.teamAPlayersButton.Name = "teamAPlayersButton";
            this.teamAPlayersButton.Size = new System.Drawing.Size(150, 44);
            this.teamAPlayersButton.TabIndex = 7;
            this.teamAPlayersButton.Text = "Hráči";
            this.teamAPlayersButton.UseVisualStyleBackColor = true;
            this.teamAPlayersButton.Click += new System.EventHandler(this.teamAPlayersButton_Click);
            // 
            // teamBPlayersButton
            // 
            this.teamBPlayersButton.Location = new System.Drawing.Point(334, 200);
            this.teamBPlayersButton.Margin = new System.Windows.Forms.Padding(6);
            this.teamBPlayersButton.Name = "teamBPlayersButton";
            this.teamBPlayersButton.Size = new System.Drawing.Size(150, 44);
            this.teamBPlayersButton.TabIndex = 8;
            this.teamBPlayersButton.Text = "Hráči";
            this.teamBPlayersButton.UseVisualStyleBackColor = true;
            this.teamBPlayersButton.Click += new System.EventHandler(this.teamBPlayersButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Počet timeoutů";
            // 
            // defaultTimeoutsNumeric
            // 
            this.defaultTimeoutsNumeric.Location = new System.Drawing.Point(188, 69);
            this.defaultTimeoutsNumeric.Margin = new System.Windows.Forms.Padding(6);
            this.defaultTimeoutsNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.defaultTimeoutsNumeric.Name = "defaultTimeoutsNumeric";
            this.defaultTimeoutsNumeric.Size = new System.Drawing.Size(134, 31);
            this.defaultTimeoutsNumeric.TabIndex = 1;
            this.defaultTimeoutsNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.defaultTimeoutsNumeric.ValueChanged += new System.EventHandler(this.defaultTimeoutsNumeric_ValueChanged);
            // 
            // GameInitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 319);
            this.Controls.Add(this.teamBPlayersButton);
            this.Controls.Add(this.teamAPlayersButton);
            this.Controls.Add(this.teamBNameTextBox);
            this.Controls.Add(this.teamANameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createGameButton);
            this.Controls.Add(this.defaultTimeoutsNumeric);
            this.Controls.Add(this.periodLengthNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameInitForm";
            this.Text = "BSc - Nastavení hry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameInitForm_FormClosing);
            this.Load += new System.EventHandler(this.GameInitForm_Load);
            this.Shown += new System.EventHandler(this.GameInitForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.periodLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultTimeoutsNumeric)).EndInit();
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
        private System.Windows.Forms.NumericUpDown defaultTimeoutsNumeric;
    }
}

