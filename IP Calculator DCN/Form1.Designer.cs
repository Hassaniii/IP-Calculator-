namespace IP_Calculator_DCN
{
    partial class Form1
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
            this.Class_Label = new System.Windows.Forms.Label();
            this.Broadcast_Label = new System.Windows.Forms.Label();
            this.Last_Label = new System.Windows.Forms.Label();
            this.First_Label = new System.Windows.Forms.Label();
            this.Network_Label = new System.Windows.Forms.Label();
            this.Subnet_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VLSM_chck = new System.Windows.Forms.RadioButton();
            this.FLSM_chck = new System.Windows.Forms.RadioButton();
            this.Start_btn = new System.Windows.Forms.Button();
            this.IP_txt = new System.Windows.Forms.TextBox();
            this.FLSM_Mass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Req_txt = new System.Windows.Forms.TextBox();
            this.Calc_btn = new System.Windows.Forms.Button();
            this.VLSM_Mass = new System.Windows.Forms.ComboBox();
            this.Other_Networks = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // Class_Label
            // 
            this.Class_Label.AutoSize = true;
            this.Class_Label.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Label.Location = new System.Drawing.Point(277, 418);
            this.Class_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Class_Label.Name = "Class_Label";
            this.Class_Label.Size = new System.Drawing.Size(125, 23);
            this.Class_Label.TabIndex = 25;
            this.Class_Label.Text = "A/B/C/D/E";
            // 
            // Broadcast_Label
            // 
            this.Broadcast_Label.AutoSize = true;
            this.Broadcast_Label.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Broadcast_Label.Location = new System.Drawing.Point(277, 542);
            this.Broadcast_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Broadcast_Label.Name = "Broadcast_Label";
            this.Broadcast_Label.Size = new System.Drawing.Size(73, 23);
            this.Broadcast_Label.TabIndex = 24;
            this.Broadcast_Label.Text = "0.0.0.0";
            // 
            // Last_Label
            // 
            this.Last_Label.AutoSize = true;
            this.Last_Label.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Label.Location = new System.Drawing.Point(277, 500);
            this.Last_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Last_Label.Name = "Last_Label";
            this.Last_Label.Size = new System.Drawing.Size(73, 23);
            this.Last_Label.TabIndex = 23;
            this.Last_Label.Text = "0.0.0.0";
            // 
            // First_Label
            // 
            this.First_Label.AutoSize = true;
            this.First_Label.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Label.Location = new System.Drawing.Point(277, 458);
            this.First_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.First_Label.Name = "First_Label";
            this.First_Label.Size = new System.Drawing.Size(73, 23);
            this.First_Label.TabIndex = 22;
            this.First_Label.Text = "0.0.0.0";
            // 
            // Network_Label
            // 
            this.Network_Label.AutoSize = true;
            this.Network_Label.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Network_Label.Location = new System.Drawing.Point(277, 377);
            this.Network_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Network_Label.Name = "Network_Label";
            this.Network_Label.Size = new System.Drawing.Size(73, 23);
            this.Network_Label.TabIndex = 21;
            this.Network_Label.Text = "0.0.0.0";
            // 
            // Subnet_Label
            // 
            this.Subnet_Label.AutoSize = true;
            this.Subnet_Label.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subnet_Label.Location = new System.Drawing.Point(277, 337);
            this.Subnet_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Subnet_Label.Name = "Subnet_Label";
            this.Subnet_Label.Size = new System.Drawing.Size(73, 23);
            this.Subnet_Label.TabIndex = 20;
            this.Subnet_Label.Text = "0.0.0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Subnet Mask :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "First Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Last Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 542);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Broadcast :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Class :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Network :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "IP Address";
            // 
            // VLSM_chck
            // 
            this.VLSM_chck.AutoSize = true;
            this.VLSM_chck.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VLSM_chck.Location = new System.Drawing.Point(492, 94);
            this.VLSM_chck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VLSM_chck.Name = "VLSM_chck";
            this.VLSM_chck.Size = new System.Drawing.Size(137, 27);
            this.VLSM_chck.TabIndex = 28;
            this.VLSM_chck.TabStop = true;
            this.VLSM_chck.Text = "Class Less";
            this.VLSM_chck.UseVisualStyleBackColor = true;
            // 
            // FLSM_chck
            // 
            this.FLSM_chck.AutoSize = true;
            this.FLSM_chck.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLSM_chck.Location = new System.Drawing.Point(323, 94);
            this.FLSM_chck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FLSM_chck.Name = "FLSM_chck";
            this.FLSM_chck.Size = new System.Drawing.Size(128, 27);
            this.FLSM_chck.TabIndex = 27;
            this.FLSM_chck.TabStop = true;
            this.FLSM_chck.Text = "Class Full";
            this.FLSM_chck.UseVisualStyleBackColor = true;
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(420, 140);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(100, 28);
            this.Start_btn.TabIndex = 29;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // IP_txt
            // 
            this.IP_txt.Location = new System.Drawing.Point(281, 193);
            this.IP_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IP_txt.Name = "IP_txt";
            this.IP_txt.Size = new System.Drawing.Size(288, 22);
            this.IP_txt.TabIndex = 30;
            this.IP_txt.Leave += new System.EventHandler(this.IP_txt_Leave);
            // 
            // FLSM_Mass
            // 
            this.FLSM_Mass.FormattingEnabled = true;
            this.FLSM_Mass.Location = new System.Drawing.Point(612, 192);
            this.FLSM_Mass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FLSM_Mass.Name = "FLSM_Mass";
            this.FLSM_Mass.Size = new System.Drawing.Size(61, 24);
            this.FLSM_Mass.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(583, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "/";
            // 
            // Req_txt
            // 
            this.Req_txt.Location = new System.Drawing.Point(281, 225);
            this.Req_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Req_txt.Name = "Req_txt";
            this.Req_txt.Size = new System.Drawing.Size(55, 22);
            this.Req_txt.TabIndex = 33;
            this.Req_txt.Leave += new System.EventHandler(this.Req_txt_Leave);
            // 
            // Calc_btn
            // 
            this.Calc_btn.Location = new System.Drawing.Point(716, 191);
            this.Calc_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calc_btn.Name = "Calc_btn";
            this.Calc_btn.Size = new System.Drawing.Size(100, 28);
            this.Calc_btn.TabIndex = 34;
            this.Calc_btn.Text = "Calculate";
            this.Calc_btn.UseVisualStyleBackColor = true;
            this.Calc_btn.Click += new System.EventHandler(this.Calc_btn_Click);
            // 
            // VLSM_Mass
            // 
            this.VLSM_Mass.FormattingEnabled = true;
            this.VLSM_Mass.Location = new System.Drawing.Point(612, 192);
            this.VLSM_Mass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VLSM_Mass.Name = "VLSM_Mass";
            this.VLSM_Mass.Size = new System.Drawing.Size(61, 24);
            this.VLSM_Mass.TabIndex = 35;
            this.VLSM_Mass.Leave += new System.EventHandler(this.VLSM_Mass_Leave);
            // 
            // Other_Networks
            // 
            this.Other_Networks.FormattingEnabled = true;
            this.Other_Networks.ItemHeight = 16;
            this.Other_Networks.Location = new System.Drawing.Point(559, 337);
            this.Other_Networks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Other_Networks.Name = "Other_Networks";
            this.Other_Networks.Size = new System.Drawing.Size(453, 228);
            this.Other_Networks.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Required Networks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(372, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 34);
            this.label10.TabIndex = 38;
            this.label10.Text = "IP  Calculator";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(555, 311);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Other Networks";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 597);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Other_Networks);
            this.Controls.Add(this.VLSM_Mass);
            this.Controls.Add(this.Calc_btn);
            this.Controls.Add(this.Req_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FLSM_Mass);
            this.Controls.Add(this.IP_txt);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.VLSM_chck);
            this.Controls.Add(this.FLSM_chck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Class_Label);
            this.Controls.Add(this.Broadcast_Label);
            this.Controls.Add(this.Last_Label);
            this.Controls.Add(this.First_Label);
            this.Controls.Add(this.Network_Label);
            this.Controls.Add(this.Subnet_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "IP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Class_Label;
        private System.Windows.Forms.Label Broadcast_Label;
        private System.Windows.Forms.Label Last_Label;
        private System.Windows.Forms.Label First_Label;
        private System.Windows.Forms.Label Network_Label;
        private System.Windows.Forms.Label Subnet_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton VLSM_chck;
        private System.Windows.Forms.RadioButton FLSM_chck;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.TextBox IP_txt;
        private System.Windows.Forms.ComboBox FLSM_Mass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Req_txt;
        private System.Windows.Forms.Button Calc_btn;
        private System.Windows.Forms.ComboBox VLSM_Mass;
        private System.Windows.Forms.ListBox Other_Networks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

