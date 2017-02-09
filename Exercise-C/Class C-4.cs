using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Class_C4
    {
        public void C4()  //出租车费计算
        {
            double d,Fee;
            Console.WriteLine("Please input the travel km: ");
            d = Convert.ToDouble(Console.ReadLine());
            if (d > 9)
            {
                Fee = 2.4 + 85 * 0.04 + (Math.Round(d * 10) - 90) * 0.05;
                Console.WriteLine("The total cost is: ${0:0.0}", Fee);
            }
            else if (d<=9 && d>0.5)
            {
                Fee = 2.4 + (Math.Round(d * 10) - 5) * 0.04;
                Console.WriteLine("The total cost is: ${0:0.0}", Fee);
            }
            else if (d>=0 && d<=0.5)
            {
                Fee = 2.4;
                Console.WriteLine("The total cost is: ${0:0.0}", Fee);
            }
            else
            {
                Console.WriteLine("Wrong Kilometers input !");
            }
        }
    }
}
