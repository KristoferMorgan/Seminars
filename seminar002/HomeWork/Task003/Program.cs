// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("enter the worm number to find out its range of coordinates :  ");
int QuarterNumber = int.Parse(Console.ReadLine());
if (QuarterNumber == 1)
{
  Console.WriteLine("range of your coordinates: ");
  Console.WriteLine("x = from zero to infinity");
  Console.WriteLine("y = from zero to infinity");
}
else if (QuarterNumber == 2)
{
    Console.WriteLine("range of your coordinates: ");
    Console.WriteLine("x = from -infinity to zero");
    Console.WriteLine("y = from zero to infinity");
}
else if (QuarterNumber == 3)
{
    Console.WriteLine("range of your coordinates: ");
    Console.WriteLine("x = from -infinity to zero");
    Console.WriteLine("y = - infinity to zero");
}
else if (QuarterNumber == 4)
{
    Console.WriteLine("range of your coordinates: ");
    Console.WriteLine("x = from zero to infinity");
    Console.WriteLine("y = from -infinity to zero");
}
else
{
    Console.WriteLine("The number of such a quarter of the plane does not exist");
    Console.WriteLine("Repeat input");
    }