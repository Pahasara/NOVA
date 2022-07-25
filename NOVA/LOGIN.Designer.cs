namespace NOVA
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.CX = new System.Windows.Forms.TextBox();
            this.CY = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inBACK = new System.Windows.Forms.Label();
            this.outBACK = new System.Windows.Forms.Label();
            this.dbDataSet = new NOVA.dbDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new NOVA.dbDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new NOVA.dbDataSetTableAdapters.TableAdapterManager();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.RAD_LOGIN = new ElipseToolDemo.ElipseControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnLOGIN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(8)))));
            this.btnLOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(18)))), ((int)(((byte)(8)))));
            this.btnLOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(48)))), ((int)(((byte)(8)))));
            this.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGIN.Font = new System.Drawing.Font("Robot Reavers", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnLOGIN.Location = new System.Drawing.Point(91, 140);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(98, 24);
            this.btnLOGIN.TabIndex = 0;
            this.btnLOGIN.Text = "LOGIN";
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // CX
            // 
            this.CX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(6)))));
            this.CX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CX.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(188)))), ((int)(((byte)(32)))));
            this.CX.Location = new System.Drawing.Point(173, 62);
            this.CX.MaxLength = 12;
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(195, 15);
            this.CX.TabIndex = 1;
            this.CX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CX.Click += new System.EventHandler(this.CX_Click);
            this.CX.Enter += new System.EventHandler(this.CX_Enter);
            this.CX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CX_KeyDown);
            this.CX.Leave += new System.EventHandler(this.CX_Leave);
            // 
            // CY
            // 
            this.CY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(6)))));
            this.CY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CY.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(188)))), ((int)(((byte)(32)))));
            this.CY.Location = new System.Drawing.Point(173, 99);
            this.CY.MaxLength = 18;
            this.CY.Name = "CY";
            this.CY.PasswordChar = '*';
            this.CY.Size = new System.Drawing.Size(195, 15);
            this.CY.TabIndex = 2;
            this.CY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CY.Click += new System.EventHandler(this.CY_Click);
            this.CY.Enter += new System.EventHandler(this.CY_Enter);
            this.CY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CY_KeyDown);
            this.CY.Leave += new System.EventHandler(this.CY_Leave);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(8)))));
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(8)))));
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(48)))), ((int)(((byte)(8)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Robot Reavers", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnX.Location = new System.Drawing.Point(236, 140);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(98, 24);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "CANCEL";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Zen Os", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(170)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Zen Os", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(170)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password :";
            // 
            // inBACK
            // 
            this.inBACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(3)))));
            this.inBACK.Location = new System.Drawing.Point(172, 61);
            this.inBACK.Name = "inBACK";
            this.inBACK.Size = new System.Drawing.Size(197, 17);
            this.inBACK.TabIndex = 10;
            // 
            // outBACK
            // 
            this.outBACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(3)))));
            this.outBACK.Location = new System.Drawing.Point(172, 98);
            this.outBACK.Name = "outBACK";
            this.outBACK.Size = new System.Drawing.Size(197, 17);
            this.outBACK.TabIndex = 11;
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
            this.input.Location = new System.Drawing.Point(130, 201);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 13;
            // 
            // output
            // 
            this.output.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Output", true));
            this.output.Location = new System.Drawing.Point(283, 201);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 14;
            // 
            // RAD_LOGIN
            // 
            this.RAD_LOGIN.CornerRadius = 10;
            this.RAD_LOGIN.TargetControl = this;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label4.Location = new System.Drawing.Point(-1, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 64);
            this.label4.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label3.Location = new System.Drawing.Point(-4, -59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 60);
            this.label3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label5.Location = new System.Drawing.Point(-16, -23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 243);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.label6.Location = new System.Drawing.Point(418, -23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 243);
            this.label6.TabIndex = 15;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 182);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.CY);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.inBACK);
            this.Controls.Add(this.outBACK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVA LOGIN PORTAL";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.TextBox CX;
        private System.Windows.Forms.TextBox CY;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inBACK;
        private System.Windows.Forms.Label outBACK;
        private ElipseToolDemo.ElipseControl RAD_LOGIN;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private dbDataSet dbDataSet;
        private dbDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}