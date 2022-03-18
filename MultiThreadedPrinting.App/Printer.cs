namespace MultiThreadedPrinting.App;

public class Printer
{
    public void PrintNumbers()
    {
        Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
        Console.Write("Your numbers: ");
        for(int i = 0; i < 10; i++)
        {
            Random r = new Random();
            Thread.Sleep(1000 * r.Next(5));
            Console.Write("{0}, ", i);
        }
        Console.WriteLine();
    }
}
