using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string Graph;
            Graph = Console.ReadLine();
            if (Graph == "time")
            {
                double t = double.Parse(Console.ReadLine());
                double p = double.Parse(Console.ReadLine());
                {
                    if (t < 0)
                    {
                        Console.WriteLine("Invalid mode");
                    }else if (t >= 0)
                    {
                        p = Math.Pow((t - 1), 2);
                        Console.Write("{0} , ", t);
                        Console.Write("{0}", p);
                    }
                }
            }
            else if (Graph == "price")
            {
                double t2 = double.Parse(Console.ReadLine());
                double p2 = double.Parse(Console.ReadLine());
                {
                    if (t2 < 0)
                    {
                        Console.WriteLine("Invalid mode");
                    }
                    else if (t2 >= 0)
                    {
                        t2 = Math.Sqrt(p2) + 1;
                        Console.Write("{0} , ", t2);
                        Console.Write("{0}", p2);
                    }
                }
            }
            else
            {
                double t3 = double.Parse(Console.ReadLine());
                double p3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Invalid mouse position");
            }
        }
    }
}