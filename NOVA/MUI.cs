using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Xml;
using System.IO;

namespace NOVA
{

    public partial class MUI : Form
    {
        NOVA_CORE.main main = new NOVA_CORE.main(); // import main module
        NOVA_CORE.Aes_Opr NV_AES = new NOVA_CORE.Aes_Opr(); // import cryptography module

        private bool drag = false; private Point startPoint = new Point(0, 0); bool isinput = false; // form movement data
        int counter = 0; int len = 0; string text, temp;
        string user; int timeN, timeS, timeM, timeH; string clockTime;
        int sDat = 0; string intxt, ottxt; string command = "", cmdtxt; int timeX = 0;

        Choices list = new Choices();
        public SpeechSynthesizer speechS = new SpeechSynthesizer();

        public MUI()
        {
            InitializeComponent();
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
            list.Add(new String[] { "hello", "hey", "hi", "good",
                "what is your name", "open chrome", "thank you",
                "exit", "shut down", "close" });
            Grammar gr = new Grammar(new GrammarBuilder(list));
            try
            {
                rec.RequestRecognizerUpdate(); 
                rec.LoadGrammar(gr); 
                rec.SpeechRecognized += rec_SpeechRecognized;
                rec.SetInputToDefaultAudioDevice(); 
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }            
        }

        private void MUI_Load(object sender, EventArgs e)
        {
            Title.Text = "NOVA MUI v" + main.version();
            this.tableTableAdapter.Fill(this.dbDataSet.Table); // Loads data into the 'dbDataSet.Table' table.           
            BOOT(); // MUI necessary fuctions activating.
            Print(cOUT.Text.Replace("v1.0  Build <build-1016>", main.welcome()));
        }
        /*************************************************************************************************************/

        public void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String UWord = e.Result.Text;
            if (UWord != "")
            {
                xOUT.Text = input.Text;
                cBACK.BackColor = Color.FromArgb(12, 88, 12);
                if (UWord == "hello") { Print("Hello, How are you"); }
                else if (UWord == "hi") { Print("Hi, You're welcome"); }
                else if (UWord == "good") { Print("Thank you <username>."); }
                else if (UWord == "open web") { Process.Start("msedge.exe"); Print("Now opening edge browser."); }
                else if (UWord == "hey") { Print("What do you want <username>."); }
                else if (UWord == "what is your name") { Print("I am Nova " + main.welcome() + "."); }
                else if (UWord == "thank you") { Print("You're welcome <username>."); }
                else if (UWord == "close" | UWord == "exit" | UWord == "shut down") { SHUTDOWN(); }
                UWord = "";
                cBACK.BackColor = Color.FromArgb(12, 48, 12);
            }
        }

        private void input_Click(object sender, EventArgs e)
        {
            input.Clear();
        }

        private void MUI_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        private void MUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void MUI_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            SHUTDOWN();
        }

        private void btnX_MouseMove(object sender, MouseEventArgs e)
        {
            btnX.ForeColor = Color.FromArgb(12, 255, 32);
        }

        private void btnX_MouseLeave(object sender, EventArgs e)
        {
            btnX.ForeColor = Color.FromArgb(12, 198, 52);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimize.ForeColor = Color.FromArgb(12, 255, 32);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.FromArgb(12, 198, 52);
        }

        private void input_MouseMove(object sender, MouseEventArgs e)
        {
            input.ForeColor = Color.FromArgb(18, 232, 32);
            input.BackColor = Color.FromArgb(2, 8, 2);
        }

        private void input_MouseLeave(object sender, EventArgs e)
        {
            if (isinput == false)
            {
                input.ForeColor = Color.FromArgb(18, 220, 32);
                input.BackColor = Color.FromArgb(4, 12, 4);
            }
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            input.ForeColor = Color.FromArgb(18, 244, 32);
            input.BackColor = Color.FromArgb(0, 6, 0);
        }

        private void input_KeyUp(object sender, KeyEventArgs e)
        {
            input.ForeColor = Color.FromArgb(18, 224, 32);
            input.BackColor = Color.FromArgb(0, 8, 0);
        }

        private void input_Enter(object sender, EventArgs e)
        {
            isinput = true;
            input.ForeColor = Color.FromArgb(18, 232, 32);
            input.BackColor = Color.FromArgb(2, 8, 2);
            inBack.BackColor = Color.FromArgb(12, 98, 12);
        }

        private void input_Leave(object sender, EventArgs e)
        {
            isinput = false;
            input.ForeColor = Color.FromArgb(18, 220, 32);
            input.BackColor = Color.FromArgb(4, 12, 4);
            inBack.BackColor = Color.FromArgb(12, 48, 12);
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEARCH();
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            btnOK.BackColor = Color.WhiteSmoke;
            btnOK.BackColor = Color.FromArgb(18, 200, 32);
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.ForeColor = Color.Gainsboro;
            btnOK.BackColor = Color.FromArgb(18, 190, 20);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SEARCH();
        }

        private void btnOK_MouseDown(object sender, MouseEventArgs e)
        {
            btnOK.BackColor = Color.FromArgb(8, 175, 12);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len > counter)
            {
                xBACK.BackColor = Color.FromArgb(12, 48, 12);
                cBACK.BackColor = Color.FromArgb(12, 88, 12);
                counter++;
                cOUT.Text = text.Substring(0, counter);
            }
            else
            {
                cBACK.BackColor = Color.FromArgb(12, 48, 12);
                inBack.BackColor = Color.FromArgb(12, 48, 12);
                timer1.Enabled = false;
            }
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            NV_CLOCK(false);
        }

        private void TimerX_Tick(object sender, EventArgs e)
        {
            if (timeX < 36) { timeX++; }
            else { Application.Exit(); }
        }

        private void MUI_Deactivate(object sender, EventArgs e)
        {
            inBack.BackColor = Color.FromArgb(12, 48, 12);
        }

        private void MUI_Activated(object sender, EventArgs e)
        {
            inBack.BackColor = Color.FromArgb(12, 98, 12);
        }


        public void BOOT()
        {
            SET_UNAME(); // Set default username           
            Set_Speech(); // Set Speech settings
            TIMER.Enabled = true;

        }

        public void Say(string text)
        {
            speechS.Speak(text);
        }

        public void Set_Speech()
        {
            SEARCH_DAT("NV_volume");
            speechS.Volume = Convert.ToInt32(dbC.Text);
            speechS.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen); // set voice preferences
        }       

        public void SET_UNAME()
        {
            tableBindingSource.Filter = "input LIKE '" + "CX" + "%'";
            user = NV_AES.Decrypt(dbC.Text);
            xLB.Text = "-: " + user;
            if (user.Length >= 11)
            {
                Point p1 = new Point(416, 180);
                Point p2 = new Point(114, 177);
                xLB.Location = p1;
                xBACK.Location = p2;
            }
            else if (user.Length >= 10)
            {
                Point p1 = new Point(433, 180);
                Point p2 = new Point(128, 177);
                xLB.Location = p1;
                xBACK.Location = p2;
            }
            else if (user.Length >= 8)
            {
                Point p1 = new Point(449, 180);
                Point p2 = new Point(143, 177);
                xLB.Location = p1;
                xBACK.Location = p2;
            }

            else if (user.Length >= 6)
            {
                Point p1 = new Point(468, 180);
                Point p2 = new Point(164, 177);
                xLB.Location = p1;
                xBACK.Location = p2;
            }
        }

        public void SAVE_DAT()
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);
        }

        public void SEARCH_DAT(string dat)
        {
            tableBindingSource.Filter = "input LIKE '" + dat + "%'";
        }

        public void SAVE_MSG(string message)
        {
            tableBindingSource.Filter = "input LIKE '" + "MESSAGE" + "%'";
            dbC.Text = message;
            SAVE_DAT();
        }

        public void Print(string txt)
        {
            txt = txt.Replace("<username>", user);
            txt = txt.Replace("<datetime>", System.DateTime.Now.ToShortTimeString());
            txt = txt.Replace("<datetoday>", System.DateTime.Now.ToShortDateString());
            text = txt;
            cOUT.Text = text;
            Say(text);
        }

        public void NV_CLOCK(bool mode)
        {
            if (mode != true)
            {
                if (timeN < 10)
                {
                    timeN += 1;
                }
                else
                {
                    timeN = 0;
                    if (timeS < 60)
                    {
                        timeS++;
                    }
                    else
                    {
                        timeS = 0;
                        if (timeM < 60)
                        {
                            timeM++;
                        }
                        else
                        {
                            timeM = 0;
                            timeH++;
                        }
                    }
                }
                //UPTIME(); // Save up time to DB.
            }
            else
            {
                string timeHs = timeH.ToString();
                string timeMs = timeM.ToString();
                string timeSs = timeS.ToString();
                string timeNs = timeN.ToString();
                if (timeHs.Length != 2) { timeHs += "0"; timeHs.Reverse(); }
                if (timeMs.Length != 2) { timeMs += "0"; timeMs.Reverse(); }
                if (timeSs.Length != 2) { timeSs += "0"; timeSs.Reverse(); }
                if (timeNs.Length != 2) { timeNs += "0"; timeNs.Reverse(); }
                clockTime =
                clockTime = timeHs + ":" + timeMs + ":" + timeSs + ":" + timeNs;
                Print("NOVA - UP TIME : " + clockTime);
            }
        }       

        /* public void UPTIME()
         {
             int time0N, time0S, time0M, time0H;
             tableBindingSource.Filter = "input LIKE 'NV_time0.nsecs%'";
             time0N = Convert.ToInt32(dbC.Text); time0N += timeN;
             SEARCH_DAT("NV_time0.nsecs"); dbC.Text = time0N.ToString(); SAVE_DAT();
             tableBindingSource.Filter = "input LIKE 'NV_time0.secs%'";
             time0S = Convert.ToInt32(dbC.Text); time0S += timeS;
             SEARCH_DAT("NV_time0.secs"); dbC.Text = time0S.ToString(); SAVE_DAT();
             tableBindingSource.Filter = "input LIKE 'NV_time0.mins%'";
             time0M = Convert.ToInt32(dbC.Text); time0M += timeM; 
             SEARCH_DAT("NV_time0.mins"); dbC.Text = time0M.ToString(); SAVE_DAT();
             tableBindingSource.Filter = "input LIKE 'NV_time0.hours%'";
             time0H = Convert.ToInt32(dbC.Text); time0H += timeH; 
             SEARCH_DAT("NV_time0.hours"); dbC.Text = time0H.ToString(); SAVE_DAT();
         }        */

        public void ADD_DATA()
        {
            dbX.Text = intxt;
            dbC.Text = ottxt;
            SAVE_DAT();
        }

        public void SEARCH()
        {
            if (command == "")
            {
                string str = input.Text; cmdtxt = input.Text;
                cBACK.BackColor = Color.FromArgb(12, 88, 12);
                xOUT.Text = str;
                input.Clear();

                if (str == "CY")
                {
                    inBack.BackColor = Color.FromArgb(82, 18, 12);
                }
                else if (str == "CX")
                {
                    inBack.BackColor = Color.FromArgb(82, 18, 12);
                }
                else if (str == "run nvrem")
                {
                    Print("'NVREM.exe' is running now...");
                    Process.Start("NVREM.exe");
                    inBack.BackColor = Color.FromArgb(12, 88, 12);
                }
                else if (str == "credits")
                {
                    string text = "This computer program was developed by Dewnith Fernando aka DvNET.";
                    Print(text);
                }
                else if (str == "up time")
                {
                    NV_CLOCK(true);
                }
                else if (str == "add")
                {
                    Print("<username>, you're selected data adding. Please type the 'input'and press enter.");
                    command = "data-add";
                }
                else if (str == "change volume")
                {
                    Print("The previous volume is " + speechS.Volume.ToString() + ". Enter the new value of volume.");
                    command = "change-vol";
                }
                else if (str == "don't")
                {
                    RUN_CMD(str);
                }
                else if (str == "good bye")
                {
                    SHUTDOWN();
                }
                else if (str == "change username")
                {
                    Print(user + ", You selected 'username changing'. Type the new username and press enter. This will be used as your future username.");
                    command = "change-uname";
                }
                else
                {
                    try
                    {
                        tableBindingSource.Filter = "input LIKE '" + str + "%'"; // search for output data from database.
                        if (dbC.Text != "") Print(dbC.Text);
                        else
                        {
                            Print("<username>, I don't know about '" + str + "'. Do you want to teach me about '" + str + "'?");
                            temp = str;
                            command = "adding-data";
                        }
                    }
                    catch (Exception)
                    {
                        Print("Error occured!");
                    }
                }
            }
            else
            {
                cmdtxt = input.Text;
                RUN_CMD(cmdtxt);
            }
            cBACK.BackColor = Color.FromArgb(12, 48, 12);
        }

        public void RUN_CMD(string str)
        {
            if (command == "change-vol")
            {
                input.Clear();
                SEARCH_DAT("NV_volume");
                dbC.Text = str;
                SAVE_DAT();
                Set_Speech();
                cBACK.BackColor = Color.FromArgb(12, 88, 12);
                Print("Volume updated successfully!");
                cBACK.BackColor = Color.FromArgb(12, 48, 12);
                command = "";
            }
            else if (command == "shut-down")
            {
                TimerX.Stop();
                cBACK.BackColor = Color.FromArgb(12, 88, 12);
                Print("<username>, you cancelled your previous command that you wanted to shutdown me.");
                cBACK.BackColor = Color.FromArgb(12, 48, 12);
                command = "";
            }
            else if (command == "change-uname")
            {
                xOUT.Text = input.Text;
                input.Clear();
                SEARCH_DAT("CX");
                dbC.Text = NV_AES.Encrypt(xOUT.Text);
                SAVE_DAT();
                BOOT();
                cBACK.BackColor = Color.FromArgb(12, 88, 12);
                Print("Username updated successfully!");
                cBACK.BackColor = Color.FromArgb(12, 48, 12);
                command = "";
            }
            else if (command == "adding-data")
            {
                if (input.Text == "yes" | input.Text == "y" | input.Text == "ok")
                {
                    input.Clear();
                    cBACK.BackColor = Color.FromArgb(12, 88, 12);
                    Print("<username>, you can enter data about '" + temp + "' to save.");
                    cBACK.BackColor = Color.FromArgb(12, 48, 12);
                    btnOK.Text = "Save";
                    command = "save-dat";
                }
                else
                {
                    cBACK.BackColor = Color.FromArgb(12, 88, 12);
                    Print("Ok, Fine.");
                    cBACK.BackColor = Color.FromArgb(12, 48, 12);
                    command = "";
                }
            }
            else if (command == "save-dat")
            {
                dbX.Text = xOUT.Text;
                dbC.Text = input.Text;
                xOUT.Text = input.Text;
                SAVE_DAT();
                temp = "";
                input.Clear();
                btnOK.Text = "Send";
                cBACK.BackColor = Color.FromArgb(12, 88, 12);
                Print("<username>, database updated successfully!");
                cBACK.BackColor = Color.FromArgb(12, 48, 12);
                command = "";
            }

        }

        public void SHUTDOWN()
        {
            cBACK.BackColor = Color.FromArgb(12, 88, 12);
            Print("Nova is shutting down.");
            cBACK.BackColor = Color.FromArgb(12, 48, 12);
            TimerX.Enabled = true;
            command = "shut-down";
        }
    }
}
