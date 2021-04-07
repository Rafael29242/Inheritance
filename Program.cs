using System;

namespace Lab_C_Sharp_Ch12
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(1);
            s1.SetColor("Black");
            Console.WriteLine(s1.GetColor());

            Shapes s = new Square(2);
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
        }
    }
}
