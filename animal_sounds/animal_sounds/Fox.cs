using System;
namespace animal_sounds
{
    public class Fox : Animal   // Fox class inherits Animal class.
    {
        // Non-Default Constructor.
        public Fox(string name, float age,
                    float weight, string food,
                    float sleep_time) : base(name, age, weight, food, sleep_time)
        {

        }

        new public void say()
        {
            base.say();  // Calling the say() method of the base class.
            Console.WriteLine("{0} says Ring-ding-ding-ding-dingeringeding.",
                this.GetType().Name);
        }



    }
}

