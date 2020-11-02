using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            DateModifier mod = new DateModifier(first, second);

            var res = mod.CalcDifference(mod.One,mod.Two);
            Console.WriteLine(res);




            //var inputOne = Console.ReadLine().Split();
            //string dayOne = inputOne[2];
            //string monthOne = inputOne[1];
            //string yearOne = inputOne[0];
            //string firstDate = $"{dayOne}/{monthOne}/{yearOne}";

            //var inputTwo = Console.ReadLine().Split();
            //string dayTwo = inputTwo[2];
            //string monthTwo = inputTwo[1];
            //string yearTwo = inputTwo[0];
            //string secondDate = $"{dayTwo}/{monthTwo}/{yearTwo}";

            //DateModifier dates = new DateModifier(firstDate,secondDate);

            //double res =dates.CalcDifference(dates.One, dates.Two);
            //Console.WriteLine(res) ;
        }
    }
}
