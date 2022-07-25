using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Security.Cryptography;

namespace NOVA
{
    public partial class LOGIN : Form
    {
        NOVA_CORE.Aes_Opr NV_AES = new NOVA_CORE.Aes_Opr();
        public System.Windows.CornerRadius CornerRadius { get; set; }

        bool Nuser = false;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dbDataSet.Table);
            tableBindingSource.Filter = "input LIKE '" + "CX" + "%'";
            if (output.Text == "")
            {
                btnLOGIN.Text = "SignIn";
                Nuser = true;
                tableBindingSource.Filter = "input LIKE '" + "MESSAGE" + "%'";
                output.Text = "NEWUSER";
                SAVEALL();
            }            
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            RUN_LS();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CY_Click(object sender, EventArgs e)
        {
            CY.Clear();     
        }

        private void CX_Click(object sender, EventArgs e)
        {
            CX.Clear();
        }

        private void CX_Enter(object sender, EventArgs e)
        {
            CX.BackColor = Color.FromArgb(0, 6, 0);
            inBACK.BackColor = Color.FromArgb(3, 80, 3);
        }

        private void CY_Enter(object sender, EventArgs e)
        {
            CY.BackColor = Color.FromArgb(0, 6, 0);
            outBACK.BackColor = Color.FromArgb(3, 80, 3);
        }

        private void CY_Leave(object sender, EventArgs e)
        {
            CY.BackColor = Color.FromArgb(5,8,6);
            outBACK.BackColor = Color.FromArgb(3, 20, 3);
        }

        private void CX_Leave(object sender, EventArgs e)
        {
            CX.BackColor = Color.FromArgb(5, 8, 6);
            inBACK.BackColor = Color.FromArgb(3, 20, 3);
        }

        public void SAVEALL()
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);
        }
        private void tableBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        public void MSG(string message)
        {
            tableBindingSource.Filter = "input LIKE '" + "MESSAGE" + "%'";
            output.Text = message;
            SAVEALL();
            MSG welcomeWIN = new MSG(); welcomeWIN.Show();
        }

        private void CX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CY.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                CY.Focus();
            }
        }

        public void RUN_LS()
        {
            if (Nuser == false)
            {
                tableBindingSource.Filter = "input LIKE '" + "CX" + "%'";
                output.Text = NV_AES.Decrypt(output.Text);
                if (CX.Text == output.Text)
                {
                    tableBindingSource.Filter = "input LIKE '" + "CY" + "%'";
                    output.Text = NV_AES.Decrypt(output.Text);
                    if (CY.Text == output.Text)
                    {
                        MUI main = new MUI(); main.Show();
                        MSG("WELCOME");
                        this.Hide();
                    }
                    else
                    {
                        MSG("LOGINERROR");
                    }
                }
                else
                {
                    MSG("LOGINERROR");
                }
            }
            else
            {
                if (CX.Text == "") {
                    MSG("USERNAME_NULL_ERROR");
                }
                else
                {                    
                    tableBindingSource.Filter = "input LIKE '" + "CX" + "%'";
                    CX.Text = NV_AES.Encrypt(CX.Text);
                    output.Text = CX.Text;
                    SAVEALL();

                    tableBindingSource.Filter = "input LIKE '" + "CY" + "%'";
                    CY.Text = NV_AES.Encrypt(CY.Text);
                    output.Text = CY.Text;
                    SAVEALL();

                    MSG("NEWUSER");
                    MUI main = new MUI(); main.Show();
                    this.Hide();
                }
            }
        }

        private void CY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RUN_LS();
            }
            else if (e.KeyCode == Keys.Up)
            {
                CX.Focus();
            }
        }
    }
}
