// По двум заданным числам проверить является липервое квадратом второго
Console.WriteLine("Введите число:");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите предпологаемый квадрат этого числа:");
int number_2 = int.Parse(Console.ReadLine());
int square = number_1 * number_1;
if (square == number_2)
{
     Console.WriteLine("Второе число является квадратом первого");
}

else
    {
        Console.WriteLine("Второе число не является квадратом первого");
    }
