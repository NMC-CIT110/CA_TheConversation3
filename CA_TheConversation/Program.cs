using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConversation
{

    // *************************************************************
    // Application:     The Conversation Starter Solution
    // Author:          Velis, John E
    // Description:     Start solution for the project.
    // Date Created:    5/20/2016
    // Date Revised:    7/7/2016
    // *************************************************************

    class Program
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            string userName;
            string favoriteSki;
            string typeOfSkiing;
            string favoriteArea;
            string userResponse;

            //
            // enter conversation with user
            //
            Console.WriteLine("Hello!");
            Console.WriteLine("My name is John.");

            //
            // get their name and echo it back
            //
            Console.WriteLine();
            Console.Write("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("It is nice to meet you " + userName + ".");
            //Console.WriteLine("It is nice to meet you {0}.", userName);
            //Console.WriteLine($"It is nice to meet you {userName}.");

            //
            // determine if the user skis
            //
            Console.WriteLine();
            Console.Write($"Do you like to ski {userName}?");
            userResponse = Console.ReadLine();

            //
            // get more information if the user is a skier
            //
            if (userResponse == "yes")
            {
                //
                // get user's favorite ski
                //
                Console.WriteLine();
                Console.WriteLine("Glad to hear you like skiing. It is one of my favorite sports!");
                Console.Write("What is your favorite ski?");
                favoriteSki = Console.ReadLine();
                Console.WriteLine("So, {0}, you like {1} skis.", userName, favoriteSki);

                //
                // get the user's type of skiing
                //
            }
            else // user does not like to ski
            {
                Console.WriteLine();
                Console.WriteLine($"I am sorry you don't like skiing {userName}. It has been nice meeting you.");
            }

            //
            // display a prompt to exit the application
            //
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
