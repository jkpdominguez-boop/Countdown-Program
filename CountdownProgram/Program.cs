using System;

 namespace CountdownProgram
  {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of seconds for the countdown:");
                int seconds;
                if (int.TryParse(Console.ReadLine(), out seconds) && seconds > 0)
                {
                    Countdown(seconds);
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive integer.");
                }
            }
    
            static void Countdown(int seconds)
            {
                for (int i = seconds; i > 0; i--)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(1000); // Wait for 1 second
                }
                Console.WriteLine("Countdown complete!");
            }
        }
    }