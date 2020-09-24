using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int total = width * length;
            int totalPieces = 0;
            while (total >= totalPieces)
            {
                string pieces = Console.ReadLine();
                //
                if (pieces == "STOP")
                {
                    int leftPieces = total - totalPieces;
                    Console.WriteLine($"{leftPieces} pieces are left.");
                    break;
                }
                totalPieces += int.Parse(pieces);
                if(totalPieces > total)
                {
                    int needPieces = totalPieces - total;
                    Console.WriteLine($"No more cake left! You need {needPieces} pieces more.");
                    break;
                }
            }


        }
    }
}
