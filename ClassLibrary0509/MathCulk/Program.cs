using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary0509;

namespace MathCulk
{
    class Program
    {
        static void Main(string[] args)
        {
            MathHelper calculator = new MathHelper();
            int r = calculator.Add(3, 7);
            int R = calculator.Subtract(r, -7);
            Console.WriteLine($"3+7={0}10-7={1}"
                +Environment.NewLine+"Press ane key..." ,r,R);
            Console.ReadKey();
        }
    }
}
