using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Class_C1
    {
        public void C1()
        {
            string name;char gender;
            Console.WriteLine("Please input your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please input your sex(M/F): ");
            gender = Convert.ToChar(Console.ReadLine());
            if (gender == 'M')
            {
                Console.WriteLine("Good Morning Mr. {0} !", name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Good Morning Ms. {0} !", name);
            }
            else
            {
                Console.WriteLine("Wrong Gender input !");
            }
        }
    }
}
