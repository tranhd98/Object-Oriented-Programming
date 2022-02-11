using System;
namespace Exercise7
{
    public class Color
    {
        private int red;
        public int Red { get => red; set { value = red; } }
        private int green;
        public int Green { get => green; set { value = green; } }
        private int blue;
        public int Blue { get => blue; set { value = blue; } }
        private int alpha;
        public int Alpha { get => alpha; set { if (value >= 0 && value <= 255) { value = alpha; } } }
        public Color(int red, int green, int blue, int alpha=255)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        public double getGrayScale()
        {
            return (red + green + blue) / 3;
        }


    }
}
