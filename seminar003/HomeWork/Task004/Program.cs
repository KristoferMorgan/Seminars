// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("this is a program for raising a number to a power");
Console.WriteLine("enter a short number to be raised to a power:");
int A = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Enter the power to which you want to raise the number:");
int B = int.Parse(Console.ReadLine()??"");
int Variable = A;
for(int i = 1;i < B;i++)
    Variable = Variable * A;

Console.WriteLine($"{A} to the power of {B} = {Variable}");
