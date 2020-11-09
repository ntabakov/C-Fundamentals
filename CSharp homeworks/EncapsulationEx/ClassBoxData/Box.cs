using System;
namespace ClassBoxData
{
    public class Box
    {
        private const string ARG_EXC_MSG = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");

                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");

                }
                this.height = value;
            }
        }

        public void SurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            double sa = (2 * this.Length * this.Width) +
                (2 * this.Length * this.Height) +
                (2 * this.width * this.Height);
            Console.WriteLine($"Surface Area - {sa:f2}");
        }

        public void LateralSurfaceArea()
        {
            // Lateral Surface Area = 2lh + 2wh
            double lsa = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            Console.WriteLine($"Lateral Surface Area - {lsa:f2}");
        }

        public void Volume()
        {
            double volume = this.Length * this.Height * this.Width;
            Console.WriteLine($"Volume - {volume:f2}");
        }



    }
}
