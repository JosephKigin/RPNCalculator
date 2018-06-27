using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPN_Calculator
{
    static class Display
    {
        public static void UpdateDisplay()
        {
            lblDisplayX.Text = RPN_Stack.RegisterX.ToString();
            lblDisplayY.Text = RPN_Stack.RegisterY.ToString();
            lblDisplayZ.Text = RPN_Stack.RegisterZ.ToString();
            lblDisplayT.Text = RPN_Stack.RegisterT.ToString();
        }

        public static void UpdateCurrentNumber(string currentX)
        {
            lblDisplayX.Text = currentX;
        }
        public static Label lblDisplayX { get; set; }
        public static Label lblDisplayY { get; set; }
        public static Label lblDisplayZ { get; set; }
        public static Label lblDisplayT { get; set; }
    }
}
