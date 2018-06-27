using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPN_Calculator
{
    static class Input
    {
        public static bool inDecimal { get; set; }
        public static bool inNumber { get; set; }
        private static string currentX;

        public static void UserInput(string theDigit)
        {
            if (inNumber == false)
            {                
                if (inDecimal == true) 
                { 
                    currentX += "0.";
                    inDecimal = false;
                }
                else 
                { 
                    currentX += theDigit; 
                }

                inNumber = true;
            }
            else 
            {                
                if (inDecimal == true && !currentX.Contains("."))
                {
                    currentX += ".";
                    inDecimal = false;
                }
                currentX += theDigit;
            }

            RPN_Stack.PushNoUpdate(double.Parse(currentX));
            Display.UpdateCurrentNumber(currentX);
                        
        }

        public static void ResetInput()
        {
            inDecimal = false;
            inNumber = false;
            currentX = "";
        }
    }
}
