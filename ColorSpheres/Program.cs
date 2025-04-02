using System;

namespace ColorSpheres
{
    public class Color
    {
        private byte Red, Green, Blue, Alpha;

        // Constructor to initialize the color components
        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        
        // Getters for the color components
        public byte GetRed() => Red;
        public byte GetGreen() => Green;
        public byte GetBlue() => Blue;
        public byte GetAlpha() => Alpha;

        // GetGrey method = average of green, red and blue components
        // Value is between 0 and 255
        public byte GetGrey()
        {
            return (byte)((Red + Green + Blue) / 3);
        }
    }
}
