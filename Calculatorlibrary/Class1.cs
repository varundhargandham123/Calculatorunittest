using System;

namespace Calculatorlibrary
{
    public class Class1
    {

        public static int add(int a, int b)
        {
            if((a==int.MaxValue && b > 0) 
                
                || (b == int.MaxValue && a > 0))
            {
                throw new System.OverflowException();
            }

            return a + b;
        }
        public static int  sub(int a, int b)

        {
            if ((a == int.MinValue && b > 0)

               || (b == int.MinValue && a < 0))
            {
                throw new System.OverflowException();
            }
            return a - b;
        }
        public static int mul(int a, int b)
        {
            return a * b;
        }
    }
}

