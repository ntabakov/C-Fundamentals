using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@#+[A-Z][A-Za-z0-9]{4,}[A-Z]\@#+";

            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                if (regex.Match(barcode).Success)
                {
                    string productGrop = "";
                    for (int j = 2; j < barcode.Length-2; j++)
                    {
                        if (char.IsDigit(barcode[j]))
                        {
                            productGrop += barcode[j];
                        }
                    }
                    if (productGrop == "")
                    {
                        productGrop = "00";
                    }

                    Console.WriteLine($"Product group: {productGrop}");



                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
