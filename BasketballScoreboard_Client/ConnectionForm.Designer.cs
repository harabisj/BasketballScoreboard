namespace BasketballScoreboard_Client
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
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(15, 25);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IPv4 serveru";
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(15, 50);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Připojit se";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 85);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
    }
}