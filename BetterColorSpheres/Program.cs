using System;

namespace BetterColorSpheres
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
            Sphere redSphere = new Sphere(red, 5.0f); // Sphere with radius 5.0f
            Sphere greenSphere = new Sphere(green, 10.0f); // Sphere with radius 10.0f
            Sphere blueSphere = new Sphere(blue, 15.0f); // Sphere with radius 15.0f

            // Throw the spheres
            redSphere.Throw();
            redSphere.Throw(); // Throwing again to test the increment
            greenSphere.Throw();
            blueSphere.Throw();
            blueSphere.Throw();
            blueSphere.Throw(); // Throwing three times

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
            Console.WriteLine($"Sphere Color: R={sphere.Color.Red}, G={sphere.Color.Green}, B={sphere.Color.Blue}, A={sphere.Color.Alpha}");

            // Get and print sphere radius and number of throws
            Console.WriteLine($"Sphere Radius: {sphere.Radius}");
            Console.WriteLine($"Sphere Times Thrown: {sphere.TimesTrown}");
        }
    }

    public class Color
    {
        // No need for backing variable because the properties are initialized in the constructor and never changed
        // Properties for color components
        public byte Red {get;} // Make sure they are public so they can be accessed outside the class
        public byte Green {get;}
        public byte Blue {get;}
        public byte Alpha {get;}

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
        public float Radius {get; private set;} // Allow read access, modify only within the class
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
