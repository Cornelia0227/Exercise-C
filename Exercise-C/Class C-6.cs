using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Class_C6
    {
        public void C6()
        {
            int tv=900, dvd=500, mp3=700;
            int total;
            double Discounted;
            int[] num = new int[3];
            Console.WriteLine("Please input the Number of TV,DVD,MP3: ");

            int i;
            for (i=0;i<3;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] < 0) { Console.WriteLine("Wrong input!");break; }
            }
            total = num[0] * tv + num[1] * dvd + num[2] * mp3;
            if (total > 10000)
            {
                Discounted = (num[0] * tv + num[1] * dvd) * (1 - 0.15) + num[2] * mp3;
                Console.WriteLine("The total discounted price is: {0:###0}", Discounted);
            }
            else if (total > 5000 && total <= 10000)
            {
                Discounted = (num[0] * tv + num[1] * dvd) * (1 - 0.1) + num[2] * mp3;
                Console.WriteLine("The total discounted price is: {0:###0}", Discounted);
            }
            else if (total <= 5000 && total >= 0)
            {
                Discounted = total;
                Console.WriteLine("The total discounted price is: {0:###0}", Discounted);
            }
        }
    }
}
