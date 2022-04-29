// Найти максимальное из трех чисел
Console.WriteLine("Введите число ,");
double number_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число ,");
double number_2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число ,");
double number_3 = double.Parse(Console.ReadLine());
double max = number_1;
if (max < number_2);
{
    max = number_2;
}
if (max < number_3);
{
    max = number_3;
}
Console.Write("Максимальное число = ");
Console.WriteLine(max);