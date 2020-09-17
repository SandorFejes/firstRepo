using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Hello Batman";
            //string mickey = "Hello Mickey mouse";
            //string result = myString + mickey;

            //Stopwatch stopwatch3 = new Stopwatch();
            //stopwatch3.Start();
            //for (int i = 0; i > 100000; i++)
            //{
            //    Console.WriteLine(result);
            //    result += i;
            //}
            //stopwatch3.Stop();
            //Console.WriteLine(stopwatch3.Elapsed);

            //Stopwatch stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //StringBuilder builder = new StringBuilder();
            //builder.Append(result);

            //for (int i = 0; i < 1000; i++)
            //{

            //    builder.Append(i);
            //    Console.WriteLine(builder);

            //}
            //stopwatch2.Stop();
            //Console.WriteLine(stopwatch2.Elapsed);


            //if (myString==mickey)
            //{
            //    Console.WriteLine("mystring=mickey");
            //}
            //string longString = "a, b, c, ddd, s, s";
            //Console.WriteLine(longString);
            //string replacedString= longString.Replace(",", ";");
            //Console.WriteLine(longString);

            //Console.WriteLine(mickey.Remove(6, 6));
      
            //Console.WriteLine(myString.Contains("m"));
          
            //Console.WriteLine(myString[0]);
            //Console.WriteLine(myString.Length);
           

            Console.WriteLine("Hello World!");

            decimal number = 1234566666123;
            CultureInfo culture = new CultureInfo("ro-RO");
            Console.WriteLine(number.ToString("c", culture ));

        }
    }
}
