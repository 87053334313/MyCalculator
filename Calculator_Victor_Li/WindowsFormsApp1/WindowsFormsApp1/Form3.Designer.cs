
namespace WindowsFormsApp1
{
    partial class Form3KV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.A_textBox = new System.Windows.Forms.TextBox();
            this.B_TextBox = new System.Windows.Forms.TextBox();
            this.C_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MyButtonKvur = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ImageCalc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(189, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программа для расчета квадратного уравнения";
            this.toolTip1.SetToolTip(this.label1, "Уранение вида a*x^2+b*x+c=0");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.toolTip1.SetToolTip(this.label2, "это икс в квадрате");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(256, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(348, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            this.toolTip1.SetToolTip(this.label5, "это икс");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(417, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "+";
            // 
            // A_textBox
            // 
            this.A_textBox.Location = new System.Drawing.Point(155, 130);
            this.A_textBox.Name = "A_textBox";
            this.A_textBox.Size = new System.Drawing.Size(26, 20);
            this.A_textBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.A_textBox, "сюда вводи а из твоего урвнения");
            // 
            // B_TextBox
            // 
            this.B_TextBox.Location = new System.Drawing.Point(315, 129);
            this.B_TextBox.Name = "B_TextBox";
            this.B_TextBox.Size = new System.Drawing.Size(27, 20);
            this.B_TextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.B_TextBox, "сюда вводи b из твоего уравнения");
            // 
            // C_TB
            // 
            this.C_TB.Location = new System.Drawing.Point(463, 129);
            this.C_TB.Name = "C_TB";
            this.C_TB.Size = new System.Drawing.Size(26, 20);
            this.C_TB.TabIndex = 8;
            this.toolTip1.SetToolTip(this.C_TB, "сюда вооди с из твоего кравнения");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(541, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(595, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(322, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ответ :";
            this.toolTip1.SetToolTip(this.label10, "снизу будет написан ответ");
            // 
            // MyButtonKvur
            // 
            this.MyButtonKvur.BackColor = System.Drawing.Color.LimeGreen;
            this.MyButtonKvur.Location = new System.Drawing.Point(306, 196);
            this.MyButtonKvur.Name = "MyButtonKvur";
            this.MyButtonKvur.Size = new System.Drawing.Size(112, 23);
            this.MyButtonKvur.TabIndex = 14;
            this.MyButtonKvur.Text = "Посчитать";
            this.toolTip1.SetToolTip(this.MyButtonKvur, "что бы посчитать нажми эту зеленую кнопку");
            this.MyButtonKvur.UseVisualStyleBackColor = false;
            this.MyButtonKvur.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(713, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Выход";
            this.toolTip1.SetToolTip(this.button2, "чтобы закрыть это окно нажми эту ркасную кнопочку");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(262, 267);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(207, 96);
            this.RichTextBox.TabIndex = 16;
            this.RichTextBox.Text = "";
            this.toolTip1.SetToolTip(this.RichTextBox, "сюда ничего нельзя вводить, это поле только для ответов");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(674, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "очистить все";
            this.toolTip1.SetToolTip(this.button1, "что бы очистить нажми ее");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // ImageCalc
            // 
            this.ImageCalc.Location = new System.Drawing.Point(23, 215);
            this.ImageCalc.Name = "ImageCalc";
            this.ImageCalc.Size = new System.Drawing.Size(171, 223);
            this.ImageCalc.TabIndex = 18;
            this.ImageCalc.TabStop = false;
            this.toolTip1.SetToolTip(this.ImageCalc, "тут должна быть кортинка с калькулятором");
            // 
            // Form3KV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.ImageCalc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MyButtonKvur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.C_TB);
            this.Controls.Add(this.B_TextBox);
            this.Controls.Add(this.A_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form3KV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3KV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox A_textBox;
        private System.Windows.Forms.TextBox B_TextBox;
        private System.Windows.Forms.TextBox C_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button MyButtonKvur;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox ImageCalc;
    }
}