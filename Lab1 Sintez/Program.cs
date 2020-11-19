using System;

namespace Lab1_Sintez
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 1;
            double B = 1.5;
            double L = A - B;
            double xm = (A + B) / 2;
            double x1=0, x2=0;
            double Fxm = FunctionCalculate2(xm);
            double Fx1, Fx2;
            double e = 0.001;
            int iteration = 0;
            Console.WriteLine("Started values: a={0}, b={1}, L={2}, x1={3}, x2={4}", A,B,L,x1,x2);
            do
            {
                x1 = A + L / 4;
                x2 = B - L / 4;

                Fx1 = FunctionCalculate2(x1);
                Fx2 = FunctionCalculate2(x2);

                if (Fx1 < Fxm)
                {
                    B = xm;
                    xm = x1;
                }
                else
                {
                    if (Fx2 < Fxm)
                    {
                        A = xm;
                        xm = x2;
                    }
                    else
                    {
                        A = x1;
                        B = x2;
                    }
                }
                L = B - A;


                Console.WriteLine("Iteration {0}: a={1}, b={2}, L={3}, x1={4}, x2={5}",iteration, A, B, L, x1, x2);
                iteration++;              
            }
            while (Math.Abs(L)>e);

            Console.WriteLine("Result: x1={0}, x2={1}",x1,x2 );
        }

        public static double FunctionCalculate2(double x)
        {
            double result;
            double e = 2.71828182846;
            result = 2 * x - Math.Pow(x, 2) - Math.Pow(e, -x);
            return result;
        }
    }
}
