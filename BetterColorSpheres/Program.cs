using System;

namespace BetterColorSpheres
{
    public class Color
    {
        // No need for backing variable because the properties are initialized in the constructor and never changed
        // Properties for color components
        private byte Red {get;}
        private byte Green {get;}
        private byte Blue {get;}
        private byte Alpha {get;}

        // Constructor to initialize the color components
        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        // GetGrey method = average of green, red and blue components
        // Value is between 0 and 255
        public byte GetGrey()
        {
            return (byte)((Red + Green + Blue) / 3);
        }
    }
    
    public class Sphere
    {
        public Color Color {get;} // readonly because once a sphere is created, its color should not change
        private float Radius {get; set;} // Radius is auto implemented but uses private set so only the class can change it
        private int _timesThrown; // Backing field for TimesThrown property
        public int TimesTrown => _timesThrown; // Read-only property with backing variable because it changes over time but is is readonly form outside the class

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            _timesThrown = 0; // Sphere starts unused
        }

        public void Throw()
        {
            if (Radius > 0)  // Can only throw if not popped
            {
                _timesThrown++; // Increment the number of times thrown
            }
        }

        public void Pop()
        {
            Radius = 0;  // Sphere is now "popped"
        }
    }
}
