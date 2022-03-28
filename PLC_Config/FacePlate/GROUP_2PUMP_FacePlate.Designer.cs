
namespace PLC_Config
{
    partial class GROUP_2PUMP_FacePlate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GROUP_2PUMP_FacePlate));
            this.groupBox_Device = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sb_Status_2 = new SymbolFactoryDotNet.StandardControl();
            this.label3 = new System.Windows.Forms.Label();
            this.sb_Status_1 = new SymbolFactoryDotNet.StandardControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_SetTime = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_CurrentVal = new System.Windows.Forms.Label();
            this.txt_TimeLP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_TIme_2_Second = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_TIme_1_Second = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_Time_2_Minute = new System.Windows.Forms.Label();
            this.lb_Time_Total_Second = new System.Windows.Forms.Label();
            this.lb_Time_1_Minute = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_Time_Total_Minute = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Device.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Status_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Status_1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Device
            // 
            this.groupBox_Device.Controls.Add(this.label1);
            this.groupBox_Device.Controls.Add(this.sb_Status_2);
            this.groupBox_Device.Controls.Add(this.label3);
            this.groupBox_Device.Controls.Add(this.sb_Status_1);
            this.groupBox_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Device.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Device.Name = "groupBox_Device";
            this.groupBox_Device.Size = new System.Drawing.Size(200, 105);
            this.groupBox_Device.TabIndex = 2;
            this.groupBox_Device.TabStop = false;
            this.groupBox_Device.Text = "NAME OF DEVICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 496;
            this.label1.Text = "PUMP 2";
            // 
            // sb_Status_2
            // 
            this.sb_Status_2.AnalogIntValue1 = ((short)(0));
            this.sb_Status_2.AnalogValue1 = 0D;
            this.sb_Status_2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sb_Status_2.BackColor = System.Drawing.Color.Transparent;
            this.sb_Status_2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sb_Status_2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.sb_Status_2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.sb_Status_2.BlinkColor = System.Drawing.Color.Red;
            this.sb_Status_2.Category = "1Btn.cat2";
            this.sb_Status_2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sb_Status_2.DebugData"));
            this.sb_Status_2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sb_Status_2.Location = new System.Drawing.Point(132, 21);
            this.sb_Status_2.Name = "sb_Status_2";
            this.sb_Status_2.Size = new System.Drawing.Size(40, 42);
            this.sb_Status_2.SymbolHandle = ((long)(646493301));
            this.sb_Status_2.TabIndex = 495;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 494;
            this.label3.Text = "PUMP 1";
            // 
            // sb_Status_1
            // 
            this.sb_Status_1.AnalogIntValue1 = ((short)(0));
            this.sb_Status_1.AnalogValue1 = 0D;
            this.sb_Status_1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sb_Status_1.BackColor = System.Drawing.Color.Transparent;
            this.sb_Status_1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sb_Status_1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.sb_Status_1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.sb_Status_1.BlinkColor = System.Drawing.Color.Red;
            this.sb_Status_1.Category = "1Btn.cat2";
            this.sb_Status_1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sb_Status_1.DebugData"));
            this.sb_Status_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sb_Status_1.Location = new System.Drawing.Point(36, 21);
            this.sb_Status_1.Name = "sb_Status_1";
            this.sb_Status_1.Size = new System.Drawing.Size(40, 42);
            this.sb_Status_1.SymbolHandle = ((long)(646493301));
            this.sb_Status_1.TabIndex = 491;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_SetTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lb_CurrentVal);
            this.groupBox2.Controls.Add(this.txt_TimeLP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(218, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 104);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROL";
            // 
            // bt_SetTime
            // 
            this.bt_SetTime.Location = new System.Drawing.Point(122, 69);
            this.bt_SetTime.Name = "bt_SetTime";
            this.bt_SetTime.Size = new System.Drawing.Size(68, 24);
            this.bt_SetTime.TabIndex = 5;
            this.bt_SetTime.Text = "SET";
            this.bt_SetTime.UseVisualStyleBackColor = true;
            this.bt_SetTime.Click += new System.EventHandler(this.bt_SetTime_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 501;
            this.label9.Text = "CURRENT VAL";
            // 
            // lb_CurrentVal
            // 
            this.lb_CurrentVal.AutoSize = true;
            this.lb_CurrentVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentVal.Location = new System.Drawing.Point(137, 46);
            this.lb_CurrentVal.Name = "lb_CurrentVal";
            this.lb_CurrentVal.Size = new System.Drawing.Size(48, 16);
            this.lb_CurrentVal.TabIndex = 500;
            this.lb_CurrentVal.Text = "#####";
            // 
            // txt_TimeLP
            // 
            this.txt_TimeLP.Location = new System.Drawing.Point(9, 71);
            this.txt_TimeLP.Name = "txt_TimeLP";
            this.txt_TimeLP.Size = new System.Drawing.Size(99, 22);
            this.txt_TimeLP.TabIndex = 498;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 497;
            this.label2.Text = "TIME LP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Reset);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 495;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIME RESET";
            // 
            // bt_Reset
            // 
            this.bt_Reset.Location = new System.Drawing.Point(30, 49);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(139, 35);
            this.bt_Reset.TabIndex = 4;
            this.bt_Reset.Text = "RESET";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_Reset_MouseDown);
            this.bt_Reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_Reset_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lb_TIme_2_Second);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lb_TIme_1_Second);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lb_Time_2_Minute);
            this.groupBox3.Controls.Add(this.lb_Time_Total_Second);
            this.groupBox3.Controls.Add(this.lb_Time_1_Minute);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lb_Time_Total_Minute);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(218, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 125);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MONITOR";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(185, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "S";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "S";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "S";
            // 
            // lb_TIme_2_Second
            // 
            this.lb_TIme_2_Second.AutoSize = true;
            this.lb_TIme_2_Second.Location = new System.Drawing.Point(147, 93);
            this.lb_TIme_2_Second.Name = "lb_TIme_2_Second";
            this.lb_TIme_2_Second.Size = new System.Drawing.Size(32, 16);
            this.lb_TIme_2_Second.TabIndex = 4;
            this.lb_TIme_2_Second.Text = "###";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(117, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "M";
            // 
            // lb_TIme_1_Second
            // 
            this.lb_TIme_1_Second.AutoSize = true;
            this.lb_TIme_1_Second.Location = new System.Drawing.Point(147, 58);
            this.lb_TIme_1_Second.Name = "lb_TIme_1_Second";
            this.lb_TIme_1_Second.Size = new System.Drawing.Size(32, 16);
            this.lb_TIme_1_Second.TabIndex = 4;
            this.lb_TIme_1_Second.Text = "###";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "M";
            // 
            // lb_Time_2_Minute
            // 
            this.lb_Time_2_Minute.AutoSize = true;
            this.lb_Time_2_Minute.Location = new System.Drawing.Point(79, 93);
            this.lb_Time_2_Minute.Name = "lb_Time_2_Minute";
            this.lb_Time_2_Minute.Size = new System.Drawing.Size(32, 16);
            this.lb_Time_2_Minute.TabIndex = 4;
            this.lb_Time_2_Minute.Text = "###";
            // 
            // lb_Time_Total_Second
            // 
            this.lb_Time_Total_Second.AutoSize = true;
            this.lb_Time_Total_Second.Location = new System.Drawing.Point(147, 26);
            this.lb_Time_Total_Second.Name = "lb_Time_Total_Second";
            this.lb_Time_Total_Second.Size = new System.Drawing.Size(32, 16);
            this.lb_Time_Total_Second.TabIndex = 4;
            this.lb_Time_Total_Second.Text = "###";
            // 
            // lb_Time_1_Minute
            // 
            this.lb_Time_1_Minute.AutoSize = true;
            this.lb_Time_1_Minute.Location = new System.Drawing.Point(79, 58);
            this.lb_Time_1_Minute.Name = "lb_Time_1_Minute";
            this.lb_Time_1_Minute.Size = new System.Drawing.Size(32, 16);
            this.lb_Time_1_Minute.TabIndex = 4;
            this.lb_Time_1_Minute.Text = "###";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "M";
            // 
            // lb_Time_Total_Minute
            // 
            this.lb_Time_Total_Minute.AutoSize = true;
            this.lb_Time_Total_Minute.Location = new System.Drawing.Point(79, 26);
            this.lb_Time_Total_Minute.Name = "lb_Time_Total_Minute";
            this.lb_Time_Total_Minute.Size = new System.Drawing.Size(32, 16);
            this.lb_Time_Total_Minute.TabIndex = 4;
            this.lb_Time_Total_Minute.Text = "###";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "PUMP2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "PUMP1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "TOTAL";
            // 
            // GROUP_2PUMP_FacePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 260);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Device);
            this.Controls.Add(this.groupBox2);
            this.Name = "GROUP_2PUMP_FacePlate";
            this.Text = "GROUP_PUMP_FacePlate";
            this.groupBox_Device.ResumeLayout(false);
            this.groupBox_Device.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Status_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Status_1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Device;
        private System.Windows.Forms.Label label3;
        private SymbolFactoryDotNet.StandardControl sb_Status_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private SymbolFactoryDotNet.StandardControl sb_Status_2;
        private System.Windows.Forms.TextBox txt_TimeLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_TIme_2_Second;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_TIme_1_Second;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_Time_2_Minute;
        private System.Windows.Forms.Label lb_Time_Total_Second;
        private System.Windows.Forms.Label lb_Time_1_Minute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_Time_Total_Minute;
        private System.Windows.Forms.Button bt_SetTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_CurrentVal;
    }
}