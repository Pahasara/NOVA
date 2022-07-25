using NOVA.Properties;
using System;
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
    public partial class MSG : Form
    {
        NOVA_CORE.main main = new NOVA_CORE.main();
        NOVA_CORE.Aes_Opr NV_AES = new NOVA_CORE.Aes_Opr();
        public MSG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void MSG_Load(object sender, EventArgs e)
        {
            // Loads data into the 'dbDataSet.Table' table.
            this.tableTableAdapter.Fill(this.dbDataSet.Table);

            // Get username from table
            tableBindingSource.Filter = "input LIKE '" + "CX" + "%'";
            string username = NV_AES.Decrypt(output.Text);

            // Get message from table
            tableBindingSource.Filter = "input LIKE '" + "MESSAGE" + "%'";

            if (output.Text == "") 
            { 
                this.Close();
            }
            else if (output.Text == "NEWUSER")
            {
                tableBindingSource.Filter = "input LIKE '" + "NV_newuser_login_msg" + "%'";
                string txt = output.Text;
                txt = txt.Replace("<username>", username);
                txt = txt.Replace("<build>", main.build());
                txt = txt.Replace("<version>", main.vernu());
                txt = txt.Replace("<reldate>", main.reldate());
                Xmsg.Text = txt;
                tableBindingSource.Filter = "input LIKE '" + "NV_newuser_login_ttl" + "%'";
                Tmsg.Text = output.Text;
            } 
            else if(output.Text == "LOGINERROR")
            {
                tableBindingSource.Filter = "input LIKE '" + "LG_error_pass_msg" + "%'";
                Xmsg.Text = output.Text;
                tableBindingSource.Filter = "input LIKE '" + "LG_error_pass_ttl" + "%'";
                Tmsg.Text = output.Text;          
            }
            else if(output.Text == "USERNAME_NULL_ERROR")
            {
                tableBindingSource.Filter = "input LIKE '" + "NU_sign_error_unnull_msg" + "%'";
                Xmsg.Text = output.Text;
                tableBindingSource.Filter = "input LIKE '" + "NU_sign_error_unnull_ttl" + "%'";
                Tmsg.Text = output.Text;
            }
            else if(output.Text == "WELCOME")
            {
                tableBindingSource.Filter = "input LIKE '" + "US_welcome_msg" + "%'";
                Xmsg.Text = output.Text.Replace("<username>", username);
                tableBindingSource.Filter = "input LIKE '" + "US_welcome_ttl" + "%'";
                Tmsg.Text = output.Text;
            }
        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void tableBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        public void SAVE(string message)
        {
            tableBindingSource.Filter = "input LIKE '" + "MESSAGE" + "%'";
            output.Text = message;
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);
        }
    }
}
