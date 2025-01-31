namespace IInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rhomb rhomb = new Rhomb();
            Square square = new Square();
            Parallelogram parallelogram = new Parallelogram();
            Rectengle rectangle = new Rectengle();
            Tetragon tetragon = new Tetragon();

            Console.WriteLine("Напишите длину стороны A");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите длину стороны B");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите длину стороны C");
            float c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите длину стороны D");
            float d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите градус угла между сторонами");
            float angle = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Rhomb Perimeter: " + rhomb.ConutPerimeter(a, b, c, d));
            Console.WriteLine("Rhomb Area: " + rhomb.CountArea(a, b, angle));
            
            Console.WriteLine("Square Perimeter: " + square.ConutPerimeter(a, b, c, d));
            Console.WriteLine("Square Area: " + square.CountArea(a, b, angle));
            
            Console.WriteLine("Parallelogram Perimeter: " + parallelogram.ConutPerimeter(a, b, c, d));
            Console.WriteLine("Parallelogram Area: " + parallelogram.CountArea(a, b, angle));
            
            Console.WriteLine("Rectangle Perimeter: " + rectangle.ConutPerimeter(a, b, c, d));
            Console.WriteLine("Rectangle Area: " + rectangle.CountArea(a, b, angle));
            
            Console.WriteLine("Tetragon Perimeter: " + tetragon.ConutPerimeter(a, b, c, d));
            Console.WriteLine("Tetragon Area: " + tetragon.CountArea(a, b, angle));
        }
    }
}