using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Class_C5
    {
        public void C5()
        {
            int num; bool result;
            Console.WriteLine("Input a 3-digit Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int a = num / 100;
            int b = num / 10 - a * 10;
            int c = num - b * 10 - a * 100;
            int t = Convert.ToInt32(Math.Pow(a, 3)+Math.Pow(b,3)+Math.Pow(c,3));

            if (t==num) { result = true; }
            else { result = false; }

            Console.WriteLine("The Armstrong number check result is: {0}. ",result);
        }
    }
}
