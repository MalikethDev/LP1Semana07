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
    
    public class Sphere
    {
        private Color Color;
        private float Radius;
        private int TimesThrown;

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0; // Sphere starts unused
        }

        public void Throw()
        {
            if (Radius > 0)  // Can only throw if not popped
            {
                TimesThrown++;
            }
        }

        public void Pop()
        {
            Radius = 0;  // Sphere is now "popped"
        }

        public Color GetColor() => Color;
        public float GetRadius() => Radius;
        public int GetTimesThrown() => TimesThrown;
        }
    }
}