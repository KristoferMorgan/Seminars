// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы. 
Console.Clear();
Console.Write("enter value k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("enter value b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("enter value k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("enter value b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "");
int x = 0;
int y = 0;
if (k1 == k2)
{
    Console.WriteLine("The lines are parallel");
}
else 
{
    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;
    Console.WriteLine($"your point of intersection = {x}, y = {y}");
}