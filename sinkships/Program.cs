using System;

namespace sinkships
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till sänka skepp!\nSkriv en koordinat [1-10]:");


            string l = Console.ReadLine();

            int x = 0;
            while (x == 0)
            {

                try
                {
                    x = int.Parse(l);
                }
                catch
                {
                    Console.WriteLine("Not a number, Try again!\nSkriv en koordinat [1-10]:");
                }

                //   while (x == 0)
                //   {
                l = Console.ReadLine();
                if (x == 7)
                {
                    Console.WriteLine("Hit!\nPress ENTER to exit");
                    Console.ReadLine();
                }
                else if (x > 10)
                {
                    Console.WriteLine("Only a number between 1-10");
                    Console.ReadLine();
                }
                else if (x < 7 || x > 7)
                {
                    Console.WriteLine("Miss!\nSkriv en koordinat [1-10]:");
                    Console.ReadLine();
                }

            }

            //   }



            Console.ReadLine();
        }
    }
}
