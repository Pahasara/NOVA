namespace NOVA
{
    partial class MUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MUI));
            this.btnX = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.inBack = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.dbDataSet = new NOVA.dbDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new NOVA.dbDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new NOVA.dbDataSetTableAdapters.TableAdapterManager();
            this.dbX = new System.Windows.Forms.TextBox();
            this.dbC = new System.Windows.Forms.TextBox();
            this.cBACK = new System.Windows.Forms.Panel();
            this.cOUT = new System.Windows.Forms.Label();
            this.cLB = new System.Windows.Forms.Label();
            this.xBACK = new System.Windows.Forms.Panel();
            this.xOUT = new System.Windows.Forms.Label();
            this.xLB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inputLB = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_TTL = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.TimerX = new System.Windows.Forms.Timer(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.inBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.cBACK.SuspendLayout();
            this.xBACK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_TTL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(198)))), ((int)(((byte)(52)))));
            this.btnX.Location = new System.Drawing.Point(546, 1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(32, 26);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            this.btnX.MouseLeave += new System.EventHandler(this.btnX_MouseLeave);
            this.btnX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnX_MouseMove);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(4)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(220)))), ((int)(((byte)(32)))));
            this.input.Location = new System.Drawing.Point(134, 325);
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.input.Size = new System.Drawing.Size(348, 15);
            this.input.TabIndex = 1;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input.Click += new System.EventHandler(this.input_Click);
            this.input.Enter += new System.EventHandler(this.input_Enter);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_KeyUp);
            this.input.Leave += new System.EventHandler(this.input_Leave);
            this.input.MouseLeave += new System.EventHandler(this.input_MouseLeave);
            this.input.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_MouseMove);
            // 
            // inBack
            // 
            this.inBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.inBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inBack.Controls.Add(this.btnOK);
            this.inBack.Location = new System.Drawing.Point(133, 324);
            this.inBack.Name = "inBack";
            this.inBack.Size = new System.Drawing.Size(404, 17);
            this.inBack.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(190)))), ((int)(((byte)(20)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(174)))), ((int)(((byte)(17)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(205)))), ((int)(((byte)(20)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOK.Location = new System.Drawing.Point(350, -2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 20);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Send";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseDown);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseMove);
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
            // dbX
            // 
            this.dbX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Input", true));
            this.dbX.Location = new System.Drawing.Point(128, 378);
            this.dbX.Name = "dbX";
            this.dbX.Size = new System.Drawing.Size(100, 20);
            this.dbX.TabIndex = 4;
            // 
            // dbC
            // 
            this.dbC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Output", true));
            this.dbC.Location = new System.Drawing.Point(342, 378);
            this.dbC.Name = "dbC";
            this.dbC.Size = new System.Drawing.Size(100, 20);
            this.dbC.TabIndex = 6;
            // 
            // cBACK
            // 
            this.cBACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.cBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cBACK.Controls.Add(this.cOUT);
            this.cBACK.Location = new System.Drawing.Point(86, 58);
            this.cBACK.Name = "cBACK";
            this.cBACK.Size = new System.Drawing.Size(300, 82);
            this.cBACK.TabIndex = 8;
            // 
            // cOUT
            // 
            this.cOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(4)))));
            this.cOUT.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold);
            this.cOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(220)))), ((int)(((byte)(32)))));
            this.cOUT.Location = new System.Drawing.Point(1, 1);
            this.cOUT.Name = "cOUT";
            this.cOUT.Size = new System.Drawing.Size(298, 80);
            this.cOUT.TabIndex = 11;
            this.cOUT.Text = "I AM NOVA v1.0  Build <build-1016>.";
            // 
            // cLB
            // 
            this.cLB.AutoSize = true;
            this.cLB.BackColor = System.Drawing.Color.Transparent;
            this.cLB.Font = new System.Drawing.Font("Robot Reavers", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(182)))), ((int)(((byte)(10)))));
            this.cLB.Location = new System.Drawing.Point(12, 60);
            this.cLB.Name = "cLB";
            this.cLB.Size = new System.Drawing.Size(69, 12);
            this.cLB.TabIndex = 9;
            this.cLB.Text = "NOVA :-";
            // 
            // xBACK
            // 
            this.xBACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(12)))));
            this.xBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.xBACK.Controls.Add(this.xOUT);
            this.xBACK.Location = new System.Drawing.Point(188, 177);
            this.xBACK.Name = "xBACK";
            this.xBACK.Size = new System.Drawing.Size(300, 82);
            this.xBACK.TabIndex = 9;
            // 
            // xOUT
            // 
            this.xOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(4)))));
            this.xOUT.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold);
            this.xOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(220)))), ((int)(((byte)(32)))));
            this.xOUT.Location = new System.Drawing.Point(1, 1);
            this.xOUT.Name = "xOUT";
            this.xOUT.Size = new System.Drawing.Size(298, 80);
            this.xOUT.TabIndex = 12;
            // 
            // xLB
            // 
            this.xLB.AutoSize = true;
            this.xLB.BackColor = System.Drawing.Color.Transparent;
            this.xLB.Font = new System.Drawing.Font("Robot Reavers", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(182)))), ((int)(((byte)(10)))));
            this.xLB.Location = new System.Drawing.Point(492, 180);
            this.xLB.Name = "xLB";
            this.xLB.Size = new System.Drawing.Size(69, 12);
            this.xLB.TabIndex = 10;
            this.xLB.Text = "-: USER";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputLB
            // 
            this.inputLB.AutoSize = true;
            this.inputLB.BackColor = System.Drawing.Color.Transparent;
            this.inputLB.Font = new System.Drawing.Font("Robot Reavers", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(182)))), ((int)(((byte)(10)))));
            this.inputLB.Location = new System.Drawing.Point(45, 327);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(73, 12);
            this.inputLB.TabIndex = 11;
            this.inputLB.Text = "INPUT :-";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.Title.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(182)))), ((int)(((byte)(10)))));
            this.Title.Location = new System.Drawing.Point(186, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(179, 19);
            this.Title.TabIndex = 13;
            this.Title.Text = "NOVA MUI v1.0.1016.0";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.label1.Font = new System.Drawing.Font("Robot Reavers", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(200)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(49, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "DVN3T";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NOVA.Properties.Resources.NOVA_ICON;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_TTL
            // 
            this.Panel_TTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.Panel_TTL.Controls.Add(this.btnX);
            this.Panel_TTL.Controls.Add(this.btnMinimize);
            this.Panel_TTL.Controls.Add(this.pictureBox1);
            this.Panel_TTL.Controls.Add(this.label1);
            this.Panel_TTL.Controls.Add(this.Title);
            this.Panel_TTL.Location = new System.Drawing.Point(-2, 0);
            this.Panel_TTL.Name = "Panel_TTL";
            this.Panel_TTL.Size = new System.Drawing.Size(581, 29);
            this.Panel_TTL.TabIndex = 16;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(198)))), ((int)(((byte)(52)))));
            this.btnMinimize.Location = new System.Drawing.Point(511, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 35);
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseMove);
            // 
            // TIMER
            // 
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // TimerX
            // 
            this.TimerX.Tick += new System.EventHandler(this.TimerX_Tick);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lbl2.Location = new System.Drawing.Point(-3, 358);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(594, 24);
            this.lbl2.TabIndex = 17;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lbl3.Location = new System.Drawing.Point(578, 17);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(10, 349);
            this.lbl3.TabIndex = 19;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lbl4.Location = new System.Drawing.Point(-9, 17);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(10, 349);
            this.lbl4.TabIndex = 20;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 0;
            this.elipseControl1.TargetControl = this;
            // 
            // MUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.Panel_TTL);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.inputLB);
            this.Controls.Add(this.xLB);
            this.Controls.Add(this.cLB);
            this.Controls.Add(this.input);
            this.Controls.Add(this.cBACK);
            this.Controls.Add(this.dbC);
            this.Controls.Add(this.dbX);
            this.Controls.Add(this.inBack);
            this.Controls.Add(this.xBACK);
            this.Controls.Add(this.lbl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MUI";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVA MUI";
            this.Activated += new System.EventHandler(this.MUI_Activated);
            this.Deactivate += new System.EventHandler(this.MUI_Deactivate);
            this.Load += new System.EventHandler(this.MUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MUI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MUI_MouseUp);
            this.inBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.cBACK.ResumeLayout(false);
            this.xBACK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_TTL.ResumeLayout(false);
            this.Panel_TTL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Panel inBack;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private dbDataSet dbDataSet;
        private dbDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox dbC;
        private System.Windows.Forms.TextBox dbX;
        private System.Windows.Forms.Panel cBACK;
        private System.Windows.Forms.Label xLB;
        private System.Windows.Forms.Label cLB;
        private System.Windows.Forms.Label cOUT;
        private System.Windows.Forms.Panel xBACK;
        private System.Windows.Forms.Label xOUT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label inputLB;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_TTL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Timer TimerX;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
    }
}