// Показать числа Фибоначчи меньше заданного числа N
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "");

int firstValue  = 0;
int secondValue = 1;
int result      = 0;
Console.Write($"{firstValue} {secondValue} ");

while(firstValue + secondValue < N)
{
    result = firstValue + secondValue;
    Console.Write(result + " ");
    firstValue = secondValue;
    secondValue = result;
}

// //Показать числа Фибоначчи меньше заданного числа N (по кол-ву)

// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// int a = 1;
// int b = 0;
// int result;
// for (int i =0;i < n;i++)
// {
//     result = a + b;
//     Console.WriteLine(result + " ");
//     a = b;
//     b = result;
// }
