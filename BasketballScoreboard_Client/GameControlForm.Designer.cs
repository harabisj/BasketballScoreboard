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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameControlForm));
            this.clockLabel = new System.Windows.Forms.Label();
            this.teamAGroupBox = new System.Windows.Forms.GroupBox();
            this.scoreAAdd3Button = new System.Windows.Forms.Button();
            this.timeoutsAAdd1Button = new System.Windows.Forms.Button();
            this.foulsAAdd1Button = new System.Windows.Forms.Button();
            this.scoreAAdd2Button = new System.Windows.Forms.Button();
            this.timeoutsASub1Button = new System.Windows.Forms.Button();
            this.foulsASub1Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.scoreAAdd1Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teamATimeoutsLabel = new System.Windows.Forms.Label();
            this.scoreASub1Button = new System.Windows.Forms.Button();
            this.teamAFoulsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamAPointsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.periodNumberLabel = new System.Windows.Forms.Label();
            this.teamBGroupBox = new System.Windows.Forms.GroupBox();
            this.scoreBAdd3Button = new System.Windows.Forms.Button();
            this.timeoutsBAdd1Button = new System.Windows.Forms.Button();
            this.foulsBAdd1Button = new System.Windows.Forms.Button();
            this.scoreBAdd2Button = new System.Windows.Forms.Button();
            this.timeoutsBSub1Button = new System.Windows.Forms.Button();
            this.foulsBSub1Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.scoreBAdd1Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.teamBTimeoutsLabel = new System.Windows.Forms.Label();
            this.scoreBSub1Button = new System.Windows.Forms.Button();
            this.teamBFoulsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.teamBPointsLabel = new System.Windows.Forms.Label();
            this.clockStartButton = new System.Windows.Forms.Button();
            this.clockStopButton = new System.Windows.Forms.Button();
            this.runTimeoutButton = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.periodSub1Button = new System.Windows.Forms.Button();
            this.periodAdd1Button = new System.Windows.Forms.Button();
            this.timeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.showResultsButton = new System.Windows.Forms.Button();
            this.teamAGroupBox.SuspendLayout();
            this.teamBGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(694, 17);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(214, 79);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "00:00";
            // 
            // teamAGroupBox
            // 
            this.teamAGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamAGroupBox.Controls.Add(this.scoreAAdd3Button);
            this.teamAGroupBox.Controls.Add(this.timeoutsAAdd1Button);
            this.teamAGroupBox.Controls.Add(this.foulsAAdd1Button);
            this.teamAGroupBox.Controls.Add(this.scoreAAdd2Button);
            this.teamAGroupBox.Controls.Add(this.timeoutsASub1Button);
            this.teamAGroupBox.Controls.Add(this.foulsASub1Button);
            this.teamAGroupBox.Controls.Add(this.label6);
            this.teamAGroupBox.Controls.Add(this.scoreAAdd1Button);
            this.teamAGroupBox.Controls.Add(this.label4);
            this.teamAGroupBox.Controls.Add(this.teamATimeoutsLabel);
            this.teamAGroupBox.Controls.Add(this.scoreASub1Button);
            this.teamAGroupBox.Controls.Add(this.teamAFoulsLabel);
            this.teamAGroupBox.Controls.Add(this.label2);
            this.teamAGroupBox.Controls.Add(this.teamAPointsLabel);
            this.teamAGroupBox.Location = new System.Drawing.Point(24, 94);
            this.teamAGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.teamAGroupBox.Name = "teamAGroupBox";
            this.teamAGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.teamAGroupBox.Size = new System.Drawing.Size(768, 208);
            this.teamAGroupBox.TabIndex = 1;
            this.teamAGroupBox.TabStop = false;
            this.teamAGroupBox.Text = "teamA";
            // 
            // scoreAAdd3Button
            // 
            this.scoreAAdd3Button.Location = new System.Drawing.Point(608, 37);
            this.scoreAAdd3Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreAAdd3Button.Name = "scoreAAdd3Button";
            this.scoreAAdd3Button.Size = new System.Drawing.Size(108, 44);
            this.scoreAAdd3Button.TabIndex = 1;
            this.scoreAAdd3Button.Text = "+3";
            this.scoreAAdd3Button.UseVisualStyleBackColor = true;
            this.scoreAAdd3Button.Click += new System.EventHandler(this.scoreAAdd3Button_Click);
            // 
            // timeoutsAAdd1Button
            // 
            this.timeoutsAAdd1Button.Location = new System.Drawing.Point(488, 148);
            this.timeoutsAAdd1Button.Margin = new System.Windows.Forms.Padding(6);
            this.timeoutsAAdd1Button.Name = "timeoutsAAdd1Button";
            this.timeoutsAAdd1Button.Size = new System.Drawing.Size(228, 44);
            this.timeoutsAAdd1Button.TabIndex = 1;
            this.timeoutsAAdd1Button.Text = "+1";
            this.timeoutsAAdd1Button.UseVisualStyleBackColor = true;
            this.timeoutsAAdd1Button.Click += new System.EventHandler(this.timeoutsAAdd1Button_Click);
            // 
            // foulsAAdd1Button
            // 
            this.foulsAAdd1Button.Location = new System.Drawing.Point(488, 92);
            this.foulsAAdd1Button.Margin = new System.Windows.Forms.Padding(6);
            this.foulsAAdd1Button.Name = "foulsAAdd1Button";
            this.foulsAAdd1Button.Size = new System.Drawing.Size(228, 44);
            this.foulsAAdd1Button.TabIndex = 1;
            this.foulsAAdd1Button.Text = "+1";
            this.foulsAAdd1Button.UseVisualStyleBackColor = true;
            this.foulsAAdd1Button.Click += new System.EventHandler(this.foulsAAdd1Button_Click);
            // 
            // scoreAAdd2Button
            // 
            this.scoreAAdd2Button.Location = new System.Drawing.Point(488, 37);
            this.scoreAAdd2Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreAAdd2Button.Name = "scoreAAdd2Button";
            this.scoreAAdd2Button.Size = new System.Drawing.Size(108, 44);
            this.scoreAAdd2Button.TabIndex = 1;
            this.scoreAAdd2Button.Text = "+2";
            this.scoreAAdd2Button.UseVisualStyleBackColor = true;
            this.scoreAAdd2Button.Click += new System.EventHandler(this.scoreAAdd2Button_Click);
            // 
            // timeoutsASub1Button
            // 
            this.timeoutsASub1Button.Location = new System.Drawing.Point(248, 148);
            this.timeoutsASub1Button.Margin = new System.Windows.Forms.Padding(6);
            this.timeoutsASub1Button.Name = "timeoutsASub1Button";
            this.timeoutsASub1Button.Size = new System.Drawing.Size(228, 44);
            this.timeoutsASub1Button.TabIndex = 1;
            this.timeoutsASub1Button.Text = "-1";
            this.timeoutsASub1Button.UseVisualStyleBackColor = true;
            this.timeoutsASub1Button.Click += new System.EventHandler(this.timeoutsASub1Button_Click);
            // 
            // foulsASub1Button
            // 
            this.foulsASub1Button.Location = new System.Drawing.Point(248, 92);
            this.foulsASub1Button.Margin = new System.Windows.Forms.Padding(6);
            this.foulsASub1Button.Name = "foulsASub1Button";
            this.foulsASub1Button.Size = new System.Drawing.Size(228, 44);
            this.foulsASub1Button.TabIndex = 1;
            this.foulsASub1Button.Text = "-1";
            this.foulsASub1Button.UseVisualStyleBackColor = true;
            this.foulsASub1Button.Click += new System.EventHandler(this.foulsASub1Button_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Timeouty:";
            // 
            // scoreAAdd1Button
            // 
            this.scoreAAdd1Button.Location = new System.Drawing.Point(368, 37);
            this.scoreAAdd1Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreAAdd1Button.Name = "scoreAAdd1Button";
            this.scoreAAdd1Button.Size = new System.Drawing.Size(108, 44);
            this.scoreAAdd1Button.TabIndex = 1;
            this.scoreAAdd1Button.Text = "+1";
            this.scoreAAdd1Button.UseVisualStyleBackColor = true;
            this.scoreAAdd1Button.Click += new System.EventHandler(this.scoreAAdd1Button_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fouly:";
            // 
            // teamATimeoutsLabel
            // 
            this.teamATimeoutsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamATimeoutsLabel.AutoSize = true;
            this.teamATimeoutsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamATimeoutsLabel.Location = new System.Drawing.Point(180, 152);
            this.teamATimeoutsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamATimeoutsLabel.Name = "teamATimeoutsLabel";
            this.teamATimeoutsLabel.Size = new System.Drawing.Size(33, 36);
            this.teamATimeoutsLabel.TabIndex = 0;
            this.teamATimeoutsLabel.Text = "0";
            // 
            // scoreASub1Button
            // 
            this.scoreASub1Button.Location = new System.Drawing.Point(248, 37);
            this.scoreASub1Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreASub1Button.Name = "scoreASub1Button";
            this.scoreASub1Button.Size = new System.Drawing.Size(108, 44);
            this.scoreASub1Button.TabIndex = 1;
            this.scoreASub1Button.Text = "-1";
            this.scoreASub1Button.UseVisualStyleBackColor = true;
            this.scoreASub1Button.Click += new System.EventHandler(this.scoreASub1Button_Click);
            // 
            // teamAFoulsLabel
            // 
            this.teamAFoulsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamAFoulsLabel.AutoSize = true;
            this.teamAFoulsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAFoulsLabel.Location = new System.Drawing.Point(180, 96);
            this.teamAFoulsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamAFoulsLabel.Name = "teamAFoulsLabel";
            this.teamAFoulsLabel.Size = new System.Drawing.Size(33, 36);
            this.teamAFoulsLabel.TabIndex = 0;
            this.teamAFoulsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Body:";
            // 
            // teamAPointsLabel
            // 
            this.teamAPointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamAPointsLabel.AutoSize = true;
            this.teamAPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAPointsLabel.Location = new System.Drawing.Point(180, 40);
            this.teamAPointsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamAPointsLabel.Name = "teamAPointsLabel";
            this.teamAPointsLabel.Size = new System.Drawing.Size(33, 36);
            this.teamAPointsLabel.TabIndex = 0;
            this.teamAPointsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Čtvrtina:";
            // 
            // periodNumberLabel
            // 
            this.periodNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.periodNumberLabel.AutoSize = true;
            this.periodNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodNumberLabel.Location = new System.Drawing.Point(158, 33);
            this.periodNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.periodNumberLabel.Name = "periodNumberLabel";
            this.periodNumberLabel.Size = new System.Drawing.Size(33, 36);
            this.periodNumberLabel.TabIndex = 0;
            this.periodNumberLabel.Text = "0";
            // 
            // teamBGroupBox
            // 
            this.teamBGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBGroupBox.Controls.Add(this.scoreBAdd3Button);
            this.teamBGroupBox.Controls.Add(this.timeoutsBAdd1Button);
            this.teamBGroupBox.Controls.Add(this.foulsBAdd1Button);
            this.teamBGroupBox.Controls.Add(this.scoreBAdd2Button);
            this.teamBGroupBox.Controls.Add(this.timeoutsBSub1Button);
            this.teamBGroupBox.Controls.Add(this.foulsBSub1Button);
            this.teamBGroupBox.Controls.Add(this.label7);
            this.teamBGroupBox.Controls.Add(this.scoreBAdd1Button);
            this.teamBGroupBox.Controls.Add(this.label8);
            this.teamBGroupBox.Controls.Add(this.teamBTimeoutsLabel);
            this.teamBGroupBox.Controls.Add(this.scoreBSub1Button);
            this.teamBGroupBox.Controls.Add(this.teamBFoulsLabel);
            this.teamBGroupBox.Controls.Add(this.label11);
            this.teamBGroupBox.Controls.Add(this.teamBPointsLabel);
            this.teamBGroupBox.Location = new System.Drawing.Point(808, 94);
            this.teamBGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.teamBGroupBox.Name = "teamBGroupBox";
            this.teamBGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.teamBGroupBox.Size = new System.Drawing.Size(768, 208);
            this.teamBGroupBox.TabIndex = 1;
            this.teamBGroupBox.TabStop = false;
            this.teamBGroupBox.Text = "teamB";
            // 
            // scoreBAdd3Button
            // 
            this.scoreBAdd3Button.Location = new System.Drawing.Point(608, 37);
            this.scoreBAdd3Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreBAdd3Button.Name = "scoreBAdd3Button";
            this.scoreBAdd3Button.Size = new System.Drawing.Size(108, 44);
            this.scoreBAdd3Button.TabIndex = 1;
            this.scoreBAdd3Button.Text = "+3";
            this.scoreBAdd3Button.UseVisualStyleBackColor = true;
            this.scoreBAdd3Button.Click += new System.EventHandler(this.scoreBAdd3Button_Click);
            // 
            // timeoutsBAdd1Button
            // 
            this.timeoutsBAdd1Button.Location = new System.Drawing.Point(488, 148);
            this.timeoutsBAdd1Button.Margin = new System.Windows.Forms.Padding(6);
            this.timeoutsBAdd1Button.Name = "timeoutsBAdd1Button";
            this.timeoutsBAdd1Button.Size = new System.Drawing.Size(228, 44);
            this.timeoutsBAdd1Button.TabIndex = 1;
            this.timeoutsBAdd1Button.Text = "+1";
            this.timeoutsBAdd1Button.UseVisualStyleBackColor = true;
            this.timeoutsBAdd1Button.Click += new System.EventHandler(this.timeoutsBAdd1Button_Click);
            // 
            // foulsBAdd1Button
            // 
            this.foulsBAdd1Button.Location = new System.Drawing.Point(488, 92);
            this.foulsBAdd1Button.Margin = new System.Windows.Forms.Padding(6);
            this.foulsBAdd1Button.Name = "foulsBAdd1Button";
            this.foulsBAdd1Button.Size = new System.Drawing.Size(228, 44);
            this.foulsBAdd1Button.TabIndex = 1;
            this.foulsBAdd1Button.Text = "+1";
            this.foulsBAdd1Button.UseVisualStyleBackColor = true;
            this.foulsBAdd1Button.Click += new System.EventHandler(this.foulsBAdd1Button_Click);
            // 
            // scoreBAdd2Button
            // 
            this.scoreBAdd2Button.Location = new System.Drawing.Point(488, 37);
            this.scoreBAdd2Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreBAdd2Button.Name = "scoreBAdd2Button";
            this.scoreBAdd2Button.Size = new System.Drawing.Size(108, 44);
            this.scoreBAdd2Button.TabIndex = 1;
            this.scoreBAdd2Button.Text = "+2";
            this.scoreBAdd2Button.UseVisualStyleBackColor = true;
            this.scoreBAdd2Button.Click += new System.EventHandler(this.scoreBAdd2Button_Click);
            // 
            // timeoutsBSub1Button
            // 
            this.timeoutsBSub1Button.Location = new System.Drawing.Point(248, 148);
            this.timeoutsBSub1Button.Margin = new System.Windows.Forms.Padding(6);
            this.timeoutsBSub1Button.Name = "timeoutsBSub1Button";
            this.timeoutsBSub1Button.Size = new System.Drawing.Size(228, 44);
            this.timeoutsBSub1Button.TabIndex = 1;
            this.timeoutsBSub1Button.Text = "-1";
            this.timeoutsBSub1Button.UseVisualStyleBackColor = true;
            this.timeoutsBSub1Button.Click += new System.EventHandler(this.timeoutsBSub1Button_Click);
            // 
            // foulsBSub1Button
            // 
            this.foulsBSub1Button.Location = new System.Drawing.Point(248, 92);
            this.foulsBSub1Button.Margin = new System.Windows.Forms.Padding(6);
            this.foulsBSub1Button.Name = "foulsBSub1Button";
            this.foulsBSub1Button.Size = new System.Drawing.Size(228, 44);
            this.foulsBSub1Button.TabIndex = 1;
            this.foulsBSub1Button.Text = "-1";
            this.foulsBSub1Button.UseVisualStyleBackColor = true;
            this.foulsBSub1Button.Click += new System.EventHandler(this.foulsBSub1Button_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Timeouty:";
            // 
            // scoreBAdd1Button
            // 
            this.scoreBAdd1Button.Location = new System.Drawing.Point(368, 37);
            this.scoreBAdd1Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreBAdd1Button.Name = "scoreBAdd1Button";
            this.scoreBAdd1Button.Size = new System.Drawing.Size(108, 44);
            this.scoreBAdd1Button.TabIndex = 1;
            this.scoreBAdd1Button.Text = "+1";
            this.scoreBAdd1Button.UseVisualStyleBackColor = true;
            this.scoreBAdd1Button.Click += new System.EventHandler(this.scoreBAdd1Button_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fouly:";
            // 
            // teamBTimeoutsLabel
            // 
            this.teamBTimeoutsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBTimeoutsLabel.AutoSize = true;
            this.teamBTimeoutsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBTimeoutsLabel.Location = new System.Drawing.Point(180, 152);
            this.teamBTimeoutsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamBTimeoutsLabel.Name = "teamBTimeoutsLabel";
            this.teamBTimeoutsLabel.Size = new System.Drawing.Size(33, 36);
            this.teamBTimeoutsLabel.TabIndex = 0;
            this.teamBTimeoutsLabel.Text = "0";
            // 
            // scoreBSub1Button
            // 
            this.scoreBSub1Button.Location = new System.Drawing.Point(248, 37);
            this.scoreBSub1Button.Margin = new System.Windows.Forms.Padding(6);
            this.scoreBSub1Button.Name = "scoreBSub1Button";
            this.scoreBSub1Button.Size = new System.Drawing.Size(108, 44);
            this.scoreBSub1Button.TabIndex = 1;
            this.scoreBSub1Button.Text = "-1";
            this.scoreBSub1Button.UseVisualStyleBackColor = true;
            this.scoreBSub1Button.Click += new System.EventHandler(this.scoreBSub1Button_Click);
            // 
            // teamBFoulsLabel
            // 
            this.teamBFoulsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBFoulsLabel.AutoSize = true;
            this.teamBFoulsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBFoulsLabel.Location = new System.Drawing.Point(180, 96);
            this.teamBFoulsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamBFoulsLabel.Name = "teamBFoulsLabel";
            this.teamBFoulsLabel.Size = new System.Drawing.Size(33, 36);
            this.teamBFoulsLabel.TabIndex = 0;
            this.teamBFoulsLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 36);
            this.label11.TabIndex = 0;
            this.label11.Text = "Body:";
            // 
            // teamBPointsLabel
            // 
            this.teamBPointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamBPointsLabel.AutoSize = true;
            this.teamBPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBPointsLabel.Location = new System.Drawing.Point(180, 40);
            this.teamBPointsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamBPointsLabel.Name = "teamBPointsLabel";
            this.teamBPointsLabel.Size = new System.Drawing.Size(33, 36);
            this.teamBPointsLabel.TabIndex = 0;
            this.teamBPointsLabel.Text = "0";
            // 
            // clockStartButton
            // 
            this.clockStartButton.Location = new System.Drawing.Point(558, 23);
            this.clockStartButton.Margin = new System.Windows.Forms.Padding(6);
            this.clockStartButton.Name = "clockStartButton";
            this.clockStartButton.Size = new System.Drawing.Size(124, 60);
            this.clockStartButton.TabIndex = 2;
            this.clockStartButton.Text = "Start";
            this.clockStartButton.UseVisualStyleBackColor = true;
            this.clockStartButton.Click += new System.EventHandler(this.clockStartButton_Click);
            // 
            // clockStopButton
            // 
            this.clockStopButton.Location = new System.Drawing.Point(910, 25);
            this.clockStopButton.Margin = new System.Windows.Forms.Padding(6);
            this.clockStopButton.Name = "clockStopButton";
            this.clockStopButton.Size = new System.Drawing.Size(124, 60);
            this.clockStopButton.TabIndex = 2;
            this.clockStopButton.Text = "Stop";
            this.clockStopButton.UseVisualStyleBackColor = true;
            this.clockStopButton.Click += new System.EventHandler(this.clockStopButton_Click);
            // 
            // runTimeoutButton
            // 
            this.runTimeoutButton.Location = new System.Drawing.Point(1348, 29);
            this.runTimeoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.runTimeoutButton.Name = "runTimeoutButton";
            this.runTimeoutButton.Size = new System.Drawing.Size(228, 44);
            this.runTimeoutButton.TabIndex = 1;
            this.runTimeoutButton.Text = "Spustit timeout";
            this.runTimeoutButton.UseVisualStyleBackColor = true;
            this.runTimeoutButton.Click += new System.EventHandler(this.runTimeoutButton_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            // 
            // periodSub1Button
            // 
            this.periodSub1Button.Location = new System.Drawing.Point(204, 29);
            this.periodSub1Button.Margin = new System.Windows.Forms.Padding(6);
            this.periodSub1Button.Name = "periodSub1Button";
            this.periodSub1Button.Size = new System.Drawing.Size(74, 44);
            this.periodSub1Button.TabIndex = 1;
            this.periodSub1Button.Text = "-1";
            this.periodSub1Button.UseVisualStyleBackColor = true;
            this.periodSub1Button.Click += new System.EventHandler(this.periodSub1Button_Click);
            // 
            // periodAdd1Button
            // 
            this.periodAdd1Button.Location = new System.Drawing.Point(286, 29);
            this.periodAdd1Button.Margin = new System.Windows.Forms.Padding(6);
            this.periodAdd1Button.Name = "periodAdd1Button";
            this.periodAdd1Button.Size = new System.Drawing.Size(74, 44);
            this.periodAdd1Button.TabIndex = 1;
            this.periodAdd1Button.Text = "+1";
            this.periodAdd1Button.UseVisualStyleBackColor = true;
            this.periodAdd1Button.Click += new System.EventHandler(this.periodAdd1Button_Click);
            // 
            // timeoutTimer
            // 
            this.timeoutTimer.Interval = 1000;
            // 
            // showResultsButton
            // 
            this.showResultsButton.Location = new System.Drawing.Point(1176, 29);
            this.showResultsButton.Margin = new System.Windows.Forms.Padding(6);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(161, 44);
            this.showResultsButton.TabIndex = 1;
            this.showResultsButton.Text = "Výsledky";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.showResultsButton_Click);
            // 
            // GameControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 325);
            this.Controls.Add(this.clockStopButton);
            this.Controls.Add(this.clockStartButton);
            this.Controls.Add(this.teamBGroupBox);
            this.Controls.Add(this.teamAGroupBox);
            this.Controls.Add(this.periodNumberLabel);
            this.Controls.Add(this.showResultsButton);
            this.Controls.Add(this.runTimeoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodAdd1Button);
            this.Controls.Add(this.periodSub1Button);
            this.Controls.Add(this.clockLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "GameControlForm";
            this.Text = "BSc - Řídící panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameControlForm_FormClosing);
            this.Load += new System.EventHandler(this.GameControlForm_Load);
            this.teamAGroupBox.ResumeLayout(false);
            this.teamAGroupBox.PerformLayout();
            this.teamBGroupBox.ResumeLayout(false);
            this.teamBGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.GroupBox teamAGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label periodNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label teamAPointsLabel;
        private System.Windows.Forms.Button scoreAAdd3Button;
        private System.Windows.Forms.Button scoreAAdd2Button;
        private System.Windows.Forms.Button scoreAAdd1Button;
        private System.Windows.Forms.Button scoreASub1Button;
        private System.Windows.Forms.Button timeoutsAAdd1Button;
        private System.Windows.Forms.Button foulsAAdd1Button;
        private System.Windows.Forms.Button timeoutsASub1Button;
        private System.Windows.Forms.Button foulsASub1Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label teamATimeoutsLabel;
        private System.Windows.Forms.Label teamAFoulsLabel;
        private System.Windows.Forms.GroupBox teamBGroupBox;
        private System.Windows.Forms.Button scoreBAdd3Button;
        private System.Windows.Forms.Button timeoutsBAdd1Button;
        private System.Windows.Forms.Button foulsBAdd1Button;
        private System.Windows.Forms.Button scoreBAdd2Button;
        private System.Windows.Forms.Button timeoutsBSub1Button;
        private System.Windows.Forms.Button foulsBSub1Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button scoreBAdd1Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label teamBTimeoutsLabel;
        private System.Windows.Forms.Button scoreBSub1Button;
        private System.Windows.Forms.Label teamBFoulsLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label teamBPointsLabel;
        private System.Windows.Forms.Button clockStartButton;
        private System.Windows.Forms.Button clockStopButton;
        private System.Windows.Forms.Button runTimeoutButton;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button periodSub1Button;
        private System.Windows.Forms.Button periodAdd1Button;
        private System.Windows.Forms.Timer timeoutTimer;
        private System.Windows.Forms.Button showResultsButton;
    }
}