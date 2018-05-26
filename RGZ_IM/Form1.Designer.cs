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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 129);
            this.button1.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Среднее время в очереди(в минутах): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество обслуженных людей: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Среднее время в первой фазе(в минутах): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Среднее время во второй фазе(в минутах): ";
            // 
            // PeopleCountTextBox
            // 
            this.PeopleCountTextBox.Location = new System.Drawing.Point(196, 35);
            this.PeopleCountTextBox.Name = "PeopleCountTextBox";
            this.PeopleCountTextBox.ReadOnly = true;
            this.PeopleCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeopleCountTextBox.TabIndex = 7;
            // 
            // MiddleTimeInPhase1TextBox
            // 
            this.MiddleTimeInPhase1TextBox.Location = new System.Drawing.Point(242, 87);
            this.MiddleTimeInPhase1TextBox.Name = "MiddleTimeInPhase1TextBox";
            this.MiddleTimeInPhase1TextBox.ReadOnly = true;
            this.MiddleTimeInPhase1TextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInPhase1TextBox.TabIndex = 8;
            // 
            // MiddleTimeInPhase2TextBox
            // 
            this.MiddleTimeInPhase2TextBox.Location = new System.Drawing.Point(242, 113);
            this.MiddleTimeInPhase2TextBox.Name = "MiddleTimeInPhase2TextBox";
            this.MiddleTimeInPhase2TextBox.ReadOnly = true;
            this.MiddleTimeInPhase2TextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInPhase2TextBox.TabIndex = 9;
            // 
            // MiddleTimeInQueveTextBox
            // 
            this.MiddleTimeInQueveTextBox.Location = new System.Drawing.Point(218, 61);
            this.MiddleTimeInQueveTextBox.Name = "MiddleTimeInQueveTextBox";
            this.MiddleTimeInQueveTextBox.ReadOnly = true;
            this.MiddleTimeInQueveTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleTimeInQueveTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 143);
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
    }
}

