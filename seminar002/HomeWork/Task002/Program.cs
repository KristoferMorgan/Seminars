// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Enter Number One");
int  number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Number Two");
int number_2 = int.Parse(Console.ReadLine());
if (number_1 * number_1 == number_2)
{
  Console.WriteLine("the first number is the square of the second number");
}
else
  Console.WriteLine("the first number is not the square of the second number");