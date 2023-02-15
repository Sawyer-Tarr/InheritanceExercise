using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird mallardDuck= new Bird();

            mallardDuck.Auqatic = true;
            mallardDuck.Diet = "Omnivore";
            mallardDuck.LivingSituation = "Migratory";
            mallardDuck.Size = "Medium";
            mallardDuck.Backbone = "Vertebrate";
            mallardDuck.Color = "Green and Gray";
            mallardDuck.Biome = "Temperament Grasslands";
            mallardDuck.Movement = "Flight";

            Console.WriteLine($"Mallard Ducks aren't normally known for being brave knights. But that never held back Sir Quacks. Given that he hailed from the lands of {mallardDuck.Biome}," +
                $" where his {mallardDuck.Diet} diet and ability of {mallardDuck.Movement} allowed him to move throughout the land and adapt in a moments notice. He wasn't a large fellow either, being of " +
                $"{mallardDuck.Size} size meant he was hard to spot from the distance, which was just adding to his {mallardDuck.Color} natural camouflage. He was nomadic of sorts. Never really calling" +
                $" one place home with his {mallardDuck.LivingSituation} life style. A style that forced him to learn the different terrains throughout the {mallardDuck.Biome}. He had gain the ability to " +
                $"survive on water as well this was {mallardDuck.Auqatic}. But Sir Quacks finally met his end of adventuring on one fateful night when he forgot one simple fact. He was a {mallardDuck.Backbone}. " +
                $"Sir Quacks when to sleep on the cold hard qround at the age of 27, and woke up with back problems. He was never the same again.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
           Console.WriteLine();
           Console.WriteLine();
            Console.WriteLine();
            
            
            Reptile seaTurtle= new Reptile();

            seaTurtle.Backbone = "Vertebrate";
            seaTurtle.TurtLizSnakCroc = "Turtle";
            seaTurtle.LivingStituation = "Amphibious";
            seaTurtle.Biome = "Marine";
            seaTurtle.Legs = 4;
            seaTurtle.Defense = "Shell";
            seaTurtle.Movement = "Swimming";
            seaTurtle.Diet = "Omnivore";

            Console.WriteLine($"For centuries, sharks were considered the kings of the high seas. At the time, they were most feared members of the {seaTurtle.Biome} Kingdom, so when the idea" +
                $" of a Sea {seaTurtle.TurtLizSnakCroc} becoming king was floated to the High Council, it was thought that it would be turned down immediately. A {seaTurtle.Backbone} that could breath air with an " +
                $"{seaTurtle.LivingStituation} lifestyle, and {seaTurtle.Legs} flippers? Becoming the king of the underwater kingdom? Blasphemy was whispered throughout the seven seas. Plus with his {seaTurtle.Diet} diet, " +
                $"he ate jellyfish. The natural lanturns of the ocean. But Democracy won, and King Speedy, the green sea turtle, was placed into power. Unhappy with the change in leadership, " +
                $"the sharks devised a plan to remove King Speedy. Taking notes from a book that came from the human world when it was thrown away in the ocean, the sharks had learned about the " +
                $"assassination of Julius Ceasar, and how he was stabbed in the back. Given that this was the only book the sharks had ever read, they decided this was the perfect plan to get rid" +
                $" of King Speedy. The sharks waiting until the king was out {seaTurtle.Movement} in the reef to take action. The shark leader, Bruce, ambushed the king and with one quick motion, " +
                $"used a sharp piece of coral to take the stab at King Speedy's back. Alas, the stab was useless. King Speedy's {seaTurtle.Defense} had saved him and the sharks were banished to" +
                $" Mariana Trench Prison to live out there days."); 



        }
    }
}
