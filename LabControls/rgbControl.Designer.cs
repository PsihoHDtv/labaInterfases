namespace LabControls
{
    partial class rgbControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rgbBoxBlue = new LabControls.rgbBox(this.components);
            this.rgbBoxGreen = new LabControls.rgbBox(this.components);
            this.rgbBoxRed = new LabControls.rgbBox(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Синий";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dec";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hex";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(152, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 106);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rgbBoxBlue
            // 
            this.rgbBoxBlue.ForeColor = System.Drawing.Color.Black;
            this.rgbBoxBlue.isDec = true;
            this.rgbBoxBlue.Location = new System.Drawing.Point(88, 62);
            this.rgbBoxBlue.MaxLength = 3;
            this.rgbBoxBlue.Name = "rgbBoxBlue";
            this.rgbBoxBlue.Size = new System.Drawing.Size(38, 20);
            this.rgbBoxBlue.TabIndex = 3;
            this.rgbBoxBlue.Text = "0";
            this.rgbBoxBlue.value = 0;
            this.rgbBoxBlue.TextChanged += new System.EventHandler(this.rgbBoxBlue_TextChanged);
            // 
            // rgbBoxGreen
            // 
            this.rgbBoxGreen.ForeColor = System.Drawing.Color.Black;
            this.rgbBoxGreen.isDec = true;
            this.rgbBoxGreen.Location = new System.Drawing.Point(88, 37);
            this.rgbBoxGreen.MaxLength = 3;
            this.rgbBoxGreen.Name = "rgbBoxGreen";
            this.rgbBoxGreen.Size = new System.Drawing.Size(38, 20);
            this.rgbBoxGreen.TabIndex = 3;
            this.rgbBoxGreen.Text = "0";
            this.rgbBoxGreen.value = 0;
            this.rgbBoxGreen.TextChanged += new System.EventHandler(this.rgbBoxGreen_TextChanged);
            // 
            // rgbBoxRed
            // 
            this.rgbBoxRed.ForeColor = System.Drawing.Color.Black;
            this.rgbBoxRed.isDec = true;
            this.rgbBoxRed.Location = new System.Drawing.Point(88, 11);
            this.rgbBoxRed.MaxLength = 3;
            this.rgbBoxRed.Name = "rgbBoxRed";
            this.rgbBoxRed.Size = new System.Drawing.Size(38, 20);
            this.rgbBoxRed.TabIndex = 3;
            this.rgbBoxRed.Text = "0";
            this.rgbBoxRed.value = 0;
            this.rgbBoxRed.TextChanged += new System.EventHandler(this.rgbBoxRed_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // rgbControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rgbBoxBlue);
            this.Controls.Add(this.rgbBoxGreen);
            this.Controls.Add(this.rgbBoxRed);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rgbControl";
            this.Size = new System.Drawing.Size(283, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private rgbBox rgbBoxRed;
        private rgbBox rgbBoxGreen;
        private rgbBox rgbBoxBlue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
