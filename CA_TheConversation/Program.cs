﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConversation
{

    // *************************************************************
    // Application:     The Conversation (Example Code)
    // Author:          Velis, John E
    // Description:     An application that has a conversation with the user
    //                  about skiing.
    // Date Created:    5/20/2019
    // Date Revised:    7/7/2019
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
                Console.WriteLine();
                Console.WriteLine("I am interested in what kind of skiing you do.");
                Console.Write("Do you prefer \"downhill\" or \"back country\"?");
                typeOfSkiing = Console.ReadLine();

                //
                // get the user's favorite area
                //
                Console.WriteLine();
                Console.Write("What is your favorite area to ski.");
                favoriteArea = Console.ReadLine();

                //
                // provide feedback on the type of skiing
                //
                Console.WriteLine();
                if (typeOfSkiing == "downhill")
                {
                    Console.WriteLine("I have downhill skied for most of my life, but gave it up last year.");
                    Console.WriteLine($"I hear the {favoriteArea} is a great place to ski {userName}.");
                }
                else if (typeOfSkiing == "back country")
                {
                    Console.WriteLine("I spend most of my time skiing now in back country.");
                    Console.WriteLine($"Well {userName}, I am not sure I have skied at {favoriteArea}. I will have to give it a try." );
                }
                else // user's response was not valid
                {
                    Console.WriteLine("I am afraid I don't recognize that type of skiing.");
                }

                //
                // thank the user and say good bye
                //
                Console.WriteLine();
                Console.WriteLine($"{userName}, it has been great getting learn more about your skiing interests.");
                Console.WriteLine("Have a nice day.");
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
