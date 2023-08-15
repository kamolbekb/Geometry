namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Circle circle = new Circle();
        }
    }
    class Rectangle
    {
        public Rectangle()
        {

        }
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Rectangle(decimal width,decimal heigt)
        {
            Width = width;
            Height = heigt;
        }
        public Rectangle(decimal width)
        {
            Width = width;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr of a rectangle equals to:{(Width+Height)*2}");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Area of a rectangle equals to:{Width*Height}");
        }

        public void CalculateDiagonal()
        {

        }
    }
    class Circle
    {
        public Circle()
        {

        }
        public decimal Radius { get; set; }
        public Circle(decimal radius)
        {
            Radius = radius;
        }
            
        public void CalculatePerimetr()
        {

        }
        public void CalculateArea()
        {

        }
    }
}