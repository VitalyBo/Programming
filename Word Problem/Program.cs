

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Samantha runs a small bakery. In one day, she bakes 5 batches of cookies, 
 * with each batch containing 24 cookies. She sells each cookie for $2. 
 * At the end of the day, she gives away 10 cookies to her neighbors and 
 * had to throw away 8 cookies that were accidentally burnt. How much money 
 * did Samantha make from selling the cookies after giving away and 
 * throwing away some of them?

Above is a word problem that you can copy, paste, and comment in your code

Using Console.WriteLine(), ints, and math operators display 

The word problem
The cost of a single cookie
How many cookies in a batch
How much a batch of cookies cost
How many cookies in 5 batches.
How much 5 batches of cookies cost
How many cookies were given away
How much those cookies given away cost
How many cookies were thrown away
How much those cookies thrown away cost
How much money did Samantha make from selling the cookies after 
giving away and throwing away some of them?*/


namespace Сonsole
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.Unicode;

            int cookie=0, batch=24, cookie_price=2, money=0, burnt_cookies=8, giveaway=10;

            Console.WriteLine("Samantha runs a small bakery. \nIn one day, she bakes 5 batches of cookies, with each batch containing 24 cookies. \nShe sells each cookie for $2. \nAt the end of the day, she gives away 10 cookies to her neighbors \nand had to throw away 8 cookies that were accidentally burnt. \nHow much money did Samantha make from selling the \ncookies after giving away and throwing away some of them? ");

            Console.WriteLine($"\nThe word problem");
            Console.WriteLine($"\nCost of a single cookie: {cookie_price}");
            Console.WriteLine($"\nNumber of cookies in a batch: {batch}");
            Console.WriteLine($"\nCost for a batch of cookies: {batch * cookie_price}");
            Console.WriteLine($"\nTotal cookies in 5 batches: {batch *5}");
            Console.WriteLine($"\nNumber of cookies given away: {giveaway}");
            Console.WriteLine($"\nCost of cookies given away: {giveaway * cookie_price}");
            Console.WriteLine($"\nNumber of cookies thrown away: {burnt_cookies}");
            Console.WriteLine($"\nCost of cookies thrown away: {burnt_cookies * cookie_price}");
            Console.WriteLine($"\nTotal earnings after giving away and throwing away some cookies: {5*batch - giveaway - burnt_cookies * cookie_price} ");
            
        }
    }
}