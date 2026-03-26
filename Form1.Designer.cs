namespace SimpleCalculator
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
            Simple_Calculator = new Label();
            process_txt = new TextBox();
            result_txt = new TextBox();
            CE_but = new Button();
            C_but = new Button();
            but_div = new Button();
            Del_but = new Button();
            but_mul = new Button();
            but_9 = new Button();
            but_8 = new Button();
            but_7 = new Button();
            but_mi = new Button();
            but_6 = new Button();
            but_5 = new Button();
            but_4 = new Button();
            but_pl = new Button();
            but_3 = new Button();
            but_2 = new Button();
            but_1 = new Button();
            but_eq = new Button();
            but_Dec = new Button();
            but_0 = new Button();
            change_but = new Button();
            SuspendLayout();
            // 
            // Simple_Calculator
            // 
            Simple_Calculator.AutoSize = true;
            Simple_Calculator.Font = new Font("맑은 고딕", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Simple_Calculator.ForeColor = SystemColors.Highlight;
            Simple_Calculator.Location = new Point(178, 9);
            Simple_Calculator.Name = "Simple_Calculator";
            Simple_Calculator.Size = new Size(426, 65);
            Simple_Calculator.TabIndex = 0;
            Simple_Calculator.Text = "Simple Calculator";
            // 
            // process_txt
            // 
            process_txt.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            process_txt.Location = new Point(71, 77);
            process_txt.Name = "process_txt";
            process_txt.Size = new Size(664, 45);
            process_txt.TabIndex = 1;
            // 
            // result_txt
            // 
            result_txt.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            result_txt.Location = new Point(71, 128);
            result_txt.Name = "result_txt";
            result_txt.Size = new Size(664, 45);
            result_txt.TabIndex = 2;
            // 
            // CE_but
            // 
            CE_but.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            CE_but.Location = new Point(71, 182);
            CE_but.Name = "CE_but";
            CE_but.Size = new Size(150, 70);
            CE_but.TabIndex = 3;
            CE_but.Text = "CE";
            CE_but.UseVisualStyleBackColor = true;
            // 
            // C_but
            // 
            C_but.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            C_but.Location = new Point(242, 182);
            C_but.Name = "C_but";
            C_but.Size = new Size(150, 70);
            C_but.TabIndex = 4;
            C_but.Text = "C";
            C_but.UseVisualStyleBackColor = true;
            // 
            // but_div
            // 
            but_div.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_div.ForeColor = Color.Red;
            but_div.Location = new Point(585, 182);
            but_div.Name = "but_div";
            but_div.Size = new Size(150, 70);
            but_div.TabIndex = 6;
            but_div.Text = "÷";
            but_div.UseVisualStyleBackColor = true;
            but_div.Click += but_div_Click;
            // 
            // Del_but
            // 
            Del_but.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            Del_but.Location = new Point(416, 182);
            Del_but.Name = "Del_but";
            Del_but.Size = new Size(150, 70);
            Del_but.TabIndex = 5;
            Del_but.Text = "Del";
            Del_but.UseVisualStyleBackColor = true;
            // 
            // but_mul
            // 
            but_mul.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_mul.ForeColor = Color.Red;
            but_mul.Location = new Point(585, 258);
            but_mul.Name = "but_mul";
            but_mul.Size = new Size(150, 70);
            but_mul.TabIndex = 10;
            but_mul.Text = "×";
            but_mul.UseVisualStyleBackColor = true;
            but_mul.Click += but_mul_Click;
            // 
            // but_9
            // 
            but_9.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_9.ForeColor = SystemColors.MenuHighlight;
            but_9.Location = new Point(416, 258);
            but_9.Name = "but_9";
            but_9.Size = new Size(150, 70);
            but_9.TabIndex = 9;
            but_9.Text = "9";
            but_9.UseVisualStyleBackColor = true;
            but_9.Click += but_9_Click;
            // 
            // but_8
            // 
            but_8.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_8.ForeColor = SystemColors.MenuHighlight;
            but_8.Location = new Point(242, 258);
            but_8.Name = "but_8";
            but_8.Size = new Size(150, 70);
            but_8.TabIndex = 8;
            but_8.Text = "8";
            but_8.UseVisualStyleBackColor = true;
            but_8.Click += but_8_Click;
            // 
            // but_7
            // 
            but_7.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_7.ForeColor = SystemColors.MenuHighlight;
            but_7.Location = new Point(71, 258);
            but_7.Name = "but_7";
            but_7.Size = new Size(150, 70);
            but_7.TabIndex = 7;
            but_7.Text = "7";
            but_7.UseVisualStyleBackColor = true;
            but_7.Click += but_7_Click;
            // 
            // but_mi
            // 
            but_mi.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_mi.ForeColor = Color.Red;
            but_mi.Location = new Point(585, 334);
            but_mi.Name = "but_mi";
            but_mi.Size = new Size(150, 70);
            but_mi.TabIndex = 14;
            but_mi.Text = "-";
            but_mi.UseVisualStyleBackColor = true;
            but_mi.Click += but_mi_Click;
            // 
            // but_6
            // 
            but_6.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_6.ForeColor = SystemColors.MenuHighlight;
            but_6.Location = new Point(416, 334);
            but_6.Name = "but_6";
            but_6.Size = new Size(150, 70);
            but_6.TabIndex = 13;
            but_6.Text = "6";
            but_6.UseVisualStyleBackColor = true;
            but_6.Click += but_6_Click;
            // 
            // but_5
            // 
            but_5.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_5.ForeColor = SystemColors.MenuHighlight;
            but_5.Location = new Point(242, 334);
            but_5.Name = "but_5";
            but_5.Size = new Size(150, 70);
            but_5.TabIndex = 12;
            but_5.Text = "5";
            but_5.UseVisualStyleBackColor = true;
            but_5.Click += but_5_Click;
            // 
            // but_4
            // 
            but_4.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_4.ForeColor = SystemColors.MenuHighlight;
            but_4.Location = new Point(71, 334);
            but_4.Name = "but_4";
            but_4.Size = new Size(150, 70);
            but_4.TabIndex = 11;
            but_4.Text = "4";
            but_4.UseVisualStyleBackColor = true;
            but_4.Click += but_4_Click;
            // 
            // but_pl
            // 
            but_pl.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_pl.ForeColor = Color.Red;
            but_pl.Location = new Point(585, 410);
            but_pl.Name = "but_pl";
            but_pl.Size = new Size(150, 70);
            but_pl.TabIndex = 18;
            but_pl.Text = "+";
            but_pl.UseVisualStyleBackColor = true;
            but_pl.Click += but_pl_Click;
            // 
            // but_3
            // 
            but_3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_3.ForeColor = SystemColors.MenuHighlight;
            but_3.Location = new Point(416, 410);
            but_3.Name = "but_3";
            but_3.Size = new Size(150, 70);
            but_3.TabIndex = 17;
            but_3.Text = "3";
            but_3.UseVisualStyleBackColor = true;
            but_3.Click += but_3_Click;
            // 
            // but_2
            // 
            but_2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_2.ForeColor = SystemColors.MenuHighlight;
            but_2.Location = new Point(242, 410);
            but_2.Name = "but_2";
            but_2.Size = new Size(150, 70);
            but_2.TabIndex = 16;
            but_2.Text = "2";
            but_2.UseVisualStyleBackColor = true;
            but_2.Click += but_2_Click;
            // 
            // but_1
            // 
            but_1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_1.ForeColor = SystemColors.MenuHighlight;
            but_1.Location = new Point(71, 410);
            but_1.Name = "but_1";
            but_1.Size = new Size(150, 70);
            but_1.TabIndex = 15;
            but_1.Text = "1";
            but_1.UseVisualStyleBackColor = true;
            but_1.Click += but_1_Click;
            // 
            // but_eq
            // 
            but_eq.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_eq.Location = new Point(585, 486);
            but_eq.Name = "but_eq";
            but_eq.Size = new Size(150, 70);
            but_eq.TabIndex = 22;
            but_eq.Text = "=";
            but_eq.UseVisualStyleBackColor = true;
            but_eq.Click += but_eq_Click;
            // 
            // but_Dec
            // 
            but_Dec.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_Dec.Location = new Point(416, 486);
            but_Dec.Name = "but_Dec";
            but_Dec.Size = new Size(150, 70);
            but_Dec.TabIndex = 21;
            but_Dec.Text = ".";
            but_Dec.UseVisualStyleBackColor = true;
            // 
            // but_0
            // 
            but_0.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            but_0.ForeColor = SystemColors.MenuHighlight;
            but_0.Location = new Point(242, 486);
            but_0.Name = "but_0";
            but_0.Size = new Size(150, 70);
            but_0.TabIndex = 20;
            but_0.Text = "0";
            but_0.UseVisualStyleBackColor = true;
            but_0.Click += but_0_Click;
            // 
            // change_but
            // 
            change_but.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            change_but.Location = new Point(71, 486);
            change_but.Name = "change_but";
            change_but.Size = new Size(150, 70);
            change_but.TabIndex = 19;
            change_but.Text = "+/-";
            change_but.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(but_eq);
            Controls.Add(but_Dec);
            Controls.Add(but_0);
            Controls.Add(change_but);
            Controls.Add(but_pl);
            Controls.Add(but_3);
            Controls.Add(but_2);
            Controls.Add(but_1);
            Controls.Add(but_mi);
            Controls.Add(but_6);
            Controls.Add(but_5);
            Controls.Add(but_4);
            Controls.Add(but_mul);
            Controls.Add(but_9);
            Controls.Add(but_8);
            Controls.Add(but_7);
            Controls.Add(but_div);
            Controls.Add(Del_but);
            Controls.Add(C_but);
            Controls.Add(CE_but);
            Controls.Add(result_txt);
            Controls.Add(process_txt);
            Controls.Add(Simple_Calculator);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Simple_Calculator;
        private TextBox process_txt;
        private TextBox result_txt;
        private Button CE_but;
        private Button C_but;
        private Button but_div;
        private Button Del_but;
        private Button but_mul;
        private Button but_9;
        private Button but_8;
        private Button but_7;
        private Button but_mi;
        private Button but_6;
        private Button but_5;
        private Button but_4;
        private Button but_pl;
        private Button but_3;
        private Button but_2;
        private Button but_1;
        private Button but_eq;
        private Button but_Dec;
        private Button but_0;
        private Button change_but;
    }
}
