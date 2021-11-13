namespace TestFormsC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rbMOE = new System.Windows.Forms.RadioButton();
            this.rbMOI = new System.Windows.Forms.RadioButton();
            this.rbMOS = new System.Windows.Forms.RadioButton();
            this.rbMOH = new System.Windows.Forms.RadioButton();
            this.rbMO5 = new System.Windows.Forms.RadioButton();
            this.rbMO = new System.Windows.Forms.RadioButton();
            this.rbMM = new System.Windows.Forms.RadioButton();
            this.callBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb60s = new System.Windows.Forms.RadioButton();
            this.rb30s = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxStartMode = new System.Windows.Forms.CheckBox();
            this.buttonProg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxFreq = new System.Windows.Forms.ComboBox();
            this.cBoxComPorts = new System.Windows.Forms.ComboBox();
            this.labelOutSrt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDevAnswer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.callBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 56700;
            // 
            // rbMOE
            // 
            this.rbMOE.AutoSize = true;
            this.rbMOE.Location = new System.Drawing.Point(6, 18);
            this.rbMOE.Name = "rbMOE";
            this.rbMOE.Size = new System.Drawing.Size(49, 17);
            this.rbMOE.TabIndex = 0;
            this.rbMOE.Text = "MOE";
            this.rbMOE.UseVisualStyleBackColor = true;
            // 
            // rbMOI
            // 
            this.rbMOI.AutoSize = true;
            this.rbMOI.Location = new System.Drawing.Point(6, 41);
            this.rbMOI.Name = "rbMOI";
            this.rbMOI.Size = new System.Drawing.Size(45, 17);
            this.rbMOI.TabIndex = 1;
            this.rbMOI.Text = "MOI";
            this.rbMOI.UseVisualStyleBackColor = true;
            // 
            // rbMOS
            // 
            this.rbMOS.AutoSize = true;
            this.rbMOS.Location = new System.Drawing.Point(6, 64);
            this.rbMOS.Name = "rbMOS";
            this.rbMOS.Size = new System.Drawing.Size(49, 17);
            this.rbMOS.TabIndex = 2;
            this.rbMOS.Text = "MOS";
            this.rbMOS.UseVisualStyleBackColor = true;
            // 
            // rbMOH
            // 
            this.rbMOH.AutoSize = true;
            this.rbMOH.Location = new System.Drawing.Point(6, 87);
            this.rbMOH.Name = "rbMOH";
            this.rbMOH.Size = new System.Drawing.Size(50, 17);
            this.rbMOH.TabIndex = 3;
            this.rbMOH.Text = "MOH";
            this.rbMOH.UseVisualStyleBackColor = true;
            // 
            // rbMO5
            // 
            this.rbMO5.AutoSize = true;
            this.rbMO5.Location = new System.Drawing.Point(6, 110);
            this.rbMO5.Name = "rbMO5";
            this.rbMO5.Size = new System.Drawing.Size(48, 17);
            this.rbMO5.TabIndex = 4;
            this.rbMO5.Text = "MO5";
            this.rbMO5.UseVisualStyleBackColor = true;
            // 
            // rbMO
            // 
            this.rbMO.AutoSize = true;
            this.rbMO.Checked = true;
            this.rbMO.Location = new System.Drawing.Point(97, 18);
            this.rbMO.Name = "rbMO";
            this.rbMO.Size = new System.Drawing.Size(42, 17);
            this.rbMO.TabIndex = 5;
            this.rbMO.TabStop = true;
            this.rbMO.Text = "MO";
            this.rbMO.UseVisualStyleBackColor = true;
            // 
            // rbMM
            // 
            this.rbMM.AutoSize = true;
            this.rbMM.Location = new System.Drawing.Point(97, 41);
            this.rbMM.Name = "rbMM";
            this.rbMM.Size = new System.Drawing.Size(43, 17);
            this.rbMM.TabIndex = 6;
            this.rbMM.Text = "MM";
            this.rbMM.UseVisualStyleBackColor = true;
            // 
            // callBox
            // 
            this.callBox.Controls.Add(this.rbMOH);
            this.callBox.Controls.Add(this.rbMM);
            this.callBox.Controls.Add(this.rbMOE);
            this.callBox.Controls.Add(this.rbMO);
            this.callBox.Controls.Add(this.rbMOI);
            this.callBox.Controls.Add(this.rbMO5);
            this.callBox.Controls.Add(this.rbMOS);
            this.callBox.Location = new System.Drawing.Point(12, 12);
            this.callBox.Name = "callBox";
            this.callBox.Size = new System.Drawing.Size(188, 139);
            this.callBox.TabIndex = 7;
            this.callBox.TabStop = false;
            this.callBox.Text = "Call";
            this.callBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb30s);
            this.groupBox1.Controls.Add(this.rb60s);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TX Time";
            // 
            // rb60s
            // 
            this.rb60s.AutoSize = true;
            this.rb60s.Checked = true;
            this.rb60s.Location = new System.Drawing.Point(6, 19);
            this.rb60s.Name = "rb60s";
            this.rb60s.Size = new System.Drawing.Size(50, 17);
            this.rb60s.TabIndex = 9;
            this.rb60s.TabStop = true;
            this.rb60s.Text = "1 min";
            this.rb60s.UseVisualStyleBackColor = true;
            // 
            // rb30s
            // 
            this.rb30s.AutoSize = true;
            this.rb30s.Location = new System.Drawing.Point(6, 42);
            this.rb30s.Name = "rb30s";
            this.rb30s.Size = new System.Drawing.Size(57, 17);
            this.rb30s.TabIndex = 10;
            this.rb30s.Text = "30 sec";
            this.rb30s.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxStartMode);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 58);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // cBoxStartMode
            // 
            this.cBoxStartMode.AutoSize = true;
            this.cBoxStartMode.Location = new System.Drawing.Point(6, 19);
            this.cBoxStartMode.Name = "cBoxStartMode";
            this.cBoxStartMode.Size = new System.Drawing.Size(122, 17);
            this.cBoxStartMode.TabIndex = 10;
            this.cBoxStartMode.Text = "Отложенный старт";
            this.cBoxStartMode.UseVisualStyleBackColor = true;
            // 
            // buttonProg
            // 
            this.buttonProg.Location = new System.Drawing.Point(236, 199);
            this.buttonProg.Name = "buttonProg";
            this.buttonProg.Size = new System.Drawing.Size(129, 38);
            this.buttonProg.TabIndex = 10;
            this.buttonProg.Text = "Programm";
            this.buttonProg.UseVisualStyleBackColor = true;
            this.buttonProg.Click += new System.EventHandler(this.buttonProg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBoxFreq);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(206, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 139);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "kHz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Freq range: 3510 - 3600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "COM Port:";
            // 
            // cBoxFreq
            // 
            this.cBoxFreq.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cBoxFreq.FormattingEnabled = true;
            this.cBoxFreq.Items.AddRange(new object[] {
            "3510",
            "3520",
            "3530",
            "3540",
            "3550",
            "3560",
            "3570",
            "3580",
            "3590",
            "3600"});
            this.cBoxFreq.Location = new System.Drawing.Point(6, 20);
            this.cBoxFreq.Name = "cBoxFreq";
            this.cBoxFreq.Size = new System.Drawing.Size(121, 21);
            this.cBoxFreq.TabIndex = 13;
            this.cBoxFreq.Text = "3600";
            this.cBoxFreq.SelectedIndexChanged += new System.EventHandler(this.cBoxFreq_SelectedIndexChanged);
            // 
            // cBoxComPorts
            // 
            this.cBoxComPorts.FormattingEnabled = true;
            this.cBoxComPorts.Location = new System.Drawing.Point(295, 163);
            this.cBoxComPorts.Name = "cBoxComPorts";
            this.cBoxComPorts.Size = new System.Drawing.Size(70, 21);
            this.cBoxComPorts.TabIndex = 14;
            // 
            // labelOutSrt
            // 
            this.labelOutSrt.AutoSize = true;
            this.labelOutSrt.Location = new System.Drawing.Point(9, 334);
            this.labelOutSrt.Name = "labelOutSrt";
            this.labelOutSrt.Size = new System.Drawing.Size(0, 13);
            this.labelOutSrt.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDevAnswer
            // 
            this.labelDevAnswer.AutoSize = true;
            this.labelDevAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDevAnswer.Location = new System.Drawing.Point(106, 308);
            this.labelDevAnswer.Name = "labelDevAnswer";
            this.labelDevAnswer.Size = new System.Drawing.Size(0, 16);
            this.labelDevAnswer.TabIndex = 16;
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 372);
            this.Controls.Add(this.labelDevAnswer);
            this.Controls.Add(this.labelOutSrt);
            this.Controls.Add(this.cBoxComPorts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonProg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.callBox);
            this.Name = "Form1";
            this.Text = "Fox TX settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.callBox.ResumeLayout(false);
            this.callBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton rbMOE;
        private System.Windows.Forms.RadioButton rbMOI;
        private System.Windows.Forms.RadioButton rbMOS;
        private System.Windows.Forms.RadioButton rbMOH;
        private System.Windows.Forms.RadioButton rbMO5;
        private System.Windows.Forms.RadioButton rbMO;
        private System.Windows.Forms.RadioButton rbMM;
        private System.Windows.Forms.GroupBox callBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb30s;
        private System.Windows.Forms.RadioButton rb60s;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBoxStartMode;
        private System.Windows.Forms.Button buttonProg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxFreq;
        private System.Windows.Forms.ComboBox cBoxComPorts;
        private System.Windows.Forms.Label labelOutSrt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDevAnswer;
        private System.Windows.Forms.Timer timer2;
    }
}

