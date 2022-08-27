/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5) */
System.Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double X = FindX(b1, k1, b2, k2);
double Y = FindY(X, b1, k1);
if (k1 == k2)
{
	Console.WriteLine("Точки пересечения нет, потому что прямые параллельны!");
}
else
{
	System.Console.WriteLine($"Координаты точки пересечения двух прямых: х = {X}, y = {Y}");
}

double FindX(double b1, double k1, double b2, double k2)
{
	double x = ((b2 - b1) / (k1 - k2));
	return x;
}

double FindY(double x, double b1, double k1)
{
	double y = (k1 * x + b1);
	return y;
}