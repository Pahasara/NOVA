﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOVA
{
    public partial class Splash : Form
    {
        int i = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            TIMER.Enabled = true;
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            i += 500;
            if(i == 2000)
            {
                LOGIN login = new LOGIN(); login.Show();
                //REMUI Main = new REMUI(); Main.Show(); 
                this.Hide();
            }
        }
    }
}
