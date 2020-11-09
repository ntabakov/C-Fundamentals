using System;

namespace ClassBoxData
{
    public class StartUp

    {
        public static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            

            try
            {
                Box box = new Box(l, w, h);
                box.SurfaceArea();
                box.LateralSurfaceArea();
                box.Volume();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                
            }
        }
    }
}
