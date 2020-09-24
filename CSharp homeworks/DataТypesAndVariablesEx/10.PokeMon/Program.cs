using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint pokePowerN = uint.Parse(Console.ReadLine());
            uint distanceM = uint.Parse(Console.ReadLine());
            byte exhaustionFactorY = byte.Parse(Console.ReadLine());

            uint defaultPower = pokePowerN;
            byte target = 0;

            while (distanceM <= pokePowerN)
            {

                if (pokePowerN == defaultPower / 2)
                {
                    pokePowerN /= exhaustionFactorY;
                }
                else
                {
                    pokePowerN -= distanceM;
                    target++;
                }

            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(target);
        }
    }
}
