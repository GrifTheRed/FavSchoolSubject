using System;

namespace FavSchoolSubject
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch(subject)
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;

                case "science":
                    Console.WriteLine("Science was my favorite subject");
                    break;

                case "english":
                    Console.WriteLine("english was close to being my favorite along with science");
                    break;

                case "art":
                    Console.WriteLine("I did not care for art although I really enjoyed pottery");
                    break;

                case "gym":
                    Console.WriteLine("everyone liked gym class, come on");
                    break;

                    default:
                    Console.WriteLine("didn't have that at my school");
                    break;
            }

        }
    }
}

