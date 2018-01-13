namespace SOW_Clicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOrcJobs = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.barSkirmish = new System.Windows.Forms.ProgressBar();
            this.txtSpoilsOfWar = new System.Windows.Forms.TextBox();
            this.barSpoilsOfWar = new System.Windows.Forms.ProgressBar();
            this.combSpoils = new System.Windows.Forms.ComboBox();
            this.txtspoilpos = new System.Windows.Forms.Label();
            this.barOrcJobs2 = new System.Windows.Forms.ProgressBar();
            this.lblSkirmishTimer = new System.Windows.Forms.Label();
            this.comboOrcJobs2 = new System.Windows.Forms.ComboBox();
            this.timerAll = new System.Windows.Forms.Timer(this.components);
            this.lbl2OrcJob = new System.Windows.Forms.Label();
            this.txtCampaignEnergy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSkirmish = new System.Windows.Forms.CheckBox();
            this.cbOrcJob2 = new System.Windows.Forms.CheckBox();
            this.cbSpoilsofWar = new System.Windows.Forms.CheckBox();
            this.cbCampaign = new System.Windows.Forms.CheckBox();
            this.gbSkirmish = new System.Windows.Forms.GroupBox();
            this.gb2JobOrc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOJTimeRemain = new System.Windows.Forms.TextBox();
            this.lblJobType = new System.Windows.Forms.Label();
            this.gbSpoilsofWar = new System.Windows.Forms.GroupBox();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.gbCampaign = new System.Windows.Forms.GroupBox();
            this.barCampaign = new System.Windows.Forms.ProgressBar();
            this.txtMinEnergy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCampaignDificulty = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblEnergyATT = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.gbSkirmish.SuspendLayout();
            this.gb2JobOrc.SuspendLayout();
            this.gbSpoilsofWar.SuspendLayout();
            this.gbCampaign.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrcJobs
            // 
            this.btnOrcJobs.Location = new System.Drawing.Point(12, 406);
            this.btnOrcJobs.Name = "btnOrcJobs";
            this.btnOrcJobs.Size = new System.Drawing.Size(63, 39);
            this.btnOrcJobs.TabIndex = 1;
            this.btnOrcJobs.Text = "Start";
            this.btnOrcJobs.UseVisualStyleBackColor = true;
            this.btnOrcJobs.Click += new System.EventHandler(this.Create_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(334, 406);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 39);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // barSkirmish
            // 
            this.barSkirmish.Location = new System.Drawing.Point(40, 17);
            this.barSkirmish.Maximum = 300;
            this.barSkirmish.Name = "barSkirmish";
            this.barSkirmish.Size = new System.Drawing.Size(352, 16);
            this.barSkirmish.TabIndex = 3;
            // 
            // txtSpoilsOfWar
            // 
            this.txtSpoilsOfWar.Location = new System.Drawing.Point(215, 16);
            this.txtSpoilsOfWar.Name = "txtSpoilsOfWar";
            this.txtSpoilsOfWar.Size = new System.Drawing.Size(35, 20);
            this.txtSpoilsOfWar.TabIndex = 4;
            this.txtSpoilsOfWar.Text = "1";
            // 
            // barSpoilsOfWar
            // 
            this.barSpoilsOfWar.Location = new System.Drawing.Point(9, 40);
            this.barSpoilsOfWar.Maximum = 300;
            this.barSpoilsOfWar.Name = "barSpoilsOfWar";
            this.barSpoilsOfWar.Size = new System.Drawing.Size(383, 16);
            this.barSpoilsOfWar.TabIndex = 6;
            // 
            // combSpoils
            // 
            this.combSpoils.FormattingEnabled = true;
            this.combSpoils.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.combSpoils.Location = new System.Drawing.Point(91, 15);
            this.combSpoils.Name = "combSpoils";
            this.combSpoils.Size = new System.Drawing.Size(36, 21);
            this.combSpoils.TabIndex = 8;
            this.combSpoils.Text = "2";
            // 
            // txtspoilpos
            // 
            this.txtspoilpos.AutoSize = true;
            this.txtspoilpos.Location = new System.Drawing.Point(11, 19);
            this.txtspoilpos.Name = "txtspoilpos";
            this.txtspoilpos.Size = new System.Drawing.Size(78, 13);
            this.txtspoilpos.TabIndex = 9;
            this.txtspoilpos.Text = "Spoils Position:";
            // 
            // barOrcJobs2
            // 
            this.barOrcJobs2.Location = new System.Drawing.Point(40, 40);
            this.barOrcJobs2.Maximum = 300;
            this.barOrcJobs2.Name = "barOrcJobs2";
            this.barOrcJobs2.Size = new System.Drawing.Size(352, 16);
            this.barOrcJobs2.TabIndex = 10;
            // 
            // lblSkirmishTimer
            // 
            this.lblSkirmishTimer.AutoSize = true;
            this.lblSkirmishTimer.Location = new System.Drawing.Point(6, 20);
            this.lblSkirmishTimer.Name = "lblSkirmishTimer";
            this.lblSkirmishTimer.Size = new System.Drawing.Size(28, 13);
            this.lblSkirmishTimer.TabIndex = 12;
            this.lblSkirmishTimer.Text = "0:00";
            // 
            // comboOrcJobs2
            // 
            this.comboOrcJobs2.FormattingEnabled = true;
            this.comboOrcJobs2.Items.AddRange(new object[] {
            "Disrupt",
            "Treasures",
            "Raiding",
            "Recruit"});
            this.comboOrcJobs2.Location = new System.Drawing.Point(67, 15);
            this.comboOrcJobs2.Name = "comboOrcJobs2";
            this.comboOrcJobs2.Size = new System.Drawing.Size(66, 21);
            this.comboOrcJobs2.TabIndex = 13;
            this.comboOrcJobs2.Text = "Treasures";
            // 
            // timerAll
            // 
            this.timerAll.Interval = 1000;
            this.timerAll.Tick += new System.EventHandler(this.timerAll_Tick);
            // 
            // lbl2OrcJob
            // 
            this.lbl2OrcJob.AutoSize = true;
            this.lbl2OrcJob.Location = new System.Drawing.Point(12, 40);
            this.lbl2OrcJob.Name = "lbl2OrcJob";
            this.lbl2OrcJob.Size = new System.Drawing.Size(25, 13);
            this.lbl2OrcJob.TabIndex = 14;
            this.lbl2OrcJob.Text = "00h";
            // 
            // txtCampaignEnergy
            // 
            this.txtCampaignEnergy.Location = new System.Drawing.Point(62, 15);
            this.txtCampaignEnergy.Name = "txtCampaignEnergy";
            this.txtCampaignEnergy.Size = new System.Drawing.Size(49, 20);
            this.txtCampaignEnergy.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Energy:";
            // 
            // cbSkirmish
            // 
            this.cbSkirmish.AutoSize = true;
            this.cbSkirmish.Location = new System.Drawing.Point(8, 29);
            this.cbSkirmish.Name = "cbSkirmish";
            this.cbSkirmish.Size = new System.Drawing.Size(15, 14);
            this.cbSkirmish.TabIndex = 17;
            this.cbSkirmish.UseVisualStyleBackColor = true;
            this.cbSkirmish.CheckedChanged += new System.EventHandler(this.cbSkirmish_CheckedChanged);
            // 
            // cbOrcJob2
            // 
            this.cbOrcJob2.AutoSize = true;
            this.cbOrcJob2.Location = new System.Drawing.Point(8, 78);
            this.cbOrcJob2.Name = "cbOrcJob2";
            this.cbOrcJob2.Size = new System.Drawing.Size(15, 14);
            this.cbOrcJob2.TabIndex = 18;
            this.cbOrcJob2.UseVisualStyleBackColor = true;
            this.cbOrcJob2.CheckedChanged += new System.EventHandler(this.cbOrcJob2_CheckedChanged);
            // 
            // cbSpoilsofWar
            // 
            this.cbSpoilsofWar.AutoSize = true;
            this.cbSpoilsofWar.Location = new System.Drawing.Point(8, 148);
            this.cbSpoilsofWar.Name = "cbSpoilsofWar";
            this.cbSpoilsofWar.Size = new System.Drawing.Size(15, 14);
            this.cbSpoilsofWar.TabIndex = 19;
            this.cbSpoilsofWar.UseVisualStyleBackColor = true;
            this.cbSpoilsofWar.CheckedChanged += new System.EventHandler(this.cbSpoilsofWar_CheckedChanged);
            // 
            // cbCampaign
            // 
            this.cbCampaign.AutoSize = true;
            this.cbCampaign.Location = new System.Drawing.Point(8, 219);
            this.cbCampaign.Name = "cbCampaign";
            this.cbCampaign.Size = new System.Drawing.Size(15, 14);
            this.cbCampaign.TabIndex = 20;
            this.cbCampaign.UseVisualStyleBackColor = true;
            this.cbCampaign.CheckedChanged += new System.EventHandler(this.cbCampaign_CheckedChanged);
            // 
            // gbSkirmish
            // 
            this.gbSkirmish.Controls.Add(this.barSkirmish);
            this.gbSkirmish.Controls.Add(this.lblSkirmishTimer);
            this.gbSkirmish.Enabled = false;
            this.gbSkirmish.Location = new System.Drawing.Point(29, 12);
            this.gbSkirmish.Name = "gbSkirmish";
            this.gbSkirmish.Size = new System.Drawing.Size(398, 40);
            this.gbSkirmish.TabIndex = 21;
            this.gbSkirmish.TabStop = false;
            this.gbSkirmish.Text = "Auto Skirmish";
            // 
            // gb2JobOrc
            // 
            this.gb2JobOrc.Controls.Add(this.label1);
            this.gb2JobOrc.Controls.Add(this.txtOJTimeRemain);
            this.gb2JobOrc.Controls.Add(this.lblJobType);
            this.gb2JobOrc.Controls.Add(this.barOrcJobs2);
            this.gb2JobOrc.Controls.Add(this.lbl2OrcJob);
            this.gb2JobOrc.Controls.Add(this.comboOrcJobs2);
            this.gb2JobOrc.Enabled = false;
            this.gb2JobOrc.Location = new System.Drawing.Point(29, 58);
            this.gb2JobOrc.Name = "gb2JobOrc";
            this.gb2JobOrc.Size = new System.Drawing.Size(398, 62);
            this.gb2JobOrc.TabIndex = 22;
            this.gb2JobOrc.TabStop = false;
            this.gb2JobOrc.Text = "2nd Orc Job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Time Remain:";
            // 
            // txtOJTimeRemain
            // 
            this.txtOJTimeRemain.Location = new System.Drawing.Point(215, 16);
            this.txtOJTimeRemain.Name = "txtOJTimeRemain";
            this.txtOJTimeRemain.Size = new System.Drawing.Size(35, 20);
            this.txtOJTimeRemain.TabIndex = 24;
            this.txtOJTimeRemain.Text = "1";
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new System.Drawing.Point(13, 19);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(50, 13);
            this.lblJobType.TabIndex = 23;
            this.lblJobType.Text = "Job type:";
            // 
            // gbSpoilsofWar
            // 
            this.gbSpoilsofWar.Controls.Add(this.lblTimeRemain);
            this.gbSpoilsofWar.Controls.Add(this.barSpoilsOfWar);
            this.gbSpoilsofWar.Controls.Add(this.txtSpoilsOfWar);
            this.gbSpoilsofWar.Controls.Add(this.combSpoils);
            this.gbSpoilsofWar.Controls.Add(this.txtspoilpos);
            this.gbSpoilsofWar.Enabled = false;
            this.gbSpoilsofWar.Location = new System.Drawing.Point(29, 126);
            this.gbSpoilsofWar.Name = "gbSpoilsofWar";
            this.gbSpoilsofWar.Size = new System.Drawing.Size(398, 62);
            this.gbSpoilsofWar.TabIndex = 23;
            this.gbSpoilsofWar.TabStop = false;
            this.gbSpoilsofWar.Text = "Spoils of War";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Location = new System.Drawing.Point(138, 18);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(72, 13);
            this.lblTimeRemain.TabIndex = 10;
            this.lblTimeRemain.Text = "Time Remain:";
            // 
            // gbCampaign
            // 
            this.gbCampaign.Controls.Add(this.barCampaign);
            this.gbCampaign.Controls.Add(this.txtMinEnergy);
            this.gbCampaign.Controls.Add(this.label4);
            this.gbCampaign.Controls.Add(this.label2);
            this.gbCampaign.Controls.Add(this.comboCampaignDificulty);
            this.gbCampaign.Controls.Add(this.txtCampaignEnergy);
            this.gbCampaign.Controls.Add(this.label3);
            this.gbCampaign.Enabled = false;
            this.gbCampaign.Location = new System.Drawing.Point(29, 194);
            this.gbCampaign.Name = "gbCampaign";
            this.gbCampaign.Size = new System.Drawing.Size(398, 62);
            this.gbCampaign.TabIndex = 24;
            this.gbCampaign.TabStop = false;
            this.gbCampaign.Text = "Campaign";
            // 
            // barCampaign
            // 
            this.barCampaign.Location = new System.Drawing.Point(9, 40);
            this.barCampaign.Maximum = 240;
            this.barCampaign.Name = "barCampaign";
            this.barCampaign.Size = new System.Drawing.Size(383, 16);
            this.barCampaign.TabIndex = 11;
            // 
            // txtMinEnergy
            // 
            this.txtMinEnergy.Location = new System.Drawing.Point(319, 15);
            this.txtMinEnergy.Name = "txtMinEnergy";
            this.txtMinEnergy.Size = new System.Drawing.Size(49, 20);
            this.txtMinEnergy.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Min Energy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Difficulty:";
            // 
            // comboCampaignDificulty
            // 
            this.comboCampaignDificulty.FormattingEnabled = true;
            this.comboCampaignDificulty.Items.AddRange(new object[] {
            "Normal",
            "Hard"});
            this.comboCampaignDificulty.Location = new System.Drawing.Point(174, 14);
            this.comboCampaignDificulty.Name = "comboCampaignDificulty";
            this.comboCampaignDificulty.Size = new System.Drawing.Size(60, 21);
            this.comboCampaignDificulty.TabIndex = 11;
            this.comboCampaignDificulty.Text = "Normal";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(262, 406);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(66, 39);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(170, 374);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(43, 13);
            this.lbl7.TabIndex = 20;
            this.lbl7.Text = "Energy:";
            // 
            // lblEnergyATT
            // 
            this.lblEnergyATT.AutoSize = true;
            this.lblEnergyATT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergyATT.Location = new System.Drawing.Point(209, 375);
            this.lblEnergyATT.Name = "lblEnergyATT";
            this.lblEnergyATT.Size = new System.Drawing.Size(14, 13);
            this.lblEnergyATT.TabIndex = 26;
            this.lblEnergyATT.Text = "0";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(329, 374);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentTime.TabIndex = 27;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 457);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblEnergyATT);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.gbCampaign);
            this.Controls.Add(this.gbSpoilsofWar);
            this.Controls.Add(this.gb2JobOrc);
            this.Controls.Add(this.gbSkirmish);
            this.Controls.Add(this.cbCampaign);
            this.Controls.Add(this.cbSkirmish);
            this.Controls.Add(this.cbSpoilsofWar);
            this.Controls.Add(this.cbOrcJob2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnOrcJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "SOW";
            this.TopMost = true;
            this.gbSkirmish.ResumeLayout(false);
            this.gbSkirmish.PerformLayout();
            this.gb2JobOrc.ResumeLayout(false);
            this.gb2JobOrc.PerformLayout();
            this.gbSpoilsofWar.ResumeLayout(false);
            this.gbSpoilsofWar.PerformLayout();
            this.gbCampaign.ResumeLayout(false);
            this.gbCampaign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrcJobs;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ProgressBar barSkirmish;
        private System.Windows.Forms.TextBox txtSpoilsOfWar;
        private System.Windows.Forms.ProgressBar barSpoilsOfWar;
        private System.Windows.Forms.ComboBox combSpoils;
        private System.Windows.Forms.Label txtspoilpos;
        private System.Windows.Forms.ProgressBar barOrcJobs2;
        private System.Windows.Forms.Label lblSkirmishTimer;
        private System.Windows.Forms.ComboBox comboOrcJobs2;
        private System.Windows.Forms.Timer timerAll;
        private System.Windows.Forms.Label lbl2OrcJob;
        private System.Windows.Forms.TextBox txtCampaignEnergy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSkirmish;
        private System.Windows.Forms.CheckBox cbOrcJob2;
        private System.Windows.Forms.CheckBox cbSpoilsofWar;
        private System.Windows.Forms.CheckBox cbCampaign;
        private System.Windows.Forms.GroupBox gbSkirmish;
        private System.Windows.Forms.GroupBox gb2JobOrc;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.GroupBox gbSpoilsofWar;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOJTimeRemain;
        private System.Windows.Forms.GroupBox gbCampaign;
        private System.Windows.Forms.ProgressBar barCampaign;
        private System.Windows.Forms.TextBox txtMinEnergy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCampaignDificulty;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblEnergyATT;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timerClock;
    }
}

