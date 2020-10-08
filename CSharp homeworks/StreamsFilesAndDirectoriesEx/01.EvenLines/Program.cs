using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int count = 0;
                    string pattern = @"[-,.!?]";
                    Regex regex = new Regex(pattern);
                    while (line != null)
                    {
                        line = regex.Replace(line, "@");
                        var array = line.Split().Reverse().ToArray();
                        if (count % 2 == 0)
                        {
                            writer.WriteLine(String.Join(" ", array));
                        }

                        count++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
