using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Collections;



namespace SOW_Clicker
{

    public partial class Form1 : Form
    {
        #region GLobal Variabels, Dll & Mouse Event
        int tOJ2;
        int tSOW;
        int tSki;
        int actualEnergy;
        int minEnergy;

        bool runOJ2 = false;
        bool runSow = false;
        bool runSki = false;
        bool skiChangePos = false;
        bool runCampaign = false;      

        TimeSpan timeSKI;
        #region Dll
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Mouse Event
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        #endregion

        #endregion       
       
        private void Create_Click(object sender, EventArgs e) //MAIN RUN
        {

            timerAll.Start();
            if (cbOrcJob2.Checked == true) OrcJob2nd();
            if (cbSpoilsofWar.Checked == true) SpoilsOfWarConvert();
            if (cbSkirmish.Checked == true) OrcJobs();
            if (cbCampaign.Checked == true)
            {
                actualEnergy = Convert.ToInt32(txtCampaignEnergy.Text);
                minEnergy = Convert.ToInt32(txtMinEnergy.Text);
                Campaign();
            }


        }

        #region Click
        public void Clic(int x, int y)
        {
            SetCursorPos(x, y);
            this.Refresh();
            Application.DoEvents();
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }
        public void ClicScroll(int x, int y)
        {
            SetCursorPos(x, y);
            this.Refresh();
            Application.DoEvents();
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
        }
        public void Wait(int xmsec)
        {
            Thread.Sleep(xmsec);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Back()
        {
            Clic(514, 735);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerAll.Stop();
            tOJ2 = 0;
            tSOW = 0;
            tSki = 0;

            runOJ2 = false;
            runSow = false;
            runSki = false;
            skiChangePos = false;
            runCampaign = false;

            barCampaign.Value = 0;
            barOrcJobs2.Value = 0;
            barSkirmish.Value = 0;
            barSpoilsOfWar.Value = 0;
            lblSkirmishTimer.Text = "0:00";

        }

        #endregion

        #region Skirmish
        private void OrcJobs()
        {
            if (runOJ2 != true && runSow != true && runCampaign != true)
            {
                runSki = true;
                barSkirmish.Value = 0;
                Clic(500, 710);
                Wait(900);
                Clic(790, 335);
                Wait(900);
                Clic(785, 286);
                Wait(900);
                Clic(800, 400); //Test
                Wait(900);
                Clic(526, 432);
                Wait(900);
                Clic(660, 735);
                Wait(2500);
                Clic(513, 741);
                Wait(1000);
                tSki = 300000;

                runSki = false;
            }

        }
        private void OrcJobsClaim()
        {
            runSki = true;
            Clic(500, 710);
            Wait(900);
            Clic(790, 335);
            Wait(900);
            if (skiChangePos == false) Clic(765, 285);
            else if (skiChangePos == true)
            {
                Clic(563, 285);
                skiChangePos = false;
            }
            Wait(900);
            Clic(661, 581);
            Wait(900);
            Clic(515, 740);
            OrcJobs();

        }
        private void cbSkirmish_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSkirmish.Checked == true)
                gbSkirmish.Enabled = true;
            else if (cbSkirmish.Checked == false)
                gbSkirmish.Enabled = false;
        }
        #endregion

        #region Spoils of war
        private void SpoilsOfWarConvert()
        {
            int x = Convert.ToInt32(txtSpoilsOfWar.Text);
            if (x >= 300)
                x = 3600000 * 3 + ((x - 300) * 1000 * 60);

            else if (x >= 200 && x < 300)
                x = 3600000 * 2 + ((x - 200) * 1000 * 60);

            else if (x >= 100 && x < 200)
                x = 3600000 * 1 + ((x - 100) * 1000 * 60);

            else if (x < 100)
                x = (x * 1000 * 60);

            if (x != 0)
            {
                barSpoilsOfWar.Maximum = x;
                tSOW = x;
            }
            else if (x == 0)
            {
                barSpoilsOfWar.Value = barSpoilsOfWar.Maximum;
                tSOW = 1000;
            }
        }
        private void SOWStart()
        {
            runSow = true;
            Clic(585, 720);
            Wait(1000);
            Clic(670, 395);
            Wait(1700);
            //combo Box
            if (combSpoils.Text == "2") Clic(670, 395);
            else if (combSpoils.Text == "1") Clic(650, 200);
            else if (combSpoils.Text == "3") Clic(670, 550);
            else if (combSpoils.Text == "4") Clic(660, 700);
            Wait(1000);
            Clic(566, 674);
            Wait(8000);
            Clic(735, 728);
            Wait(3000);
            Back();
            Wait(1500);
            Back();
            barSpoilsOfWar.Maximum = 14400000;
            barSpoilsOfWar.Value = 0;
            tSOW = 14400000;
            Wait(1000);
            runSow = false;
        }
        private void cbSpoilsofWar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSpoilsofWar.Checked == true) gbSpoilsofWar.Enabled = true;

            if (cbSpoilsofWar.Checked == false) gbSpoilsofWar.Enabled = false;
        }
        #endregion

        #region Orc Job 2nd
        private void OrcJob2nd()
        {
            #region Convert Text Box
            if (runOJ2 != true)
            {
                int x = Convert.ToInt32(txtOJTimeRemain.Text);
                if (x >= 300)
                    x = 3600000 * 3 + ((x - 300) * 1000 * 60);

                else if (x >= 200 && x < 300)
                    x = 3600000 * 2 + ((x - 200) * 1000 * 60);

                else if (x >= 100 && x < 200)
                    x = 3600000 * 1 + ((x - 100) * 1000 * 60);

                else if (x < 100)
                    x = (x * 1000 * 60);

                if (x != 0)
                {
                    barOrcJobs2.Maximum = x;
                    tOJ2 = x;
                }
                else if (x == 0)
                {
                    barSpoilsOfWar.Value = barSpoilsOfWar.Maximum;
                    tOJ2 = 0;
                }
            }

            #endregion

            #region Treasures
            if (comboOrcJobs2.Text == "Treasures" && tOJ2 == 0)
            {
                runOJ2 = true;
                Clic(500, 710);
                Wait(900);
                Clic(790, 335);
                Wait(900);
                Clic(785, 286);
                Wait(900);
                if (tSki <= 0)
                    Clic(800, 520); // Test It
                else if (tSki > 0)
                    Clic(800, 407);
                Wait(900);
                Clic(524, 431);
                Wait(900);
                Clic(660, 738);
                Wait(900);
                Clic(740, 493);
                Wait(2000);
                Back();
                tOJ2 = 14400000;
                barOrcJobs2.Maximum = tOJ2;
                barOrcJobs2.Value = 0;
                lbl2OrcJob.Text = 4 + "h";
                Wait(500);
                runOJ2 = false;
            }
            #endregion

            #region Raiding
            if (comboOrcJobs2.Text == "Raiding")
            {
                Clic(500, 710);
                Wait(500);
                Clic(790, 335);
                Wait(500);
                Clic(785, 286);
                Wait(500);
                Clic(8050, 407);// Was here
                Wait(500);
                Clic(524, 431);
                Wait(500);
                Clic(660, 738);
                Wait(1500);
                Back();
                tOJ2 = 14400000;
                barOrcJobs2.Maximum = tOJ2;
                timerAll.Start();
                lbl2OrcJob.Text = 4 + "h";
                #endregion
            }
        }
        private void TreasuresClaim()
        {
            runOJ2 = true;
            Clic(500, 710);
            Wait(900);
            Clic(800, 335);
            Wait(900);
            Clic(563, 285); // Maybe needs fix
            Wait(900);
            Clic(659, 583);
            Wait(900);
            Back();
            skiChangePos = true;
            OrcJob2nd();
        }
        private void DisruptClaim()
        {
            runOJ2 = true;
            Clic(500, 710);
            Wait(500);
            Clic(790, 335);
            Wait(500);
            Clic(785, 286);
            Wait(500);
            Clic(804, 291);
            Wait(500);
            Clic(524, 431);
            Wait(500);
            Clic(660, 738);
            Wait(1500);
            Back();
            tOJ2 = 86400000;
            barOrcJobs2.Maximum = tOJ2;
            timerAll.Start();
            lbl2OrcJob.Text = 24 + "h";
            runOJ2 = false;
        }
        private void cbOrcJob2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOrcJob2.Checked == true) gb2JobOrc.Enabled = true;
            else if (cbOrcJob2.Checked == false) gb2JobOrc.Enabled = false;
        }

        #endregion

        #region Campaign
        private void cbCampaign_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCampaign.Checked == true) gbCampaign.Enabled = true;
            if (cbCampaign.Checked == false) gbCampaign.Enabled = false;
        }
        private void Campaign()
        {
            lblEnergyATT.Text = actualEnergy.ToString();
            if (comboCampaignDificulty.Text == "Normal" && actualEnergy >= minEnergy + 4 && runSow != true && runSki != true && runOJ2 != true)
            {
                runCampaign = true;
                Clic(668, 712);
                Wait(900);
                Clic(662, 573);
                Wait(2000);
                Clic(561, 387);
                Clic(661, 387);// Because the map moves its not a mistake
                Wait(1500);
                Clic(706, 740);
                Wait(1000);
                Clic(594, 564);
                Wait(1500);
                Clic(743, 301);
                Wait(900);
                Clic(594, 547);
                actualEnergy = actualEnergy - 4;
                Wait(3000);
                for (int i = actualEnergy; i > minEnergy; i = i - 4)
                {
                    Clic(576, 473);
                    Wait(2500);
                    actualEnergy = actualEnergy - 4;
                }
                Clic(745, 466);
                Wait(900);
                Clic(586, 626);
                Wait(900);
                Back();
                Wait(900);
                Back();
                Wait(900);
                Back();
                lblEnergyATT.Text = actualEnergy.ToString();
                Wait(800);
                runCampaign = false;

            }
        }
        #endregion

        private void timerAll_Tick(object sender, EventArgs e)
        {
            if (runOJ2 != true && tOJ2 > 0 && cbOrcJob2.Checked == true) tOJ2 = tOJ2 - 1000;
            if (runSow != true && tSOW > 0 && cbSpoilsofWar.Checked == true) tSOW = tSOW - 1000;
            if (runSki != true && tSki > 0 && cbSkirmish.Checked == true) tSki = tSki - 1000;

            if (runOJ2 != true && tOJ2 > 0 && cbOrcJob2.Checked == true) barOrcJobs2.Value = barOrcJobs2.Maximum - tOJ2;
            if (runSow != true && tSOW > 0 && cbSpoilsofWar.Checked == true) barSpoilsOfWar.Value = barSpoilsOfWar.Maximum - tSOW;
            if (runSki != true && tSki > 0 && cbSkirmish.Checked == true) barSkirmish.Increment(1);
            if (runCampaign != true && cbCampaign.Checked == true) barCampaign.Increment(1);



            #region Disrupt

            if (cbOrcJob2.Checked == true && comboOrcJobs2.Text == "Disrupt" && tOJ2 < 86390000) lbl2OrcJob.Text = 23 + "h";

            if (cbOrcJob2.Checked == true && comboOrcJobs2.Text == "Disrupt" && tOJ2 == 0 && runOJ2 != true && runSki != true && runSow != true)
                DisruptClaim();
            #endregion

            #region Treasures
            if (cbOrcJob2.Checked == true && comboOrcJobs2.Text == "Treasures" && runOJ2 != true && runSow != true && runSki != true && tOJ2 == 0 && runCampaign != true)
                TreasuresClaim();
            #endregion

            #region Spoils of War
            if (cbSpoilsofWar.Checked == true && tSOW == 0 && runSki != true && runSow != true && runOJ2 != true && runCampaign != true)
                SOWStart();
            #endregion

            #region Skirmish

            if (cbSkirmish.Checked == true && tSki == 0 && runSki != true && runOJ2 != true && runSow != true && runCampaign != true)
                OrcJobsClaim();

            #region Numbers Set
            if (runSki != true)
            {
                int x = barSkirmish.Value;
                if (x <= 60)
                {
                    lblSkirmishTimer.Text = "4:" + (60 - x);
                }
                else if (x > 60 && x <= 120)
                {
                    lblSkirmishTimer.Text = "3:" + (120 - x);
                }
                else if (x > 120 && x <= 180)
                {
                    lblSkirmishTimer.Text = "2:" + (180 - x);
                }
                else if (x > 180 && x <= 240)
                {
                    lblSkirmishTimer.Text = "1:" + (240 - x);
                }
                else if (x > 240)
                {
                    lblSkirmishTimer.Text = "0:" + (300 - x);
                }
            }
            #endregion
            #endregion

            #region Campaign
            if (runCampaign != true && cbCampaign.Checked == true && barCampaign.Maximum == barCampaign.Value)
            {
                barCampaign.Value = 0;
                actualEnergy++;
                lblEnergyATT.Text = actualEnergy.ToString();
            }
            if (actualEnergy >= minEnergy + 4 && comboCampaignDificulty.Text == "Normal" && runCampaign != true)
                Campaign();

            #endregion

        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }
    }
}
