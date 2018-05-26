namespace RGZ_IM
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FullTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PeopleCountTextBox = new System.Windows.Forms.TextBox();
            this.MiddleTimeInPhase1TextBox = new System.Windows.Forms.TextBox();
            this.MiddleTimeInPhase2TextBox = new System.Windows.Forms.TextBox();
            this.MiddleTimeInQueveTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ChannelCountTextBox = new System.Windows.Forms.TextBox();
            this.AccuracyTextBox = new System.Windows.Forms.TextBox();
            this.ChannelProcentTextBox = new System.Windows.Forms.TextBox();
            this.ChannelsMiddleTimeWorkTextBox = new System.Windows.Forms.TextBox();
            this.MiddleRequestTextBox = new System.Windows.Forms.TextBox();
            this.ChannelMiddleTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 129);
            this.button1.TabIndex = 4;
            this.button1.Text = "Симуляция";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите время симуляции(в минутах): ";
            // 
            // FullTimeTextBox
            // 
            this.FullTimeTextBox.Location = new System.Drawing.Point(222, 6);
            this.FullTimeTextBox.Name = "FullTimeTextBox";
            this.FullTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullTimeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Среднее время в очереди(в минутах): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество обслуженных людей: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Среднее время в первой фазе(в минутах): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Среднее время во второй фазе(в минутах): ";
            // 
            // PeopleCountTextBox
            // 
            this.PeopleCountTextBox.Location = new System.Drawing.Point(187, 82);
            this.PeopleCountTextBox.Name = "PeopleCountTextBox";
            this.PeopleCountTextBox.ReadOnly = true;
            this.PeopleCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeopleCountTextBox.TabIndex = 7;
            // 
            // MiddleTimeInPhase1TextBox
            // 
            this.MiddleTimeInPhase1TextBox.Location = new System.Drawing.Point(235, 232);
            this.MiddleTimeInPhase1TextBox.Name = "MiddleTimeInPhase1TextBox";
            this.MiddleTimeInPhase1TextBox.ReadOnly = true;
            this.MiddleTimeInPhase1TextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInPhase1TextBox.TabIndex = 8;
            // 
            // MiddleTimeInPhase2TextBox
            // 
            this.MiddleTimeInPhase2TextBox.Location = new System.Drawing.Point(235, 258);
            this.MiddleTimeInPhase2TextBox.Name = "MiddleTimeInPhase2TextBox";
            this.MiddleTimeInPhase2TextBox.ReadOnly = true;
            this.MiddleTimeInPhase2TextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInPhase2TextBox.TabIndex = 9;
            // 
            // MiddleTimeInQueveTextBox
            // 
            this.MiddleTimeInQueveTextBox.Location = new System.Drawing.Point(215, 206);
            this.MiddleTimeInQueveTextBox.Name = "MiddleTimeInQueveTextBox";
            this.MiddleTimeInQueveTextBox.ReadOnly = true;
            this.MiddleTimeInQueveTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInQueveTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите количество работающих каналов: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Загрузка каналов(в процентах):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Среднее время прихода заявок(в минутах): ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Среднее время работы каналов(в минутах): ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Среднее время работы канала(в минутах): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Введите точность симуляции: ";
            // 
            // ChannelCountTextBox
            // 
            this.ChannelCountTextBox.Location = new System.Drawing.Point(245, 32);
            this.ChannelCountTextBox.Name = "ChannelCountTextBox";
            this.ChannelCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelCountTextBox.TabIndex = 2;
            // 
            // AccuracyTextBox
            // 
            this.AccuracyTextBox.Location = new System.Drawing.Point(179, 56);
            this.AccuracyTextBox.Name = "AccuracyTextBox";
            this.AccuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccuracyTextBox.TabIndex = 3;
            // 
            // ChannelProcentTextBox
            // 
            this.ChannelProcentTextBox.Location = new System.Drawing.Point(187, 106);
            this.ChannelProcentTextBox.Name = "ChannelProcentTextBox";
            this.ChannelProcentTextBox.ReadOnly = true;
            this.ChannelProcentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelProcentTextBox.TabIndex = 19;
            // 
            // ChannelsMiddleTimeWorkTextBox
            // 
            this.ChannelsMiddleTimeWorkTextBox.Location = new System.Drawing.Point(245, 130);
            this.ChannelsMiddleTimeWorkTextBox.Name = "ChannelsMiddleTimeWorkTextBox";
            this.ChannelsMiddleTimeWorkTextBox.ReadOnly = true;
            this.ChannelsMiddleTimeWorkTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelsMiddleTimeWorkTextBox.TabIndex = 20;
            // 
            // MiddleRequestTextBox
            // 
            this.MiddleRequestTextBox.Location = new System.Drawing.Point(235, 156);
            this.MiddleRequestTextBox.Name = "MiddleRequestTextBox";
            this.MiddleRequestTextBox.ReadOnly = true;
            this.MiddleRequestTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleRequestTextBox.TabIndex = 21;
            // 
            // ChannelMiddleTimeTextBox
            // 
            this.ChannelMiddleTimeTextBox.Location = new System.Drawing.Point(241, 182);
            this.ChannelMiddleTimeTextBox.Name = "ChannelMiddleTimeTextBox";
            this.ChannelMiddleTimeTextBox.ReadOnly = true;
            this.ChannelMiddleTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelMiddleTimeTextBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 283);
            this.Controls.Add(this.ChannelMiddleTimeTextBox);
            this.Controls.Add(this.MiddleRequestTextBox);
            this.Controls.Add(this.ChannelsMiddleTimeWorkTextBox);
            this.Controls.Add(this.ChannelProcentTextBox);
            this.Controls.Add(this.AccuracyTextBox);
            this.Controls.Add(this.ChannelCountTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MiddleTimeInQueveTextBox);
            this.Controls.Add(this.MiddleTimeInPhase2TextBox);
            this.Controls.Add(this.MiddleTimeInPhase1TextBox);
            this.Controls.Add(this.PeopleCountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullTimeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PeopleCountTextBox;
        private System.Windows.Forms.TextBox MiddleTimeInPhase1TextBox;
        private System.Windows.Forms.TextBox MiddleTimeInPhase2TextBox;
        private System.Windows.Forms.TextBox MiddleTimeInQueveTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ChannelCountTextBox;
        private System.Windows.Forms.TextBox AccuracyTextBox;
        private System.Windows.Forms.TextBox ChannelProcentTextBox;
        private System.Windows.Forms.TextBox ChannelsMiddleTimeWorkTextBox;
        private System.Windows.Forms.TextBox MiddleRequestTextBox;
        private System.Windows.Forms.TextBox ChannelMiddleTimeTextBox;
    }
}

