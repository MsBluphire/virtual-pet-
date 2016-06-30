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

        }

        //methods
       // public void DisplayStatus();


       // public void HungerLevel();

       // public void HappinessLevel();

       // public void Tick();

        //constructors

       // public Pet();


    }
    }
    










