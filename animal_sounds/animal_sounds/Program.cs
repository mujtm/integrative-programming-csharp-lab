using System;

namespace animal_sounds
{

    public class Program
    {
        public static void Main()
        {
            // Create an instance/object of Animal Class.
            Animal animal = new Animal("Tom", 3, 15, "meat", 8);

            animal.eat();
            animal.sleep();
            animal.say();


            // Create an instance/object of Fox Class.
            Fox fox = new Fox("Edward", 24, 130, "rabbits", 10);

            fox.eat();
            fox.sleep();
            fox.say();

            // Create an instance/object of Dog Class.




            // Create an instance/object of Cat Class.
        }
    }
}
