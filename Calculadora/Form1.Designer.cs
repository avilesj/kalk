namespace Calculadora
{
    partial class CalculadoraMain
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gboxFunctions = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.fnClear = new System.Windows.Forms.Button();
            this.fnPlusMinus = new System.Windows.Forms.Button();
            this.fnByX = new System.Windows.Forms.Button();
            this.fnSqrt = new System.Windows.Forms.Button();
            this.fnPower2 = new System.Windows.Forms.Button();
            this.fnModulo = new System.Windows.Forms.Button();
            this.gboxPanel = new System.Windows.Forms.GroupBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.gboxOperands = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gboxFunctions.SuspendLayout();
            this.gboxPanel.SuspendLayout();
            this.gboxOperands.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtResult.Location = new System.Drawing.Point(14, 8);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(276, 37);
            this.txtResult.TabIndex = 0;
            // 
            // gboxFunctions
            // 
            this.gboxFunctions.Controls.Add(this.button7);
            this.gboxFunctions.Controls.Add(this.button6);
            this.gboxFunctions.Controls.Add(this.fnClear);
            this.gboxFunctions.Controls.Add(this.fnPlusMinus);
            this.gboxFunctions.Controls.Add(this.fnByX);
            this.gboxFunctions.Controls.Add(this.fnSqrt);
            this.gboxFunctions.Controls.Add(this.fnPower2);
            this.gboxFunctions.Controls.Add(this.fnModulo);
            this.gboxFunctions.Location = new System.Drawing.Point(14, 51);
            this.gboxFunctions.Name = "gboxFunctions";
            this.gboxFunctions.Size = new System.Drawing.Size(276, 71);
            this.gboxFunctions.TabIndex = 1;
            this.gboxFunctions.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(190, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "DEL";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(103, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // fnClear
            // 
            this.fnClear.Location = new System.Drawing.Point(16, 41);
            this.fnClear.Name = "fnClear";
            this.fnClear.Size = new System.Drawing.Size(75, 23);
            this.fnClear.TabIndex = 5;
            this.fnClear.Text = "CE";
            this.fnClear.UseVisualStyleBackColor = true;
            // 
            // fnPlusMinus
            // 
            this.fnPlusMinus.Location = new System.Drawing.Point(220, 7);
            this.fnPlusMinus.Name = "fnPlusMinus";
            this.fnPlusMinus.Size = new System.Drawing.Size(45, 28);
            this.fnPlusMinus.TabIndex = 4;
            this.fnPlusMinus.Text = "±";
            this.fnPlusMinus.UseVisualStyleBackColor = true;
            this.fnPlusMinus.Click += new System.EventHandler(this.fnPlusMinus_Click);
            // 
            // fnByX
            // 
            this.fnByX.Location = new System.Drawing.Point(169, 7);
            this.fnByX.Name = "fnByX";
            this.fnByX.Size = new System.Drawing.Size(45, 28);
            this.fnByX.TabIndex = 3;
            this.fnByX.Text = "1/x";
            this.fnByX.UseVisualStyleBackColor = true;
            this.fnByX.Click += new System.EventHandler(this.fnByX_Click);
            // 
            // fnSqrt
            // 
            this.fnSqrt.Location = new System.Drawing.Point(67, 7);
            this.fnSqrt.Name = "fnSqrt";
            this.fnSqrt.Size = new System.Drawing.Size(45, 28);
            this.fnSqrt.TabIndex = 2;
            this.fnSqrt.Text = "√";
            this.fnSqrt.UseVisualStyleBackColor = true;
            // 
            // fnPower2
            // 
            this.fnPower2.Location = new System.Drawing.Point(118, 7);
            this.fnPower2.Name = "fnPower2";
            this.fnPower2.Size = new System.Drawing.Size(45, 28);
            this.fnPower2.TabIndex = 1;
            this.fnPower2.Text = "x²";
            this.fnPower2.UseVisualStyleBackColor = true;
            this.fnPower2.Click += new System.EventHandler(this.fnPower2_Click);
            // 
            // fnModulo
            // 
            this.fnModulo.Location = new System.Drawing.Point(16, 7);
            this.fnModulo.Name = "fnModulo";
            this.fnModulo.Size = new System.Drawing.Size(45, 28);
            this.fnModulo.TabIndex = 0;
            this.fnModulo.Text = "%";
            this.fnModulo.UseVisualStyleBackColor = true;
            // 
            // gboxPanel
            // 
            this.gboxPanel.Controls.Add(this.btnDot);
            this.gboxPanel.Controls.Add(this.btn8);
            this.gboxPanel.Controls.Add(this.btn1);
            this.gboxPanel.Controls.Add(this.btn0);
            this.gboxPanel.Controls.Add(this.btn2);
            this.gboxPanel.Controls.Add(this.btn3);
            this.gboxPanel.Controls.Add(this.btn4);
            this.gboxPanel.Controls.Add(this.btn9);
            this.gboxPanel.Controls.Add(this.btn6);
            this.gboxPanel.Controls.Add(this.btn5);
            this.gboxPanel.Controls.Add(this.btn7);
            this.gboxPanel.Location = new System.Drawing.Point(14, 119);
            this.gboxPanel.Name = "gboxPanel";
            this.gboxPanel.Size = new System.Drawing.Size(201, 176);
            this.gboxPanel.TabIndex = 2;
            this.gboxPanel.TabStop = false;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(132, 138);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(53, 32);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(73, 16);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 36);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(132, 98);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 36);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 138);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(110, 32);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(73, 98);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 36);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(16, 98);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 36);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(132, 58);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 36);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(132, 16);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 36);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(16, 58);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 36);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(73, 58);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 36);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 16);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 36);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.e_AddCharacter);
            // 
            // gboxOperands
            // 
            this.gboxOperands.Controls.Add(this.button5);
            this.gboxOperands.Controls.Add(this.button4);
            this.gboxOperands.Controls.Add(this.button3);
            this.gboxOperands.Controls.Add(this.button2);
            this.gboxOperands.Controls.Add(this.button1);
            this.gboxOperands.Location = new System.Drawing.Point(220, 119);
            this.gboxOperands.Name = "gboxOperands";
            this.gboxOperands.Size = new System.Drawing.Size(70, 176);
            this.gboxOperands.TabIndex = 3;
            this.gboxOperands.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CalculadoraMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 300);
            this.Controls.Add(this.gboxOperands);
            this.Controls.Add(this.gboxPanel);
            this.Controls.Add(this.gboxFunctions);
            this.Controls.Add(this.txtResult);
            this.Name = "CalculadoraMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Calculadora";
            this.gboxFunctions.ResumeLayout(false);
            this.gboxPanel.ResumeLayout(false);
            this.gboxOperands.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox gboxFunctions;
        private System.Windows.Forms.GroupBox gboxPanel;
        private System.Windows.Forms.GroupBox gboxOperands;
        private System.Windows.Forms.Button fnPlusMinus;
        private System.Windows.Forms.Button fnByX;
        private System.Windows.Forms.Button fnSqrt;
        private System.Windows.Forms.Button fnPower2;
        private System.Windows.Forms.Button fnModulo;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fnClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

