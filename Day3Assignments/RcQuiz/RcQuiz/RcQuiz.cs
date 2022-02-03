using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcQuiz
{
    /*************
     * Quiz program
     * *********/
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int score = 0, ans;
            string name;
            //user input
            Console.WriteLine("Enter your name");
            name=Console.ReadLine();
            Console.WriteLine("Hi {0},Welcome to Rc Quiz", name);
            Console.WriteLine("Q1.Who is Indian Batsman in the given options?");
            Console.WriteLine("1.Chris Gayle 2.AB DeVilliers 3.Virat Kohli 4.Moeen Ali");
            Console.WriteLine("Enter your choice:");
            ans=Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            Console.WriteLine("Q2.Who is known as Master Blaster in Cricket?");
            Console.WriteLine("1.Sachin Tendulkar 2.M S Dhoni 3.Virat Kohli 4.Moeen Ali");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            Console.WriteLine("Q3.Who is WicketkeeperBatsman in the given options?");
            Console.WriteLine("1.Chris Gayle 2.MS Dhoni 3.Virat Kohli 4.Moeen Ali");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("Q4.When did India win the first T20 Worldcup?");
            Console.WriteLine("1.1983 2.2007 3.2004 4.2012");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("Q5.Which is the largest cricket stadium in the world?");
            Console.WriteLine("1.Eden Gardens 2.Lords 3.MCG 4.NarendraModi Stadium");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;
            if (score >= 60)
                Console.WriteLine("Congrats {0},You got {1}% in the quiz", name, score);
            else
                Console.WriteLine("Sorry {0},You got {1}%,TRY AGAIN", name, score);
            Console.ReadLine();
        }
    }
}
