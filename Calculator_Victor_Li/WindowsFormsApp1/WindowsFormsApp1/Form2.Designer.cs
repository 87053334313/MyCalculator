
namespace WindowsFormsApp1
{
    partial class FormIng
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
            this.label1 = new System.Windows.Forms.Label();
            this.myVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MyResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBstepen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.switchOp = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(281, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инженерный калькулятор";
            // 
            // myVal
            // 
            this.myVal.Location = new System.Drawing.Point(336, 103);
            this.myVal.Name = "myVal";
            this.myVal.Size = new System.Drawing.Size(106, 20);
            this.myVal.TabIndex = 1;
            this.toolTip1.SetToolTip(this.myVal, "введи число в качестве разделителя используй запятую");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введи значение для опреции";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(58, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Возведение в степень";
            this.toolTip1.SetToolTip(this.button1, "чтобы получить результат нажми на эту кнопку");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(331, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MyResult
            // 
            this.MyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyResult.Location = new System.Drawing.Point(296, 400);
            this.MyResult.Name = "MyResult";
            this.MyResult.ReadOnly = true;
            this.MyResult.Size = new System.Drawing.Size(189, 26);
            this.MyResult.TabIndex = 5;
            this.toolTip1.SetToolTip(this.MyResult, "я специально заблокировл воод чтобы ты случайно не удалил в ответе ничего");
            this.MyResult.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введи число в какую степень \n хочешь возвести";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TBstepen
            // 
            this.TBstepen.Location = new System.Drawing.Point(36, 187);
            this.TBstepen.Name = "TBstepen";
            this.TBstepen.Size = new System.Drawing.Size(136, 20);
            this.TBstepen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(260, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "выбери простую инженерную операцию \n только с этим  \n веденным тобой числом";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(296, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 67);
            this.button2.TabIndex = 10;
            this.button2.Text = "выполнить простую \n инженерную операцию \n для выбранного поля выше";
            this.toolTip1.SetToolTip(this.button2, "нажми на меня!");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // switchOp
            // 
            this.switchOp.FormattingEnabled = true;
            this.switchOp.Items.AddRange(new object[] {
            "Извлечение квадратного корня",
            "Расчет обратного значения(1/x)",
            "Определение квадрата числа",
            "Расчет факториала",
            "Извлечение кубического корня"});
            this.switchOp.Location = new System.Drawing.Point(243, 202);
            this.switchOp.Name = "switchOp";
            this.switchOp.Size = new System.Drawing.Size(290, 21);
            this.switchOp.TabIndex = 11;
            this.toolTip1.SetToolTip(this.switchOp, "Выбери функцию любую");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(685, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "выход";
            this.toolTip1.SetToolTip(this.button3, "для закрытия окна");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(685, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 74);
            this.button4.TabIndex = 13;
            this.button4.Text = "Очистить ВСЁ";
            this.toolTip1.SetToolTip(this.button4, "чтобы очистить все поля");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormIng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.switchOp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBstepen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MyResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myVal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormIng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Инженерная часть моего калькултяора";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormIng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MyResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBstepen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox switchOp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}