namespace BasketballScoreboard_Server
{
    partial class MainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.serverStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clockLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPeriodLabel = new System.Windows.Forms.Label();
            this.teamANameLabel = new System.Windows.Forms.Label();
            this.teamBNameLabel = new System.Windows.Forms.Label();
            this.teamAPointsLabel = new System.Windows.Forms.Label();
            this.teamBPointsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teamAFoulsLabel = new System.Windows.Forms.Label();
            this.teamATimeoutsLeftLabel = new System.Windows.Forms.Label();
            this.teamBFoulsLabel = new System.Windows.Forms.Label();
            this.teamBTimeoutsLeftLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1268);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip.Size = new System.Drawing.Size(2528, 42);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(104, 32);
            this.serverStatusLabel.Text = "OFFLINE";
            // 
            // clockLabel
            // 
            this.clockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("DSEG7 Classic", 127.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(614, 35);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(1323, 341);
            this.clockLabel.TabIndex = 1;
            this.clockLabel.Text = "00:00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1046, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 108);
            this.label1.TabIndex = 2;
            this.label1.Text = "PERIODA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPeriodLabel
            // 
            this.currentPeriodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.currentPeriodLabel.AutoSize = true;
            this.currentPeriodLabel.Font = new System.Drawing.Font("DSEG7 Classic", 63.74999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPeriodLabel.Location = new System.Drawing.Point(1180, 619);
            this.currentPeriodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPeriodLabel.Name = "currentPeriodLabel";
            this.currentPeriodLabel.Size = new System.Drawing.Size(211, 170);
            this.currentPeriodLabel.TabIndex = 1;
            this.currentPeriodLabel.Text = "0";
            // 
            // teamANameLabel
            // 
            this.teamANameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamANameLabel.Location = new System.Drawing.Point(22, 487);
            this.teamANameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamANameLabel.Name = "teamANameLabel";
            this.teamANameLabel.Size = new System.Drawing.Size(1024, 133);
            this.teamANameLabel.TabIndex = 1;
            this.teamANameLabel.Text = "TEAM_A";
            this.teamANameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamBNameLabel
            // 
            this.teamBNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBNameLabel.Location = new System.Drawing.Point(1476, 487);
            this.teamBNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamBNameLabel.Name = "teamBNameLabel";
            this.teamBNameLabel.Size = new System.Drawing.Size(1024, 133);
            this.teamBNameLabel.TabIndex = 1;
            this.teamBNameLabel.Text = "TEAM_B";
            this.teamBNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamAPointsLabel
            // 
            this.teamAPointsLabel.Font = new System.Drawing.Font("DSEG7 Classic", 92.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAPointsLabel.Location = new System.Drawing.Point(22, 625);
            this.teamAPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamAPointsLabel.Name = "teamAPointsLabel";
            this.teamAPointsLabel.Size = new System.Drawing.Size(508, 271);
            this.teamAPointsLabel.TabIndex = 1;
            this.teamAPointsLabel.Text = "0";
            this.teamAPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamBPointsLabel
            // 
            this.teamBPointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBPointsLabel.Font = new System.Drawing.Font("DSEG7 Classic", 92.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBPointsLabel.Location = new System.Drawing.Point(1998, 625);
            this.teamBPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamBPointsLabel.Name = "teamBPointsLabel";
            this.teamBPointsLabel.Size = new System.Drawing.Size(508, 271);
            this.teamBPointsLabel.TabIndex = 1;
            this.teamBPointsLabel.Text = "0";
            this.teamBPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1152, 952);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 79);
            this.label4.TabIndex = 1;
            this.label4.Text = "FOULY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(906, 1060);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(770, 79);
            this.label5.TabIndex = 1;
            this.label5.Text = "ZBÝVAJÍCÍ TIMEOUTY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamAFoulsLabel
            // 
            this.teamAFoulsLabel.AutoSize = true;
            this.teamAFoulsLabel.Font = new System.Drawing.Font("DSEG7 Classic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAFoulsLabel.Location = new System.Drawing.Point(742, 952);
            this.teamAFoulsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamAFoulsLabel.Name = "teamAFoulsLabel";
            this.teamAFoulsLabel.Size = new System.Drawing.Size(87, 70);
            this.teamAFoulsLabel.TabIndex = 1;
            this.teamAFoulsLabel.Text = "0";
            // 
            // teamATimeoutsLeftLabel
            // 
            this.teamATimeoutsLeftLabel.AutoSize = true;
            this.teamATimeoutsLeftLabel.Font = new System.Drawing.Font("DSEG7 Classic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamATimeoutsLeftLabel.Location = new System.Drawing.Point(742, 1054);
            this.teamATimeoutsLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamATimeoutsLeftLabel.Name = "teamATimeoutsLeftLabel";
            this.teamATimeoutsLeftLabel.Size = new System.Drawing.Size(87, 70);
            this.teamATimeoutsLeftLabel.TabIndex = 1;
            this.teamATimeoutsLeftLabel.Text = "0";
            // 
            // teamBFoulsLabel
            // 
            this.teamBFoulsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBFoulsLabel.AutoSize = true;
            this.teamBFoulsLabel.Font = new System.Drawing.Font("DSEG7 Classic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBFoulsLabel.Location = new System.Drawing.Point(1724, 952);
            this.teamBFoulsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamBFoulsLabel.Name = "teamBFoulsLabel";
            this.teamBFoulsLabel.Size = new System.Drawing.Size(87, 70);
            this.teamBFoulsLabel.TabIndex = 1;
            this.teamBFoulsLabel.Text = "0";
            // 
            // teamBTimeoutsLeftLabel
            // 
            this.teamBTimeoutsLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBTimeoutsLeftLabel.AutoSize = true;
            this.teamBTimeoutsLeftLabel.Font = new System.Drawing.Font("DSEG7 Classic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBTimeoutsLeftLabel.Location = new System.Drawing.Point(1724, 1054);
            this.teamBTimeoutsLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamBTimeoutsLeftLabel.Name = "teamBTimeoutsLeftLabel";
            this.teamBTimeoutsLeftLabel.Size = new System.Drawing.Size(87, 70);
            this.teamBTimeoutsLeftLabel.TabIndex = 1;
            this.teamBTimeoutsLeftLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2528, 1310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamBPointsLabel);
            this.Controls.Add(this.teamAPointsLabel);
            this.Controls.Add(this.teamBTimeoutsLeftLabel);
            this.Controls.Add(this.teamBFoulsLabel);
            this.Controls.Add(this.teamATimeoutsLeftLabel);
            this.Controls.Add(this.teamAFoulsLabel);
            this.Controls.Add(this.currentPeriodLabel);
            this.Controls.Add(this.teamBNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamANameLabel);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(2534, 1319);
            this.Name = "MainForm";
            this.Text = "BSs - Panel";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel serverStatusLabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPeriodLabel;
        private System.Windows.Forms.Label teamANameLabel;
        private System.Windows.Forms.Label teamBNameLabel;
        private System.Windows.Forms.Label teamAPointsLabel;
        private System.Windows.Forms.Label teamBPointsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label teamAFoulsLabel;
        private System.Windows.Forms.Label teamATimeoutsLeftLabel;
        private System.Windows.Forms.Label teamBFoulsLabel;
        private System.Windows.Forms.Label teamBTimeoutsLeftLabel;
    }
}

