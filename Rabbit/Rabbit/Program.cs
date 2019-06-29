using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit iepureA = new Rabbit("Iepurila", EyesColor.Blue, FurColor.Grey, Genders.Female, DateTime.Now);
            iepureA.GetAge();
            Console.WriteLine(iepureA);
            iepureA.Actions();

            Rabbit iepureB = new Rabbit("Buggs", EyesColor.Red, FurColor.White, Genders.Male, new DateTime(2018, 01, 01));
            iepureB.GetAge();
            Console.WriteLine(iepureB);
            iepureB.Actions();
        }
    }
}
