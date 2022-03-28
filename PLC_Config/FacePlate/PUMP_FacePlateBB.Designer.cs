
namespace PLC_Config
{
    partial class PUMP_FacePlateBB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUMP_FacePlateBB));
            this.groupBox_Device = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_TimeHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sb_Status = new SymbolFactoryDotNet.StandardControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.bt_Start = new System.Windows.Forms.Button();
            this.bt_Manual = new System.Windows.Forms.Button();
            this.bt_Auto = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Device.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Status)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Device
            // 
            this.groupBox_Device.Controls.Add(this.label4);
            this.groupBox_Device.Controls.Add(this.lb_TimeHD);
            this.groupBox_Device.Controls.Add(this.label1);
            this.groupBox_Device.Controls.Add(this.label3);
            this.groupBox_Device.Controls.Add(this.sb_Status);
            this.groupBox_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Device.Location = new System.Drawing.Point(12, 4);
            this.groupBox_Device.Name = "groupBox_Device";
            this.groupBox_Device.Size = new System.Drawing.Size(184, 153);
            this.groupBox_Device.TabIndex = 0;
            this.groupBox_Device.TabStop = false;
            this.groupBox_Device.Text = "NAME OF DEVICE";
            this.groupBox_Device.Enter += new System.EventHandler(this.groupBox_Device_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 497;
            this.label4.Text = "M";
            // 
            // lb_TimeHD
            // 
            this.lb_TimeHD.AutoSize = true;
            this.lb_TimeHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeHD.Location = new System.Drawing.Point(81, 106);
            this.lb_TimeHD.Name = "lb_TimeHD";
            this.lb_TimeHD.Size = new System.Drawing.Size(76, 16);
            this.lb_TimeHD.TabIndex = 496;
            this.lb_TimeHD.Text = "####.####";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 495;
            this.label1.Text = "TIME HD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 494;
            this.label3.Text = "STATE";
            // 
            // sb_Status
            // 
            this.sb_Status.AnalogIntValue1 = ((short)(0));
            this.sb_Status.AnalogValue1 = 0D;
            this.sb_Status.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sb_Status.BackColor = System.Drawing.Color.Transparent;
            this.sb_Status.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sb_Status.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.sb_Status.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.sb_Status.BlinkColor = System.Drawing.Color.Red;
            this.sb_Status.Category = "1Btn.cat2";
            this.sb_Status.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sb_Status.DebugData"));
            this.sb_Status.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sb_Status.Location = new System.Drawing.Point(105, 35);
            this.sb_Status.Name = "sb_Status";
            this.sb_Status.Size = new System.Drawing.Size(45, 50);
            this.sb_Status.SymbolHandle = ((long)(646493301));
            this.sb_Status.TabIndex = 491;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Stop);
            this.groupBox2.Controls.Add(this.bt_Start);
            this.groupBox2.Controls.Add(this.bt_Manual);
            this.groupBox2.Controls.Add(this.bt_Auto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(202, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐIỀU KHIỂN";
            // 
            // bt_Stop
            // 
            this.bt_Stop.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_Stop.Location = new System.Drawing.Point(93, 94);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(80, 41);
            this.bt_Stop.TabIndex = 3;
            this.bt_Stop.Text = "STOP";
            this.bt_Stop.UseVisualStyleBackColor = false;
            this.bt_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_Stop_MouseDown);
            this.bt_Stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_Stop_MouseUp);
            // 
            // bt_Start
            // 
            this.bt_Start.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_Start.Location = new System.Drawing.Point(6, 94);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(80, 41);
            this.bt_Start.TabIndex = 2;
            this.bt_Start.Text = "START";
            this.bt_Start.UseVisualStyleBackColor = false;
            this.bt_Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_Start_MouseDown);
            this.bt_Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_Start_MouseUp);
            // 
            // bt_Manual
            // 
            this.bt_Manual.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_Manual.Location = new System.Drawing.Point(93, 35);
            this.bt_Manual.Name = "bt_Manual";
            this.bt_Manual.Size = new System.Drawing.Size(80, 41);
            this.bt_Manual.TabIndex = 1;
            this.bt_Manual.Text = "MANU";
            this.bt_Manual.UseVisualStyleBackColor = false;
            this.bt_Manual.Click += new System.EventHandler(this.bt_Manual_Click);
            // 
            // bt_Auto
            // 
            this.bt_Auto.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_Auto.Location = new System.Drawing.Point(7, 35);
            this.bt_Auto.Name = "bt_Auto";
            this.bt_Auto.Size = new System.Drawing.Size(80, 41);
            this.bt_Auto.TabIndex = 0;
            this.bt_Auto.Text = "AUTO";
            this.bt_Auto.UseVisualStyleBackColor = false;
            this.bt_Auto.Click += new System.EventHandler(this.bt_Auto_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PUMP_FacePlateBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 162);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_Device);
            this.Name = "PUMP_FacePlateBB";
            this.Text = "PUMP";
            this.groupBox_Device.ResumeLayout(false);
            this.groupBox_Device.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Status)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Device;
        private System.Windows.Forms.GroupBox groupBox2;
        private SymbolFactoryDotNet.StandardControl sb_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Button bt_Manual;
        private System.Windows.Forms.Button bt_Auto;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_TimeHD;
        private System.Windows.Forms.Label label1;
    }
}