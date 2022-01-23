using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCandles_Original
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] birthdayCandles = new int[] { 4, 7, 3, 7, 7, 2, 1, 3 };
            int tallestCandle = birthdayCandles.Max();
            List<int> tallestCandles = new List<int>();

            for(int i = 0; i < birthdayCandles.Length; i++)
            {
                if(birthdayCandles[i] == tallestCandle)
                {
                    tallestCandles.Add(birthdayCandles[i]);
                }
            }
            ;


            Console.WriteLine("the tallest candles are " + tallestCandle + " unit high");
            Console.WriteLine("there are " + tallestCandles.Count + " candles with this height");
            Console.WriteLine("the total  units of measurement for tallest candles is " + tallestCandles.Sum()) ;
        }
    }
}
