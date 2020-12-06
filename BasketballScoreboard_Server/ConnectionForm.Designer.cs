namespace BasketballScoreboard_Server
{
    partial class ConnectionForm
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
            this.ipListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipListBox
            // 
            this.ipListBox.FormattingEnabled = true;
            this.ipListBox.ItemHeight = 25;
            this.ipListBox.Location = new System.Drawing.Point(18, 35);
            this.ipListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipListBox.Name = "ipListBox";
            this.ipListBox.Size = new System.Drawing.Size(272, 179);
            this.ipListBox.TabIndex = 0;
            this.ipListBox.SelectedIndexChanged += new System.EventHandler(this.ipListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vyberte IPv4 adresu serveru:";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(18, 227);
            this.startButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(276, 44);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Spustit server";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 281);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.Text = "BSs - Spuštění serveru";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ipListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
    }
}