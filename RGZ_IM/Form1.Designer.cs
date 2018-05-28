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
            this.label12 = new System.Windows.Forms.Label();
            this.NextPeopleTimeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NextWaveTimeTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.WaveTimeTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.MiddleServiceTimeTextBox = new System.Windows.Forms.TextBox();
            this.MiddleServiceWaveTimeTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.OrderTimeTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.KvantilTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.IterationCountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(777, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Симуляция";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время симуляции (в минутах): ";
            // 
            // FullTimeTextBox
            // 
            this.FullTimeTextBox.Location = new System.Drawing.Point(181, 29);
            this.FullTimeTextBox.Name = "FullTimeTextBox";
            this.FullTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullTimeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Среднее время в очереди (в минутах): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество обслуженных людей: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Среднее время в первой фазе (в минутах): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Среднее время во второй фазе (в минутах): ";
            // 
            // PeopleCountTextBox
            // 
            this.PeopleCountTextBox.Location = new System.Drawing.Point(606, 29);
            this.PeopleCountTextBox.Name = "PeopleCountTextBox";
            this.PeopleCountTextBox.ReadOnly = true;
            this.PeopleCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeopleCountTextBox.TabIndex = 7;
            // 
            // MiddleTimeInPhase1TextBox
            // 
            this.MiddleTimeInPhase1TextBox.Location = new System.Drawing.Point(661, 130);
            this.MiddleTimeInPhase1TextBox.Name = "MiddleTimeInPhase1TextBox";
            this.MiddleTimeInPhase1TextBox.ReadOnly = true;
            this.MiddleTimeInPhase1TextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInPhase1TextBox.TabIndex = 8;
            // 
            // MiddleTimeInPhase2TextBox
            // 
            this.MiddleTimeInPhase2TextBox.Location = new System.Drawing.Point(661, 212);
            this.MiddleTimeInPhase2TextBox.Name = "MiddleTimeInPhase2TextBox";
            this.MiddleTimeInPhase2TextBox.ReadOnly = true;
            this.MiddleTimeInPhase2TextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInPhase2TextBox.TabIndex = 9;
            // 
            // MiddleTimeInQueveTextBox
            // 
            this.MiddleTimeInQueveTextBox.Location = new System.Drawing.Point(640, 106);
            this.MiddleTimeInQueveTextBox.Name = "MiddleTimeInQueveTextBox";
            this.MiddleTimeInQueveTextBox.ReadOnly = true;
            this.MiddleTimeInQueveTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInQueveTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество работающих каналов: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Загрузка каналов (в процентах):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Среднее время прихода заявок (в минутах): ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Общее время работы каналов (в минутах): ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Время работы канала (в минутах): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Точность симуляции: ";
            // 
            // ChannelCountTextBox
            // 
            this.ChannelCountTextBox.Location = new System.Drawing.Point(201, 55);
            this.ChannelCountTextBox.Name = "ChannelCountTextBox";
            this.ChannelCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelCountTextBox.TabIndex = 2;
            // 
            // AccuracyTextBox
            // 
            this.AccuracyTextBox.Location = new System.Drawing.Point(136, 77);
            this.AccuracyTextBox.Name = "AccuracyTextBox";
            this.AccuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccuracyTextBox.TabIndex = 3;
            // 
            // ChannelProcentTextBox
            // 
            this.ChannelProcentTextBox.Location = new System.Drawing.Point(606, 53);
            this.ChannelProcentTextBox.Name = "ChannelProcentTextBox";
            this.ChannelProcentTextBox.ReadOnly = true;
            this.ChannelProcentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelProcentTextBox.TabIndex = 19;
            // 
            // ChannelsMiddleTimeWorkTextBox
            // 
            this.ChannelsMiddleTimeWorkTextBox.Location = new System.Drawing.Point(664, 77);
            this.ChannelsMiddleTimeWorkTextBox.Name = "ChannelsMiddleTimeWorkTextBox";
            this.ChannelsMiddleTimeWorkTextBox.ReadOnly = true;
            this.ChannelsMiddleTimeWorkTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelsMiddleTimeWorkTextBox.TabIndex = 20;
            // 
            // MiddleRequestTextBox
            // 
            this.MiddleRequestTextBox.Location = new System.Drawing.Point(661, 158);
            this.MiddleRequestTextBox.Name = "MiddleRequestTextBox";
            this.MiddleRequestTextBox.ReadOnly = true;
            this.MiddleRequestTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleRequestTextBox.TabIndex = 21;
            // 
            // ChannelMiddleTimeTextBox
            // 
            this.ChannelMiddleTimeTextBox.Location = new System.Drawing.Point(612, 184);
            this.ChannelMiddleTimeTextBox.Name = "ChannelMiddleTimeTextBox";
            this.ChannelMiddleTimeTextBox.ReadOnly = true;
            this.ChannelMiddleTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChannelMiddleTimeTextBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Среднее время прихода заявок (в минутах): ";
            // 
            // NextPeopleTimeTextBox
            // 
            this.NextPeopleTimeTextBox.Location = new System.Drawing.Point(251, 205);
            this.NextPeopleTimeTextBox.Name = "NextPeopleTimeTextBox";
            this.NextPeopleTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NextPeopleTimeTextBox.TabIndex = 24;
            this.NextPeopleTimeTextBox.Text = "1,5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Среднее значение прихода волн (в минутах): ";
            // 
            // NextWaveTimeTextBox
            // 
            this.NextWaveTimeTextBox.Location = new System.Drawing.Point(254, 231);
            this.NextWaveTimeTextBox.Name = "NextWaveTimeTextBox";
            this.NextWaveTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NextWaveTimeTextBox.TabIndex = 26;
            this.NextWaveTimeTextBox.Text = "360";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(255, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Средняя продолжительность волны (в минутах): ";
            // 
            // WaveTimeTextBox
            // 
            this.WaveTimeTextBox.Location = new System.Drawing.Point(271, 257);
            this.WaveTimeTextBox.Name = "WaveTimeTextBox";
            this.WaveTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.WaveTimeTextBox.TabIndex = 28;
            this.WaveTimeTextBox.Text = "90";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Среднее время обслуживания (в минутах): ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(267, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Среднее время обслуживания в волну (в минутах): ";
            // 
            // MiddleServiceTimeTextBox
            // 
            this.MiddleServiceTimeTextBox.Location = new System.Drawing.Point(236, 127);
            this.MiddleServiceTimeTextBox.Name = "MiddleServiceTimeTextBox";
            this.MiddleServiceTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleServiceTimeTextBox.TabIndex = 31;
            this.MiddleServiceTimeTextBox.Text = "2,8";
            // 
            // MiddleServiceWaveTimeTextBox
            // 
            this.MiddleServiceWaveTimeTextBox.Location = new System.Drawing.Point(285, 151);
            this.MiddleServiceWaveTimeTextBox.Name = "MiddleServiceWaveTimeTextBox";
            this.MiddleServiceWaveTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleServiceWaveTimeTextBox.TabIndex = 32;
            this.MiddleServiceWaveTimeTextBox.Text = "7,8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(254, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Среднее время совершения заказа (в минутах): ";
            // 
            // OrderTimeTextBox
            // 
            this.OrderTimeTextBox.Location = new System.Drawing.Point(271, 177);
            this.OrderTimeTextBox.Name = "OrderTimeTextBox";
            this.OrderTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderTimeTextBox.TabIndex = 34;
            this.OrderTimeTextBox.Text = "2,2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Введите данные: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(428, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Результаты симуляции: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Квантиль: ";
            // 
            // KvantilTextBox
            // 
            this.KvantilTextBox.Location = new System.Drawing.Point(81, 106);
            this.KvantilTextBox.Name = "KvantilTextBox";
            this.KvantilTextBox.Size = new System.Drawing.Size(100, 20);
            this.KvantilTextBox.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(431, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Число итераций: ";
            // 
            // IterationCountTextBox
            // 
            this.IterationCountTextBox.Location = new System.Drawing.Point(532, 235);
            this.IterationCountTextBox.Name = "IterationCountTextBox";
            this.IterationCountTextBox.ReadOnly = true;
            this.IterationCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.IterationCountTextBox.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 335);
            this.Controls.Add(this.IterationCountTextBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.KvantilTextBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.OrderTimeTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.MiddleServiceWaveTimeTextBox);
            this.Controls.Add(this.MiddleServiceTimeTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.WaveTimeTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NextWaveTimeTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NextPeopleTimeTextBox);
            this.Controls.Add(this.label12);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NextPeopleTimeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NextWaveTimeTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox WaveTimeTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MiddleServiceTimeTextBox;
        private System.Windows.Forms.TextBox MiddleServiceWaveTimeTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox OrderTimeTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox KvantilTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox IterationCountTextBox;
    }
}

