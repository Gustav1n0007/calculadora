namespace calculadora
{
    partial class frmCelsius
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            button10 = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnConverter = new Button();
            txtVisor = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(28, 123);
            btn1.Name = "btn1";
            btn1.Size = new Size(74, 66);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(108, 123);
            btn2.Name = "btn2";
            btn2.Size = new Size(74, 66);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(188, 123);
            btn3.Name = "btn3";
            btn3.Size = new Size(74, 66);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(188, 195);
            btn6.Name = "btn6";
            btn6.Size = new Size(74, 66);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(108, 195);
            btn5.Name = "btn5";
            btn5.Size = new Size(74, 66);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(28, 195);
            btn4.Name = "btn4";
            btn4.Size = new Size(74, 66);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(188, 267);
            btn9.Name = "btn9";
            btn9.Size = new Size(74, 66);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(108, 267);
            btn8.Name = "btn8";
            btn8.Size = new Size(74, 66);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(28, 267);
            btn7.Name = "btn7";
            btn7.Size = new Size(74, 66);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // button10
            // 
            button10.Location = new Point(188, 339);
            button10.Name = "button10";
            button10.Size = new Size(74, 66);
            button10.TabIndex = 11;
            button10.Text = "C";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(108, 339);
            btn0.Name = "btn0";
            btn0.Size = new Size(74, 66);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(28, 339);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(74, 66);
            btnDecimal.TabIndex = 9;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(28, 411);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(234, 44);
            btnConverter.TabIndex = 12;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtVisor
            // 
            txtVisor.Location = new Point(28, 25);
            txtVisor.Multiline = true;
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(234, 83);
            txtVisor.TabIndex = 13;
            // 
            // frmCelsius
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 473);
            Controls.Add(txtVisor);
            Controls.Add(btnConverter);
            Controls.Add(button10);
            Controls.Add(btn0);
            Controls.Add(btnDecimal);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "frmCelsius";
            Text = "frmCelsius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button button10;
        private Button btn0;
        private Button btnDecimal;
        private Button btnConverter;
        private TextBox txtVisor;
    }
}