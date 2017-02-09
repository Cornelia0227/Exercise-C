using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Class_C3
    {
        public void C3()
        {
            int mark;
            Console.WriteLine("Please input the student's mark: ");
            mark = Convert.ToInt32(Console.ReadLine());
            if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("You scored {0} marks which is A grade.", mark);
            }
            else if (mark >= 60 && mark < 80)
            {
                Console.WriteLine("You scored {0} marks which is B grade.", mark);
            }
            else if (mark>=40 && mark<60)
            {
                Console.WriteLine("You scored {0} marks which is C grade.", mark);
            }
            else if (mark>=0 && mark<40)
            {
                Console.WriteLine("You scored {0} marks which is F grade.", mark);
            }
            else
            {
                Console.WriteLine("Wrong student mark input !");
            }
        }
    }
}
