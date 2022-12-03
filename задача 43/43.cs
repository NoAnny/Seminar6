// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//координаты точки найдем через систему двух уравнений (с применением метода вычитания)
//y = k1 * x + b1;
//y = k2 * x + b2;
//x = (b2 - b1)/(k1-k2)

Console.WriteLine("Введите коэффициент k1");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b1");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k2");
int k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b2");
int b2 = int.Parse(Console.ReadLine()!);
double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"Заданные уравнениями прямые пересекаются в точке М с координатами({x},{y})");
