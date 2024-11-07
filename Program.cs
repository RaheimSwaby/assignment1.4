using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace assignment1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(3,7);
            point p2 = new point(2,7);

            if (p1.x > p2.x)
            {
                Console.WriteLine("p2 is to the right of p1");
            }
            else if (p1.x < p2.x)
            {
                Console.WriteLine("p2 is to the left of p1");
            }
            else
            {
                Console.WriteLine("p2 is on the same vertical axis as p1");
            }
            
                  
        }
    }

    public class point 
    {
        public point( double xCoord, double yCoord) 
        {
            x = xCoord;
            y = yCoord;
        }
        public point() 
        {
            x = 0;
            y = 0;
        }
        public double x;
        public double y;

        
    }
      
    
}
