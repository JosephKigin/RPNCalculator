using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPN_Calculator
{
    public static class RPN_Stack
    {
        private static List<double> register = new List<double>(4) {0,0,0,0};
        

        public static double RegisterX
        {
            get { return register[0]; }
        }
        public static double RegisterY
        {
            get { return register[1]; }
        }
        public static double RegisterZ
        {
            get { return register[2]; }
        }
        public static double RegisterT
        {
            get { return register[3]; }
        }


        public static double Pop()
        {
            double memory = register[0];
            register[0] = register[1];
            register[1] = register[2];
            register[2] = register[3];
            Display.UpdateDisplay();
            return memory;
        }

        public static void Push(double inputValue)
        {
            register[3] = register[2];
            register[2] = register[1];
            register[1] = register[0];
            register[0] = inputValue;
            Display.UpdateDisplay();
        }

        public static void PushNoUpdate(double inputValue)
        {
            register[3] = register[2];
            register[2] = register[1];
            register[1] = register[0];
            register[0] = inputValue;
        }

        public static void RollUp()
        {
            double temp = register[3];
            register[3] = register[2];
            register[2] = register[1];
            register[1] = register[0];
            register[0] = temp;
            Display.UpdateDisplay();
        }

        public static void RollDown()
        {
            double temp = register[0];
            register[0] = register[1];
            register[1] = register[2];
            register[2] = register[3];
            register[3] = temp;
            Display.UpdateDisplay();
        }

        public static void Clear()
        {
            register[0] = 0;
            register[1] = 0;
            register[2] = 0;
            register[3] = 0;
            Display.UpdateDisplay();
        }

        public static void ClearX()
        {
            register[0] = 0;
            Display.UpdateDisplay();
        }
    }
}
