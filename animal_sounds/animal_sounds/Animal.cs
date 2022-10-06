using System;
namespace animal_sounds
{
    public class Animal
    {

        // Declaring the class variables.
        protected string name;
        protected float age;
        protected float weight;
        protected string food;
        protected float sleep_time;

        // Non-default constructor.
        public Animal(string name, float age,
                    float weight, string food,
                    float sleep_time)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.food = food;
            this.sleep_time = sleep_time;
        }

        // Methods.
        public void eat()
        {
            Console.WriteLine("{0} eats {1}", this.GetType().Name, this.food);
        }


        public void sleep()
        {
            Console.WriteLine("{0} sleeps for {1} hours a day",
                this.GetType().Name, this.sleep_time);
        }

        public void say()
        {
            Console.WriteLine("What does the {0} say?",
                this.GetType().Name);
        }


    }
}

