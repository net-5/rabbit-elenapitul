using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    //1. Eyes: Blue Red Black
    public enum EyesColor
    {
        Blue,
        Red,
        Black
    };
    //2. Fur: White Brown Black Grey
    public enum FurColor
    {
        White,
        Brown,
        Black,
        Grey
    };
    //3. Gender
    public enum Genders
    {
        Female,
        Male
    };
       
    

    public class Rabbit
    {
        private string name;
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
        
        
        public EyesColor Eyes { get; }
        public FurColor Fur { get; }
        public Genders Gender { get; }
        public DateTime BirthDate { get; }

        //5. Is a mammal that moves, sleeps, eats

        public Rabbit (string name, EyesColor eyes, FurColor fur, Genders gender, DateTime birthDate)
        {
            this.name = name;
            Eyes = eyes;
            Fur = fur;
            Gender = gender;
            BirthDate = birthDate;
        }

        //4. Birth Date - based on this, see how old the rabbit is
        public string GetAge()
        {
            int years = DateTime.Now.Subtract(BirthDate).Days / 365;
            int days = DateTime.Now.Subtract(BirthDate).Days % 365;
            if (years < 0 || days < 0)
            {
                return "In progress";
            }
            else if (years == 0)
            {
                return days + " days";
            }
            else
            {
                return (years + " years and " + days + " days");
            }
                
        }

        public override string ToString()
        {
            return "The rabbit called " + this.name + " has " + Eyes + " eyes, " + Fur + " fur.\n" + 
                "It's a " + Gender + ", born in " + BirthDate.ToShortDateString() + " and is " + GetAge() + " old.";
        }

        //5. Is a mammal that moves, sleeps, eats
        public void Actions()
        {
            Console.WriteLine($"{this.name} is a mammal that moves, sleeps, eats.\n");
        }

    }
}
