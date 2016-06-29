using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        //instance variables
        private string name;
        private string type;
        private int age;
        private int hunger;
        private int happiness;
        //private bool sick;

        //properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                    age = 1;
                else
                    age = value;
            }

        }
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }
        public int Happiness
        {
            get
            {
                return happiness;
            }
            set
            {
                happiness = value;
            }
            //{
            //public bool Sick
            //{
            //  get
            // {
            //     return sick;
            // }
            // set
            // {
            //     sick = value;
            // }
        }

        //methods
        public void DisplayStats();
        {
            Console.WriteLine("Your virtual pet's name is {0}", Name);
            Console.WriteLine("Your virtual pet's age is {0}", Age);
            Console.WriteLine("Your virtual pet's type is {0}", Type);
        }

    //constructors
    public Pet(string name, string type, int age, int happiness, int hunger);
    {
   

}
    }
}
