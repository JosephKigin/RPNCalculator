using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_Calculator
{
    static class Operations
    {
       
        public static void Addition()
        {
            
            double valueX = RPN_Stack.Pop();
            double valueY = RPN_Stack.Pop();
            RPN_Stack.Push(valueY + valueX);
        }

        public static void Subtraction()
        {
            double valueX = RPN_Stack.Pop(),
                   valueY = RPN_Stack.Pop();
            RPN_Stack.Push(valueY - valueX);
        }

        public static void Multiplication()
        {
            double valueX = RPN_Stack.Pop(),
                   valueY = RPN_Stack.Pop();
            RPN_Stack.Push(valueY * valueX);
        }

        public static void Division()
        {
            double valueX = RPN_Stack.Pop(),
                   valueY = RPN_Stack.Pop();
            RPN_Stack.Push(valueY / valueX);
        }

        public static void Exponents()
        {
            double valueX = RPN_Stack.Pop(),
                   valueY = RPN_Stack.Pop();
            RPN_Stack.Push(Math.Pow(valueY, valueX));
        }

        public static void XSquared()
        {
            RPN_Stack.Push(Math.Pow(RPN_Stack.Pop(), 2));
        }

        public static void SwitchSigns()
        {
            RPN_Stack.Push(RPN_Stack.Pop() * -1);
        }

        public static void Reciprocal()
        {
            RPN_Stack.Push(1 / RPN_Stack.Pop());
        }

        public static void SwapXY()
        {
            double valueX = RPN_Stack.Pop();
            double valueY = RPN_Stack.Pop();
            RPN_Stack.Push(valueX);
            RPN_Stack.Push(valueY);
        }

        public static void SquareRoot()
        {
            RPN_Stack.Push(Math.Sqrt(RPN_Stack.Pop()));
        }
    }
}
