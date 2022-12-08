Console.Clear();
Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double A = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double B = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double C = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
double areaTriangle = (A + B + C) / 2;
Console.WriteLine($"Площадь треугольника = {areaTriangle} ");




