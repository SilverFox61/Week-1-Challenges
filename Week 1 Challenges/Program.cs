using System;
using System.Collections.Generic;

namespace Week_1_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st Challenge//
            string firstname = "Dan";

            string lastname = "Payne";

            string age = "59";

            string name = firstname + " " + lastname;

            Console.WriteLine(name);

            string userInfo = string.Format("Name: {0}, age: {1}", name, age);

            Console.WriteLine(userInfo);

            string nameage = "Dan\nPayne\n59";

            Console.WriteLine(nameage);

            //2nd Challenge
            string[] movies = new string[4];
            movies[0] = "Argo";
            movies[1] = "A Few Good Men";
            movies[2] = "The Firm";
            movies[3] = "Vacation";
            Console.WriteLine(movies[0]);
            Console.WriteLine(movies[1]);
            Console.WriteLine(movies[2]);
            Console.WriteLine(movies[3]);
            Console.ReadKey();

            //3rd Challenge//
            Console.WriteLine(DateTime.Now);
            DateTime date2 = new DateTime(2020, 12, 25);
            Console.WriteLine(date2);
            DateTime date3 = new DateTime(2020, 12, 31);
            Console.WriteLine(date3);
            Console.ReadLine();

            //4th Challenge//
            int numOne = 59;
            int numTwo = 7;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //5th Challenge//

            int hours = 24;
            if (hours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hours > 8 && hours < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }


            //6th Challenge//
            Console.WriteLine("How are You?");
            string response = "Great";
            switch (response)
            {
                case "Great":
                    Console.WriteLine("Awesome!");
                    break;
                case "Good":
                    Console.WriteLine("That is nice");
                    break;
                case "Okay":
                    Console.WriteLine("Alright");
                    break;
                case "Bad":
                    Console.WriteLine("I am sorry");
                    break;
                default:
                    Console.WriteLine("Hope your day goes well");
                    break;
            }
            Console.ReadKey();
        }
    }
}
