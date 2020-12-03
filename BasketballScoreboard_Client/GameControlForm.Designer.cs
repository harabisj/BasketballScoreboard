namespace BasketballScoreboard_Client
{
    partial class GameControlForm
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
            this.clockLabel = new System.Windows.Forms.Label();
            this.teamAGroupBox = new System.Windows.Forms.GroupBox();
            this.teamBGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.periodNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(347, 9);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(108, 39);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "00:00";
            // 
            // teamAGroupBox
            // 
            this.teamAGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamAGroupBox.Location = new System.Drawing.Point(12, 49);
            this.teamAGroupBox.Name = "teamAGroupBox";
            this.teamAGroupBox.Size = new System.Drawing.Size(384, 321);
            this.teamAGroupBox.TabIndex = 1;
            this.teamAGroupBox.TabStop = false;
            this.teamAGroupBox.Text = "teamA";
            // 
            // teamBGroupBox
            // 
            this.teamBGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBGroupBox.Location = new System.Drawing.Point(404, 49);
            this.teamBGroupBox.Name = "teamBGroupBox";
            this.teamBGroupBox.Size = new System.Drawing.Size(384, 321);
            this.teamBGroupBox.TabIndex = 1;
            this.teamBGroupBox.TabStop = false;
            this.teamBGroupBox.Text = "teamB";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Čtvrtina:";
            // 
            // periodNumberLabel
            // 
            this.periodNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.periodNumberLabel.AutoSize = true;
            this.periodNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodNumberLabel.Location = new System.Drawing.Point(79, 18);
            this.periodNumberLabel.Name = "periodNumberLabel";
            this.periodNumberLabel.Size = new System.Drawing.Size(17, 18);
            this.periodNumberLabel.TabIndex = 0;
            this.periodNumberLabel.Text = "0";
            // 
            // GameControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.teamBGroupBox);
            this.Controls.Add(this.teamAGroupBox);
            this.Controls.Add(this.periodNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockLabel);
            this.Name = "GameControlForm";
            this.Text = "BasketballScoreboard";
            this.Load += new System.EventHandler(this.GameControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.GroupBox teamAGroupBox;
        private System.Windows.Forms.GroupBox teamBGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label periodNumberLabel;
    }
}