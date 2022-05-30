// Написать программу преобразования десятичного числа в двоичное
Console.Clear();
Console.Write("Введите десятичное число ");
int num = int.Parse(Console.ReadLine() ?? "0");
string result = "";
string RevResult = "";
while (num > 0)
{
    result = result + (num % 2).ToString();
    num = num / 2;
}
int length = result.Length;
for (int i = length - 1; i >=0; i--)
    RevResult += result[i]; 
Console.WriteLine($"{RevResult}");

// // Второй вариант

// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");
// int Bit = Number % 2;
// int NewNumber = Bit;
// Number = Number / 2;
// int i = 1;
// while (Number > 0)
// {
//     Bit = Number % 2;
//     Number = Number / 2;
//     NewNumber = NewNumber + Bit * (int)Math.Pow(10,i);
//     i++;
// }
// Console.WriteLine(NewNumber);
