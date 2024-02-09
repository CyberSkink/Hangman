using System;



class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("LOADING SUMULATION...");
        Console.WriteLine("PROJECT: HANGMAN...");
        Console.WriteLine("ENTER THE PASSCODE IN ORDER TO SPARE HUMANITY...");
        // create an array of words for the player to guess...
        string[] words = new string[] { "console", "program", "algorithm", "circut", "one", "zero", "variable" };
        Random generated = new Random();
        int rword = generated.Next(words.Length);
        int guessedletter = 0;
        bool end = false;
        int letter = 0;
        int guessesmax = 10;
        int guesses = 0;

        while (!end)
        {
                string input = Console.ReadLine();
                //tinput means "Translated Input"
                string tinput = input.ToLower();
            guesses++;
            if (guessesmax >= guesses)
            {
                Console.WriteLine(guessesmax - guesses);
            }
            if (guesses <= guessesmax)
            {

                foreach (char ch in words[rword])
                {
                    letter++;
                    if (tinput.Contains(ch))
                    {
                        guessedletter++;
                        Console.WriteLine("TRUE");
                    }
                    else
                    {
                        Console.WriteLine("FALSE");
                    }
                    if (letter == words[rword].Length)
                    {
                        if (guessedletter != letter)
                        {
                            Console.WriteLine("INVALID PASSCODE...");
                            guessedletter = 0;
                        }
                        else
                        {
                            Console.WriteLine("NUCLEAR WEAPONS DISARMED... HAVE A NICE DAY! :)");
                            Console.WriteLine("PRESS ANY KEY TO EXIT THE TERMINAL...");
                            end = true;
                            
                            Console.ReadKey();
                        }
                        letter = 0;
                    }
                }

            }

            else
            {
                Console.WriteLine("HUMANITY HAS BEEN ERRADICATED...");
                Console.WriteLine("PRESS ANY KEY TO EXIT THE TERMINAL...");
                end = true;
                Console.ReadKey();
            }
        }
        }
    }