using System;

namespace MultiThreadedPrinting.App;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n***** Synchronizing Threads *****\n");

        Printer p = new Printer();

        Thread[] threads = new Thread[10];
        for(int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
            {
                Name = $"Worker thread #{i}" 
            };
        } 

        foreach (Thread t in threads)
        {
            t.Start();
        }
        Console.ReadLine();
    }
}