namespace NOVA
{
    partial class MSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSG));
            this.button1 = new System.Windows.Forms.Button();
            this.RAD_MSG = new ElipseToolDemo.ElipseControl();
            this.Tmsg = new System.Windows.Forms.Label();
            this.Xmsg = new System.Windows.Forms.Label();
            this.dbDataSet = new NOVA.dbDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new NOVA.dbDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new NOVA.dbDataSetTableAdapters.TableAdapterManager();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(18)))), ((int)(((byte)(8)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(128)))), ((int)(((byte)(8)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(8)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(48)))), ((int)(((byte)(8)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Zen Os", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(190)))), ((int)(((byte)(22)))));
            this.button1.Location = new System.Drawing.Point(149, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RAD_MSG
            // 
            this.RAD_MSG.CornerRadius = 1;
            this.RAD_MSG.TargetControl = this;
            // 
            // Tmsg
            // 
            this.Tmsg.BackColor = System.Drawing.Color.Transparent;
            this.Tmsg.Font = new System.Drawing.Font("Neptune Lander", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(239)))), ((int)(((byte)(7)))));
            this.Tmsg.Location = new System.Drawing.Point(43, 18);
            this.Tmsg.Name = "Tmsg";
            this.Tmsg.Size = new System.Drawing.Size(284, 31);
            this.Tmsg.TabIndex = 6;
            this.Tmsg.Text = "Test 000";
            this.Tmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Xmsg
            // 
            this.Xmsg.BackColor = System.Drawing.Color.Transparent;
            this.Xmsg.Font = new System.Drawing.Font("Android 101", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(239)))), ((int)(((byte)(7)))));
            this.Xmsg.Location = new System.Drawing.Point(15, 60);
            this.Xmsg.Name = "Xmsg";
            this.Xmsg.Size = new System.Drawing.Size(339, 87);
            this.Xmsg.TabIndex = 7;
            this.Xmsg.Text = "test 001";
            this.Xmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dbDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = NOVA.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // input
            // 
            this.input.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Input", true));
            this.input.Location = new System.Drawing.Point(106, 264);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 9;
            // 
            // output
            // 
            this.output.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Output", true));
            this.output.Location = new System.Drawing.Point(320, 264);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(368, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 203);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label2.Location = new System.Drawing.Point(-16, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 203);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label3.Location = new System.Drawing.Point(-9, -19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 20);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label4.Location = new System.Drawing.Point(-19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 24);
            this.label4.TabIndex = 14;
            // 
            // MSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NOVA.Properties.Resources.NOVA_MSG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 195);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Xmsg);
            this.Controls.Add(this.Tmsg);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSG";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVA MESSAGE";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MSG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ElipseToolDemo.ElipseControl RAD_MSG;
        private System.Windows.Forms.Label Xmsg;
        private System.Windows.Forms.Label Tmsg;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private dbDataSet dbDataSet;
        private dbDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}