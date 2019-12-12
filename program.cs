using System;
using System.Collections.Generic;
using System.Threading;
using Fertilize;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to GROW YOUR OWN PLANT!");
        Thread.Sleep(1500);
        Console.WriteLine("Fight against the random forces of nature to grow your plant into a healthy adult, or at least keep it alive. . .");

        Console.WriteLine("First of all, let's make a plant! What kind of plant would you like to care for?");
        string plantType = Console.ReadLine();
        Console.WriteLine("An excellent choice...");
        Thread.Sleep(1500);
        Console.WriteLine("Let's see how big your baby plant is. . .");
        Thread.Sleep(1500);

        int beginHeight = MakeRandom();
        int beginHealth = MakeHealth();


        Plant thePlant = new Plant(beginHeight, beginHealth, plantType);

        ReturnSpecs();
        Thread.Sleep(1000);
        Console.WriteLine("Okay, let's play a turn!");
        Turn();
        


        void Turn()
        {
            if (thePlant.GetHealth() <= -2)
            {
                Console.WriteLine("Sorry, your plant is dead. You've failed as a parent.");
                return;
            }
            if (thePlant.GetHealth() >= 7)
            {
                 Console.WriteLine("Congratulations! Your plant has become an adult, and to love something, is to be able to leave something. I'll give you a moment to say your goodbyes.");
                 return;
            }
            Console.WriteLine("What would you like to give your plant? Type: 'water', 'feed', or 'sunshine'");
            string answer = Console.ReadLine();
            if (answer == "water")
            {
                thePlant.Water();
            }
            else if (answer == "feed")
            {
                thePlant.Feed();
            }
            else{
                thePlant.GiveSunshine();
            }
            ReturnSpecs();

            Console.WriteLine("But wait... let's see what mother nature had in store for the day...");
            Thread.Sleep(1000);
            MakeWeather();
            Console.WriteLine("Now your plant is as follows. . .");
            Thread.Sleep(1000);
            ReturnSpecs();
            Console.WriteLine("Eventually, today becomes tomorrow. . .");
            Thread.Sleep(1000);
            Turn();
        }
        int MakeRandom()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }

        int MakeHealth()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 2);
            return num;
        }

        void ReturnSpecs()
        {
            Console.WriteLine("Your " + thePlant.GetSpecies() + " plant is " + thePlant.GetHeight() + " imches and is of  " + thePlant.GetHealth() + " health.");
        }
       
       void MakeWeather()
       {
           Random rnd = new Random();
           int weather = rnd.Next(1, 10);

           if (weather > 8)
           {
               thePlant.NiceDay();
               Console.WriteLine("It was a beautiful day today!");
           }
           else if (weather > 4)
           {
               Console.WriteLine("It was an average day today.");
           }
           else if (weather < 2)
           {
               thePlant.Windstorm();
               Console.WriteLine("There was a windstorm!");
           }
           else if (weather < 3)
           {
               thePlant.AphidAttack();
               Console.WriteLine("There was an aphid attack!");
           }
           else if (weather < 4)
           {
               thePlant.SlugBite();
               Console.WriteLine("The slugs have attacked!");
           }
       }
    }
}
