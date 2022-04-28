// Данны два числа.Показать большее и меньшее
Console.WriteLine("Введите число ,");
double number_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число ,");
double number_2 = double.Parse(Console.ReadLine());
double min = 0;
double max = 0;
if(number_2 < number_1)
{
    min = number_2;
    max = number_1;
}
else
{
    min = number_1;
    max = number_2;
}
Console.Write("Меньшее число =  ");
Console.WriteLine(min);
Console.Write("Большее число =  ");
Console.WriteLine(max);