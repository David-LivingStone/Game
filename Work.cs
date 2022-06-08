using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decision
{
    public class Work
    {
        public void Month()
        {
            string message = "";
        Console.WriteLine("ENTER NUMBER FROM 1- 5");
         var month = int.Parse(Console.ReadLine());
         switch (month)
         {
             case 1:
                 message = "JANUARY";
                 break;
             case 2:
                 message = "FEBRUARY";
                 break;
             default:
                 message = "INVALID ENTRY";
                 break;

         }
            Console.WriteLine(message);
         }
        public void GiveAway()
        {
            string message = "";
            Console.WriteLine("LIVINGSTONE GIVEAWAY");
            Console.WriteLine("Choose a Raffle between 1 - 5:");
            string res = Console.ReadLine();
            message = (res == "1") ? "CAR" : "STRAND OF LINT ";

            //Console.Write("YOU WON A {0}.", message);
            Console.WriteLine("You Entered: {0}, therefore you won a {1}.", res, message);
        }

        public int HammingDistance(string str1, string str2)
        {
            return str1.Where((t, x) => t != str2[x]).Count();
        }
        public int factorial()
        {
            Console.WriteLine("ENTER A NUMBER");
            var x = int.Parse(Console.ReadLine());

            int a = 1;
            int tot = 0;
            for (int i = 1; i <= x; i++)
            {

                tot = a *= i;

            }
            return tot;
        }
        public void dav()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("FOUND SEVEN");
                    break;
                }
                
            }
        }
    }
}
