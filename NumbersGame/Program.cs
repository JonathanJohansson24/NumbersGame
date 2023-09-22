using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;
using System;
using System.Net.NetworkInformation;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till nummerspelet!\nFör att börja spelet tryck på valfri tagent!");
            Console.ReadKey();
            Console.Clear();


            NumbersGame();


        }
        public static void NumbersGame()
        {
            Console.WriteLine("Välkommen! jag tänker på ett nummer mellan 1-20! \n Kan du gissa vilket? du får fem försök på dig:");

            Random random = new Random();
            int number = random.Next(1, 21);
            int numberOfGuesses = 0;
            while (numberOfGuesses < 5)
            {
                Console.Write("Gissa ett tal: ");
                int usersGuess;

                if (int.TryParse(Console.ReadLine(), out usersGuess))
                {

                    if (usersGuess < number)
                    {
                        Console.WriteLine("Det riktiga talet är större än ditt tal");            // if the user guesses a number thats lower than the actual number 
                        numberOfGuesses++;                                                      //this will print out, and also add to the count     
                        
                    }
                    else if (usersGuess > number)
                    {
                        Console.WriteLine("Det riktiga talet är mindre än ditt tal");           // if the user guesses a number thats higher than the actual number 
                        numberOfGuesses++;                                                      //this will print out, and also add to the count
                    }
                    else if (usersGuess == number)                                              // if the user guesses the correct number this will print out
                    {
                        Console.WriteLine("Grattis du valde rätt nummer");
                        break;
                    }
                }
                else
                {                                                                               //just to add a safety measure to see if the doesnt user insert a number
                    Console.WriteLine("Var vänlig skriv in ett heltal.");
                }
            }
            if (numberOfGuesses == 5)                                                           // if the user has used 5 tries and still hasnt figured it out
            {                                                                                   // this will print out, with the correct number in mind
                Console.WriteLine($"Du har använt dig av dina 5 chanser, det rätta svaret var {number}.");

            }
            Console.WriteLine("Tack för att du spelade");
        }
    }
}

