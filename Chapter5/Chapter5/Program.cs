// Mike Hudekoff C# intro | Roger Long  | Thur Spring 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 10;
            Random ranNumberGenerator = new Random();
            int randomNumber = 0;
            int guessCounter = 0;
            int lastHighNumber = 10;
            int lastLowNumber = 0;
            randomNumber = ranNumberGenerator.Next(MIN, MAX);
            int guessNumber = 0;

            while (guessNumber != randomNumber) 
            {
                
                if (guessCounter == 0)
                {
                    Write("Guess a number between 1 and 10 >> ");
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    Write("Another guess between 1 and 10 >>  ");
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                }

                if (guessNumber < 1 || guessNumber > 10)
                {
                    WriteLine("Your guess is out of range --pick a number between 1-10");
                    ++guessCounter;
                }
                else
                {
                }

                if (guessNumber == randomNumber)
                {
                    Write("The secret number was {0} ", randomNumber);
                    ++guessCounter;
                    WriteLine("and you guessed correctly after {0} guesses", guessCounter);
                }
                
                else if (guessNumber > randomNumber && guessNumber <= MAX) 
                {
                    if (guessNumber >= lastHighNumber)
                    {
                        WriteLine("You already knew that {0} was too high", lastHighNumber);
                    }
                    else
                    {
                        WriteLine(" Your number is too high");
                    }
                    ++guessCounter;
                    lastHighNumber = guessNumber;
                }

                else if (guessNumber < randomNumber && guessNumber >= MIN)
                {
                    if (guessNumber <= lastLowNumber)
                    {
                        WriteLine("You already knew that {0} was too low", lastLowNumber);
                    }
                    else
                    {
                        WriteLine("Your guess was too low"); 
                    }
                    ++guessCounter;
                    lastLowNumber = guessNumber;
                }

            }
        }
    }
}

