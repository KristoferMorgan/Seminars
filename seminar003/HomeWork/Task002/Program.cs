// Найти кубы чисел от 1 до N
Console.Write("enter the variable number to consume the end of the table of cubes:");
int number = int.Parse(Console.ReadLine()??"");
int variable = 0;
Console.WriteLine("display the value of the cube table from 1 to the entered variable");
for(int i = 1;i <= number;i++)
{
   variable = i * i * i;
   Console.WriteLine($"squar number {i} = {variable}");
}
  