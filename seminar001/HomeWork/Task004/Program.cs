// Показать все четные числа от 1 до N
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
Console.WriteLine("Четные числа от 1 до N :");
while(N + 1 > count)
{
 if (count % 2 == 0) 
  Console.WriteLine(count);
count = count + 1; 
}   