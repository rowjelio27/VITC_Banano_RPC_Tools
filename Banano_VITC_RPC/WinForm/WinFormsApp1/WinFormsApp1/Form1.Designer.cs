
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtViteAddress = new System.Windows.Forms.TextBox();
            this.btnGetBal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHistoryStuff = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtVITCsendamount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResultSend = new System.Windows.Forms.TextBox();
            this.txtSendViteTo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSendBananoAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBananoAddress = new System.Windows.Forms.TextBox();
            this.txtBananoHistoryStuff = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBananoSendAmount = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBananoNode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBananoPort = new System.Windows.Forms.TextBox();
            this.lblBananoBal = new System.Windows.Forms.Label();
            this.txtminutesslack = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(105, 94);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 23);
            this.txtPort.TabIndex = 15;
            this.txtPort.Text = "48132";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(130, 67);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(231, 23);
            this.txtNode.TabIndex = 14;
            this.txtNode.Text = "http://192.168.1.61";
            this.txtNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBal
            // 
            this.lblBal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBal.Location = new System.Drawing.Point(227, 94);
            this.lblBal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(220, 25);
            this.lblBal.TabIndex = 12;
            this.lblBal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "VIT C Address";
            // 
            // txtViteAddress
            // 
            this.txtViteAddress.Location = new System.Drawing.Point(8, 39);
            this.txtViteAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtViteAddress.Name = "txtViteAddress";
            this.txtViteAddress.Size = new System.Drawing.Size(353, 23);
            this.txtViteAddress.TabIndex = 10;
            this.txtViteAddress.Text = "vite_34e439bd849306edd61f24d9d1da35040b576bf014a13cb9a0";
            // 
            // btnGetBal
            // 
            this.btnGetBal.Location = new System.Drawing.Point(375, 39);
            this.btnGetBal.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetBal.Name = "btnGetBal";
            this.btnGetBal.Size = new System.Drawing.Size(89, 23);
            this.btnGetBal.TabIndex = 9;
            this.btnGetBal.Text = "Get Balance";
            this.btnGetBal.UseVisualStyleBackColor = true;
            this.btnGetBal.Click += new System.EventHandler(this.btnGetBal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vit C Node to query:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "VITE Node Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Balance:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Get Transaction History!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHistoryStuff
            // 
            this.txtHistoryStuff.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHistoryStuff.Location = new System.Drawing.Point(6, 187);
            this.txtHistoryStuff.Multiline = true;
            this.txtHistoryStuff.Name = "txtHistoryStuff";
            this.txtHistoryStuff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistoryStuff.Size = new System.Drawing.Size(626, 193);
            this.txtHistoryStuff.TabIndex = 20;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(8, 129);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 21);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send Vit C";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtVITCsendamount
            // 
            this.txtVITCsendamount.Location = new System.Drawing.Point(98, 127);
            this.txtVITCsendamount.Name = "txtVITCsendamount";
            this.txtVITCsendamount.Size = new System.Drawing.Size(40, 23);
            this.txtVITCsendamount.TabIndex = 22;
            this.txtVITCsendamount.Text = "1";
            this.txtVITCsendamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Get Exchange Rates!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblResultSend);
            this.groupBox1.Controls.Add(this.txtSendViteTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtViteAddress);
            this.groupBox1.Controls.Add(this.txtHistoryStuff);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtVITCsendamount);
            this.groupBox1.Controls.Add(this.btnGetBal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.lblBal);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 401);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VITE Stuff";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 23);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "https://node-vite.thomiz.dev/http";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultSend
            // 
            this.lblResultSend.Location = new System.Drawing.Point(159, 156);
            this.lblResultSend.Margin = new System.Windows.Forms.Padding(5);
            this.lblResultSend.Name = "lblResultSend";
            this.lblResultSend.Size = new System.Drawing.Size(404, 23);
            this.lblResultSend.TabIndex = 24;
            // 
            // txtSendViteTo
            // 
            this.txtSendViteTo.Location = new System.Drawing.Point(146, 129);
            this.txtSendViteTo.Margin = new System.Windows.Forms.Padding(5);
            this.txtSendViteTo.Name = "txtSendViteTo";
            this.txtSendViteTo.Size = new System.Drawing.Size(404, 23);
            this.txtSendViteTo.TabIndex = 23;
            this.txtSendViteTo.Text = "vite_34e439bd849306edd61f24d9d1da35040b576bf014a13cb9a0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSendBananoAddress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBananoAddress);
            this.groupBox2.Controls.Add(this.txtBananoHistoryStuff);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtBananoSendAmount);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBananoNode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBananoPort);
            this.groupBox2.Controls.Add(this.lblBananoBal);
            this.groupBox2.Location = new System.Drawing.Point(660, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 401);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banano Stuff";
            // 
            // txtSendBananoAddress
            // 
            this.txtSendBananoAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSendBananoAddress.Location = new System.Drawing.Point(171, 126);
            this.txtSendBananoAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtSendBananoAddress.Name = "txtSendBananoAddress";
            this.txtSendBananoAddress.Size = new System.Drawing.Size(419, 23);
            this.txtSendBananoAddress.TabIndex = 23;
            this.txtSendBananoAddress.Text = "ban_3sfxxdyuex5ut8rzf4s31szmu73dm1jfy7trut9e8u1rjnw3mm9bgbux64nw";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Banano Address";
            // 
            // txtBananoAddress
            // 
            this.txtBananoAddress.Location = new System.Drawing.Point(8, 39);
            this.txtBananoAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtBananoAddress.Name = "txtBananoAddress";
            this.txtBananoAddress.Size = new System.Drawing.Size(408, 23);
            this.txtBananoAddress.TabIndex = 10;
            this.txtBananoAddress.Text = "ban_3sfxxdyuex5ut8rzf4s31szmu73dm1jfy7trut9e8u1rjnw3mm9bgbux64nw";
            // 
            // txtBananoHistoryStuff
            // 
            this.txtBananoHistoryStuff.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBananoHistoryStuff.Location = new System.Drawing.Point(6, 187);
            this.txtBananoHistoryStuff.Multiline = true;
            this.txtBananoHistoryStuff.Name = "txtBananoHistoryStuff";
            this.txtBananoHistoryStuff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBananoHistoryStuff.Size = new System.Drawing.Size(626, 193);
            this.txtBananoHistoryStuff.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 125);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 21);
            this.button3.TabIndex = 21;
            this.button3.Text = "Send Banano";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSendBanano_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 155);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Get Transaction History!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBananoSendAmount
            // 
            this.txtBananoSendAmount.Location = new System.Drawing.Point(120, 125);
            this.txtBananoSendAmount.Name = "txtBananoSendAmount";
            this.txtBananoSendAmount.Size = new System.Drawing.Size(43, 23);
            this.txtBananoSendAmount.TabIndex = 22;
            this.txtBananoSendAmount.Text = "1";
            this.txtBananoSendAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 38);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Get Balance";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Banano Node to query:";
            // 
            // txtBananoNode
            // 
            this.txtBananoNode.Location = new System.Drawing.Point(140, 67);
            this.txtBananoNode.Name = "txtBananoNode";
            this.txtBananoNode.Size = new System.Drawing.Size(221, 23);
            this.txtBananoNode.TabIndex = 14;
            this.txtBananoNode.Text = "192.168.1.59";
            this.txtBananoNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Banano Node Port:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Balance:";
            // 
            // txtBananoPort
            // 
            this.txtBananoPort.Location = new System.Drawing.Point(130, 94);
            this.txtBananoPort.Name = "txtBananoPort";
            this.txtBananoPort.Size = new System.Drawing.Size(53, 23);
            this.txtBananoPort.TabIndex = 15;
            this.txtBananoPort.Text = "7072";
            this.txtBananoPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBananoBal
            // 
            this.lblBananoBal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBananoBal.Location = new System.Drawing.Point(244, 97);
            this.lblBananoBal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBananoBal.Name = "lblBananoBal";
            this.lblBananoBal.Size = new System.Drawing.Size(220, 25);
            this.lblBananoBal.TabIndex = 12;
            this.lblBananoBal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtminutesslack
            // 
            this.txtminutesslack.Location = new System.Drawing.Point(34, 6);
            this.txtminutesslack.Name = "txtminutesslack";
            this.txtminutesslack.Size = new System.Drawing.Size(100, 23);
            this.txtminutesslack.TabIndex = 27;
            this.txtminutesslack.Text = "-10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 482);
            this.Controls.Add(this.txtminutesslack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "VITE NODE TESTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViteAddress;
        private System.Windows.Forms.Button btnGetBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHistoryStuff;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtVITCsendamount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSendViteTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSendBananoAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBananoAddress;
        private System.Windows.Forms.TextBox txtBananoHistoryStuff;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBananoSendAmount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBananoNode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBananoPort;
        private System.Windows.Forms.Label lblBananoBal;
        private System.Windows.Forms.TextBox lblResultSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtminutesslack;
    }
}

