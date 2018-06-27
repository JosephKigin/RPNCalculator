using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPN_Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            Display.lblDisplayX = lblRegisterX;
            Display.lblDisplayY = lblRegisterY;
            Display.lblDisplayZ = lblRegisterZ;
            Display.lblDisplayT = lblRegisterT;
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn =  (Button)sender;
            Input.UserInput(btn.Text);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            RPN_Stack.Clear();
            Input.ResetInput();
        }

        private void btnXSquared_Click(object sender, EventArgs e)
        {
            Operations.XSquared();
            Input.ResetInput();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            Operations.SquareRoot();
            Input.ResetInput();
        }

        private void btnSwitchSigns_Click(object sender, EventArgs e)
        {
            Operations.SwitchSigns();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operations.Division();
            Input.ResetInput();
        }

        private void btnClearX_Click(object sender, EventArgs e)
        {
            RPN_Stack.ClearX();
            Input.ResetInput();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            Operations.Reciprocal();
            Input.ResetInput();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operations.Multiplication();
            Input.ResetInput();
        }

        private void btnRollUp_Click(object sender, EventArgs e)
        {
            RPN_Stack.RollUp();
            Input.ResetInput();
        }

        private void btnExponents_Click(object sender, EventArgs e)
        {
            Operations.Exponents();
            Input.ResetInput();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operations.Subtraction();
            Input.ResetInput();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operations.Addition();
            Input.ResetInput();
        }

        private void btnSwapXY_Click(object sender, EventArgs e)
        {
            Operations.SwapXY();
            Input.ResetInput();
        }

        private void btnRollDown_Click(object sender, EventArgs e)
        {
            RPN_Stack.RollDown();
            Input.ResetInput();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            RPN_Stack.Pop();
            Input.ResetInput();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Input.inDecimal = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            RPN_Stack.Push(0);
            Input.ResetInput();
        }
    }
}
