namespace Berhstein {
    partial class BurseApp {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.pbGraphic = new System.Windows.Forms.PictureBox();
            this.txtParticipant = new System.Windows.Forms.TextBox();
            this.btnStartTrade = new System.Windows.Forms.Button();
            this.btnStopTrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBrokers = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraphic
            // 
            this.pbGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGraphic.Location = new System.Drawing.Point(45, 16);
            this.pbGraphic.Name = "pbGraphic";
            this.pbGraphic.Size = new System.Drawing.Size(253, 169);
            this.pbGraphic.TabIndex = 0;
            this.pbGraphic.TabStop = false;
            // 
            // txtParticipant
            // 
            this.txtParticipant.Location = new System.Drawing.Point(45, 250);
            this.txtParticipant.Name = "txtParticipant";
            this.txtParticipant.Size = new System.Drawing.Size(123, 20);
            this.txtParticipant.TabIndex = 3;
            this.txtParticipant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParticipant_KeyDown);
            // 
            // btnStartTrade
            // 
            this.btnStartTrade.Location = new System.Drawing.Point(45, 191);
            this.btnStartTrade.Name = "btnStartTrade";
            this.btnStartTrade.Size = new System.Drawing.Size(123, 35);
            this.btnStartTrade.TabIndex = 1;
            this.btnStartTrade.Text = "Начать торги";
            this.btnStartTrade.UseVisualStyleBackColor = true;
            this.btnStartTrade.Click += new System.EventHandler(this.btnStartTrade_Click);
            // 
            // btnStopTrade
            // 
            this.btnStopTrade.Location = new System.Drawing.Point(175, 191);
            this.btnStopTrade.Name = "btnStopTrade";
            this.btnStopTrade.Size = new System.Drawing.Size(123, 35);
            this.btnStopTrade.TabIndex = 2;
            this.btnStopTrade.Text = "Остановить торги";
            this.btnStopTrade.UseVisualStyleBackColor = true;
            this.btnStopTrade.Click += new System.EventHandler(this.btnStopTrade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "27";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "29";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "23";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "21";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "23";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "21";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "27";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "29";
            // 
            // listBrokers
            // 
            this.listBrokers.FormattingEnabled = true;
            this.listBrokers.Location = new System.Drawing.Point(350, 35);
            this.listBrokers.Name = "listBrokers";
            this.listBrokers.Size = new System.Drawing.Size(138, 134);
            this.listBrokers.TabIndex = 7;
            this.listBrokers.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Участники торгов";
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Location = new System.Drawing.Point(175, 239);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(123, 40);
            this.btnRegistrate.TabIndex = 4;
            this.btnRegistrate.Text = "Зарегистрировать участника";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Имя(m): sum (uah) грн.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "m - граница покупки валюты";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(348, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "sum - общие активы";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "uah - чисто гривна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 296);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRegistrate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBrokers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopTrade);
            this.Controls.Add(this.btnStartTrade);
            this.Controls.Add(this.txtParticipant);
            this.Controls.Add(this.pbGraphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Берхштейн";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraphic;
        private System.Windows.Forms.TextBox txtParticipant;
        private System.Windows.Forms.Button btnStartTrade;
        private System.Windows.Forms.Button btnStopTrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBrokers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

