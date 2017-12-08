using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace Exercise01_Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;

        public void Start()
        {
            _startTime = DateTime.Now;
        }

        public double Stop()
        {
            return (DateTime.Now - _startTime).TotalSeconds;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch _stopwatch = new Stopwatch();
            
            while (true)
            {
                Console.WriteLine("ENTER to start");
                Console.ReadLine();
                Console.ReadLine();

                _stopwatch.Start();
                
                Console.WriteLine("ENTER to stop");
                Console.ReadLine();
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Elapsed time is {0} seconds\n\n", _stopwatch.Stop());
            }
        }
    }
}