using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operators
    {
        public float num1;
        public float num2;
        public float ADDITION(float num1,float num2)
        {
            return num1 + num2;
        }
        public float SUBTARCTION(float num1,float num2)
        {
            return num1 - num2;
        }
        public float MULTIPLICATION(float num1,float num2)
        {
            return num1 * num2;
        }
        public float DIVISION(float num1,float num2) {
        return num1 / num2;
        }

    }
}
