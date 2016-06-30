using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input such as name, type and age
            Console.WriteLine("Please enter a name for your pet:");
            string name = Console.ReadLine();

            Console.WriteLine("What type of virtual pet is " + name + "?");
            string type = Console.ReadLine();

            Console.WriteLine("How old is " + name + "?");
            // int age = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Pet myPet = new Pet();

            myPet.DisplayStatus();




            Console.ReadKey();

        }

    }
}
