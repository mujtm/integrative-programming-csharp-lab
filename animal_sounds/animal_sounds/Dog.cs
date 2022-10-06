using System;
namespace animal_sounds
{
    public class Dog : Animal
    {

        // Non-Default Constructor for Dog class.
        public Dog(string name, float age,
                    float weight, string food,
                    float sleep_time) : base(name, age, weight, food, sleep_time)
        {

        }

        new public void say()
        {
            base.say();
            Console.WriteLine("Dog says bow bow.!!!");
        }

    }
}

