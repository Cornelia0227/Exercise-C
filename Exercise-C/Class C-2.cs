using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Class_C2
    {
        public void C2()
        {
            string name;
            char gender;
            int age;
            Console.WriteLine("Please input your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please input your sex(M/F): ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please input your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (gender == 'M')
            {
                if (age < 40 && age >= 0)
                {
                    Console.WriteLine("Good Morning Mr. {0} !", name);
                }
                else if (age >= 40)
                {
                    Console.WriteLine("Good Morning Uncle. {0} !", name);
                }
                else { Console.WriteLine("Wrong Age input !"); }
            }
            else if (gender == 'F')
            {
                if (age < 40 && age >= 0)
                {
                    Console.WriteLine("Good Morning Ms. {0} !", name);
                }
                else if(age>=40)
                {
                    Console.WriteLine("Good Morning Aunty {0} !", name);
                }
                else { Console.WriteLine("Wrong Age input !"); }
            }
            else
            {
                Console.WriteLine("Wrong Gender input !");
            }
        }
    }
}
