namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            
            

            int sum = a + b;
            Console.WriteLine($"{a}+{b} is {sum}");
            Console.WriteLine();

            int product = a * b;
            Console.WriteLine($"{a}*{b} is {product}");
            Console.WriteLine();

            int difference = a - b;
            Console.WriteLine($"{a}-{b} is {difference}");
            Console.WriteLine();

            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            Console.WriteLine();

            
            Console.WriteLine("what is the radius of your circle");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"Area of the circle with a radius of {radius} is {area}");
            //this still reads .. not sure now to make it not..
        }
        static double AreaOfCircle(double radius)
        {
            if (radius >= 0)
            {
                double area = Math.PI * Math.Pow(radius, 2);
                return area;
            }
            else
             {
                Console.WriteLine("invalid input");
                return 0;

             }

        }
    }
}

// and thought exercise = 16
