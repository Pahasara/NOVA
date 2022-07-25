using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOVA_REMINDER
{
    public partial class REMUI : Form
    {
        private bool drag = false; 
        private Point startPoint = new Point(0, 0);
        public REMUI()
        {
            InitializeComponent();
        }

        private void Titile_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location; this.drag = true;
        }

        private void Titile_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag) 
            { Point p1 = new Point(e.X, e.Y);         
              Point p2 = this.PointToScreen(p1); 
              Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y); 
              this.Location = p3; 
            }
        }

        private void Titile_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }
        private void Caption_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location; this.drag = true;
        }

        private void Caption_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void Caption_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            TIMER1.Enabled = true;
            ETime();
        }

        private void ClsBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TIMER1_Tick(object sender, EventArgs e)
        {
            string time1 = DateTime.Now.ToShortTimeString();
            time1 = time1.Replace(":", " : ");
            TimeLB.Text = time1;
        }

        private void RMD1_Click(object sender, EventArgs e)
        {
            RMD1.Clear();
        }

        private void RMD2_Click(object sender, EventArgs e)
        {
            RMD2.Clear();
        }

        private void RMD3_Click(object sender, EventArgs e)
        {
            RMD3.Clear();
        }

        private void TIMER2_Tick(object sender, EventArgs e)
        {
            string time1 = TimeLB.Text;
            string time2 = TMH.Text + " : " + TMM.Text + " " + TMT.Text;
            if(time1 == time2) {
                if (checkBox1.Checked == true)
                {   checkBox1.Checked = false;
                    /*MessageBox.Show(RMD1.Text, "NOVA : TIMES UP!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);*/ 
                    MSGBox MSG = new MSGBox(); this.WindowState = FormWindowState.Normal; MSG.Show();  
                } 
                else { TIMER2.Enabled = false; } }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true) 
            { 
                checkBox1.Text = "ON"; 
                TIMER2.Enabled = true; 
            } 
            else { checkBox1.Text = "OFF"; TIMER2.Enabled = false; }
        }

        private void MnzBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;     
        }

        private void RMD1_Enter(object sender, EventArgs e)
        {
            RMD1.BackColor = Color.FromArgb(3, 9, 3);
        }

        private void RMD1_Leave(object sender, EventArgs e)
        {
            RMD1.BackColor = Color.FromArgb(8, 16, 8);
        }

        private void RMD2_Enter(object sender, EventArgs e)
        {
            RMD2.BackColor = Color.FromArgb(3, 9, 3);
        }

        private void RMD2_Leave(object sender, EventArgs e)
        {
            RMD2.BackColor = Color.FromArgb(8, 16, 8);
        }

        private void RMD3_Enter(object sender, EventArgs e)
        {
            RMD3.BackColor = Color.FromArgb(3, 9, 3);
        }

        private void RMD3_Leave(object sender, EventArgs e)
        {
            RMD3.BackColor = Color.FromArgb(8, 16, 8);
        }

        private void TMM_Enter(object sender, EventArgs e)
        {
            TMM.BackColor = Color.FromArgb(0, 0, 8);
        }

        private void TMM_Leave(object sender, EventArgs e)
        {
            TMM.BackColor = Color.FromArgb(5, 12, 5);          
        }

        private void TMH_Enter(object sender, EventArgs e)
        {
            TMH.BackColor = Color.FromArgb(0, 0, 8); ;
        }

        private void TMH_Leave(object sender, EventArgs e)
        {
            TMH.BackColor = Color.FromArgb(5, 12, 5);
        }

        private void TMT_Enter(object sender, EventArgs e)
        {
            TMT.BackColor = Color.FromArgb(0, 0, 8);
        }

        private void TMT_Leave(object sender, EventArgs e)
        {
            TMT.BackColor = Color.FromArgb(5, 12, 5);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ETime()
        {
            int hours = System.DateTime.Now.Hour;
            int minutes = System.DateTime.Now.Minute;
            int m = 60 - minutes;
            if (m <= 10){
                minutes = 10 - m;
                hours++;
                string mint = "0" + minutes.ToString();
                TMM.Text = mint;
            }
            else { 
                minutes += 10;
                string mint = minutes.ToString();
                TMM.Text = mint;
            }
            if(hours > 12)
            {
                TMH.Text = (hours - 12).ToString();
            }
            else
            {
                TMH.Text = hours.ToString();
            }      
            string txt = System.DateTime.Now.ToShortTimeString();
            if(txt.Length == 7)
            {
                txt = txt.Remove(0, 5);
            }
            else { 
                txt = txt.Remove(0, 6);
            }
            TMT.Text = txt;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
