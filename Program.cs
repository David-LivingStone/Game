using System;
using System.Linq;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {

            //Work dec = new Work();
            //dec.GiveAway();



            //for loop
            //Work x = new Work();
            //x.dav();
            //Console.ReadLine();



            //Work rev = new Work();
            //int x= rev.factorial();
            //Console.WriteLine(x);

            string[] options = new[] { "P", "S", "R" };

            Console.WriteLine("PRESS 'P' KEY: TO SELECT A PAPER");
            Console.WriteLine("PRESS 'S' KEY: TO SELECT A SCISSORS");
            Console.WriteLine("PRESS 'R' KEY: TO SELECT A ROCK");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("ENTER AN OPTION FOR THE GAME:");
            string res = Console.ReadLine().ToUpper();
            string opt = "";
            
            foreach (var item in options)
            {
                if (res == item)
                {
                    
                    opt = item;
                }
                //Console.WriteLine("Unknown entry");


            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            if (!string.IsNullOrEmpty(opt))
            {

                Random rnd = new Random();
                int index = rnd.Next(options.Length);
                var X = (options[index]);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("PLAYER ONE: " + res);
                Console.WriteLine($"PLAYER TWO: {options[index]}");
                Console.WriteLine("");

                if (res == "R" && X == "S")
                {
                    Console.WriteLine("YOU WON!");
                }
                else if (res == "S" && X == "P")
                {
                    Console.WriteLine("YOU WON!");
                }

                else if (res == "P" && X == "R")
                {
                    Console.WriteLine("YOU WON!");
                }
                else if (res == X)
                {
                    Console.WriteLine("IT IS A TIE, PLAY AGAIN!");
                }
                else
                {
                    Console.WriteLine("YOU LOSE!");
                }

            }

            else
            {
                Console.WriteLine("Unknown entry, try again");


                Console.ReadLine();
            }




        }
    }
}
