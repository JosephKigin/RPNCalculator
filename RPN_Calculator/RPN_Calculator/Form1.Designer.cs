namespace RPN_Calculator
{
    partial class FormCalculator
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnExponents = new System.Windows.Forms.Button();
            this.btnRollUp = new System.Windows.Forms.Button();
            this.btnRollDown = new System.Windows.Forms.Button();
            this.btnSwapXY = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnXSquared = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSwitchSigns = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnClearX = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPop = new System.Windows.Forms.Button();
            this.lblRegisterX = new System.Windows.Forms.Label();
            this.lblRegisterY = new System.Windows.Forms.Label();
            this.lblRegisterT = new System.Windows.Forms.Label();
            this.lblRegisterZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(228, 534);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(294, 534);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(360, 534);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(294, 600);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(126, 60);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "↑ENTER↑";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(162, 600);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(228, 600);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(60, 60);
            this.btnDecimal.TabIndex = 6;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(360, 336);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 60);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(360, 402);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 60);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(360, 468);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 60);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(294, 468);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(228, 468);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(162, 468);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnExponents
            // 
            this.btnExponents.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponents.Location = new System.Drawing.Point(96, 468);
            this.btnExponents.Name = "btnExponents";
            this.btnExponents.Size = new System.Drawing.Size(60, 60);
            this.btnExponents.TabIndex = 15;
            this.btnExponents.Text = "Y^X";
            this.btnExponents.UseVisualStyleBackColor = true;
            this.btnExponents.Click += new System.EventHandler(this.btnExponents_Click);
            // 
            // btnRollUp
            // 
            this.btnRollUp.Location = new System.Drawing.Point(30, 468);
            this.btnRollUp.Name = "btnRollUp";
            this.btnRollUp.Size = new System.Drawing.Size(60, 60);
            this.btnRollUp.TabIndex = 16;
            this.btnRollUp.Text = "R↑";
            this.btnRollUp.UseVisualStyleBackColor = true;
            this.btnRollUp.Click += new System.EventHandler(this.btnRollUp_Click);
            // 
            // btnRollDown
            // 
            this.btnRollDown.Location = new System.Drawing.Point(30, 534);
            this.btnRollDown.Name = "btnRollDown";
            this.btnRollDown.Size = new System.Drawing.Size(60, 60);
            this.btnRollDown.TabIndex = 17;
            this.btnRollDown.Text = "R↓";
            this.btnRollDown.UseVisualStyleBackColor = true;
            this.btnRollDown.Click += new System.EventHandler(this.btnRollDown_Click);
            // 
            // btnSwapXY
            // 
            this.btnSwapXY.Location = new System.Drawing.Point(96, 534);
            this.btnSwapXY.Name = "btnSwapXY";
            this.btnSwapXY.Size = new System.Drawing.Size(60, 60);
            this.btnSwapXY.TabIndex = 18;
            this.btnSwapXY.Text = "X↔Y";
            this.btnSwapXY.UseVisualStyleBackColor = true;
            this.btnSwapXY.Click += new System.EventHandler(this.btnSwapXY_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(162, 534);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(228, 336);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(60, 60);
            this.btnSquareRoot.TabIndex = 20;
            this.btnSquareRoot.Text = "√X";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnXSquared
            // 
            this.btnXSquared.Location = new System.Drawing.Point(162, 336);
            this.btnXSquared.Name = "btnXSquared";
            this.btnXSquared.Size = new System.Drawing.Size(60, 60);
            this.btnXSquared.TabIndex = 21;
            this.btnXSquared.Text = "X^2";
            this.btnXSquared.UseVisualStyleBackColor = true;
            this.btnXSquared.Click += new System.EventHandler(this.btnXSquared_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(30, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 60);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSwitchSigns
            // 
            this.btnSwitchSigns.Location = new System.Drawing.Point(294, 336);
            this.btnSwitchSigns.Name = "btnSwitchSigns";
            this.btnSwitchSigns.Size = new System.Drawing.Size(60, 60);
            this.btnSwitchSigns.TabIndex = 24;
            this.btnSwitchSigns.Text = "±";
            this.btnSwitchSigns.UseVisualStyleBackColor = true;
            this.btnSwitchSigns.Click += new System.EventHandler(this.btnSwitchSigns_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(228, 402);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 25;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(162, 402);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(96, 402);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(60, 60);
            this.btnReciprocal.TabIndex = 27;
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnClearX
            // 
            this.btnClearX.Location = new System.Drawing.Point(30, 402);
            this.btnClearX.Name = "btnClearX";
            this.btnClearX.Size = new System.Drawing.Size(60, 60);
            this.btnClearX.TabIndex = 28;
            this.btnClearX.Text = "CX";
            this.btnClearX.UseVisualStyleBackColor = true;
            this.btnClearX.Click += new System.EventHandler(this.btnClearX_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(294, 402);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 29;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 55);
            this.label1.TabIndex = 34;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "T:";
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(30, 600);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(126, 60);
            this.btnPop.TabIndex = 38;
            this.btnPop.Text = "↓POP↓";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // lblRegisterX
            // 
            this.lblRegisterX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegisterX.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterX.Location = new System.Drawing.Point(56, 191);
            this.lblRegisterX.Name = "lblRegisterX";
            this.lblRegisterX.Size = new System.Drawing.Size(364, 55);
            this.lblRegisterX.TabIndex = 39;
            this.lblRegisterX.Text = "0";
            this.lblRegisterX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegisterY
            // 
            this.lblRegisterY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegisterY.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterY.Location = new System.Drawing.Point(58, 142);
            this.lblRegisterY.Name = "lblRegisterY";
            this.lblRegisterY.Size = new System.Drawing.Size(364, 28);
            this.lblRegisterY.TabIndex = 40;
            this.lblRegisterY.Text = "0";
            this.lblRegisterY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegisterT
            // 
            this.lblRegisterT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegisterT.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterT.Location = new System.Drawing.Point(56, 42);
            this.lblRegisterT.Name = "lblRegisterT";
            this.lblRegisterT.Size = new System.Drawing.Size(364, 28);
            this.lblRegisterT.TabIndex = 41;
            this.lblRegisterT.Text = "0";
            this.lblRegisterT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegisterZ
            // 
            this.lblRegisterZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegisterZ.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterZ.Location = new System.Drawing.Point(58, 91);
            this.lblRegisterZ.Name = "lblRegisterZ";
            this.lblRegisterZ.Size = new System.Drawing.Size(364, 28);
            this.lblRegisterZ.TabIndex = 42;
            this.lblRegisterZ.Text = "0";
            this.lblRegisterZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 682);
            this.Controls.Add(this.lblRegisterZ);
            this.Controls.Add(this.lblRegisterT);
            this.Controls.Add(this.lblRegisterY);
            this.Controls.Add(this.lblRegisterX);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnClearX);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnSwitchSigns);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXSquared);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSwapXY);
            this.Controls.Add(this.btnRollDown);
            this.Controls.Add(this.btnRollUp);
            this.Controls.Add(this.btnExponents);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Name = "FormCalculator";
            this.Text = "RPN Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnExponents;
        private System.Windows.Forms.Button btnRollUp;
        private System.Windows.Forms.Button btnRollDown;
        private System.Windows.Forms.Button btnSwapXY;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnXSquared;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSwitchSigns;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnClearX;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Label lblRegisterX;
        private System.Windows.Forms.Label lblRegisterY;
        private System.Windows.Forms.Label lblRegisterT;
        private System.Windows.Forms.Label lblRegisterZ;
    }
}

