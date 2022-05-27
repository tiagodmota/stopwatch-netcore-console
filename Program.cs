using System;
using System.Threading;
using CultureSettings;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultCultureInfo.SetCulture("en-US");
            Console.Write("Press Enter to start...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Press CTRL + C to stop...");
            Stopwatch(); 
        }

        public static void Stopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            const uint limiteDeHoras = 100;
            const decimal oneMilissecond = 0.017M;
            const decimal secondsAndMillissecondsPack = 60M;
            const uint minutesPack = 60;
            while (stopwatch.Hours < limiteDeHoras)
            {
                stopwatch.SecondsAndMillisseconds += oneMilissecond;
                if (stopwatch.SecondsAndMillisseconds >= secondsAndMillissecondsPack)
                {
                    ++stopwatch.Minutes;
                    stopwatch.SecondsAndMillisseconds = 0M;
                }
                if (stopwatch.Minutes >= minutesPack)
                {
                    ++stopwatch.Hours;
                    stopwatch.Minutes = 0;
                    stopwatch.SecondsAndMillisseconds = 0M;
                }
                Console.Write($"\r{stopwatch.Hours.ToString("00")}:{stopwatch.Minutes.ToString("00")}:{stopwatch.SecondsAndMillisseconds.ToString("00.00")} ");
                Thread.Sleep(1);
            }
        }
    }

    struct Stopwatch
    {
        public uint Hours;
        public uint Minutes;
        public decimal SecondsAndMillisseconds;

        public Stopwatch(
            uint hours = 0,
            uint minutes = 0,
            decimal secondsAndMillisseconds = 0
        )
        {
            Hours = hours;
            Minutes = minutes;
            SecondsAndMillisseconds = secondsAndMillisseconds;
        }

    }

}