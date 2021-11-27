using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            int type;
            double a, b, c, s;

            Console.WriteLine(" Расчет площади треугольника с помощью метода.");
            Console.WriteLine(" Выберите тип треугольника: \n" +
                " 1 - Разносторонний  \n" +
                " 2 - Равносторонний  \n" +
                " 3 - Равнобедренный  \n" +
                " 4 - Остроугольный   \n" +
                " 5 - Прямоугольный   \n" +
                " 6 - Тупоугольный");
            type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 2:
                    Console.WriteLine("Ведите значение стороны треуголника: ");
                    a = double.Parse(Console.ReadLine());
                    s = Operation.STriangle(a, out s);
                    Console.WriteLine("Площадь треугольника: " + s);
                    break;

                default:
                    Console.WriteLine("Ведите значение стороны треуголника (a): ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ведите значение стороны треуголника (b): ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ведите значение стороны треуголника (c): ");
                    c = double.Parse(Console.ReadLine());

                    s = Operation.STriangle(a, b, c, out s);

                    if (s>0)
                    {
                        Console.WriteLine("Площадь треугольника: " + s);
                    }
                    else
                    {
                        Console.WriteLine("Недопустимые значения сторон!");
                    }

                    break;
            }
        }
    }
}
