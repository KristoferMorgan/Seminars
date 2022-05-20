// Найти сумму чисел от 1 до А
Console.Write("set the last number for the sum of numbers from 1 :");
int number = int.Parse(Console.ReadLine()??"");
int variable = 0;
for(int i = 1;i <= number;i++)
{
   variable = variable + i;
}
  Console.WriteLine($"set the last number for the sum of numbers from 1 = {variable}");
