using System;

namespace ColorSpheres
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create some color objects
            Color red = new Color(255, 0, 0);
            Color green = new Color(0, 255, 0);
            Color blue = new Color(0, 0, 255);

            // Create some sphere objects with colors
            Sphere redSphere = new Sphere(red, 5.0f);
            Sphere greenSphere = new Sphere(green, 10.0f);
            Sphere blueSphere = new Sphere(blue, 15.0f);

            // Throw the spheres
            redSphere.Throw();
            greenSphere.Throw();
            blueSphere.Throw();

            // Print the status of each sphere before popping any
            PrintSphereStatus(redSphere);
            PrintSphereStatus(greenSphere);
            PrintSphereStatus(blueSphere);

            // Pop the red sphere
            redSphere.Pop();

            // Print status again after popping the red sphere
            Console.WriteLine("\nAfter popping the red sphere:");
            PrintSphereStatus(redSphere);
            PrintSphereStatus(greenSphere);
            PrintSphereStatus(blueSphere);
        }
    
        static void PrintSphereStatus(Sphere sphere)
        {
            // Get color components
            Color color = sphere.GetColor();
            Console.WriteLine($"Sphere Color: R={color.GetRed()}, G={color.GetGreen()}, B={color.GetBlue()}, A={color.GetAlpha()}");

            // Get and print sphere radius and number of throws
            Console.WriteLine($"Sphere Radius: {sphere.GetRadius()}");
            Console.WriteLine($"Sphere Times Thrown: {sphere.GetTimesThrown()}");
        }
    }
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
    
    public class Sphere
    {
        private readonly Color Color; // readonly because once a sphere is created, its color should not change
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
