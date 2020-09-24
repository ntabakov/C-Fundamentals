using System;
using System.Linq;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] da = new int[] { 5,6 };
            int[] ne = new int[] { da[0],da[1] };
            
            Console.WriteLine(String.Join(",,",ne));
            da = new int[] { 66, 77 };

            Console.WriteLine(String.Join(",,", ne));


        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
