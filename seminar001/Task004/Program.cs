// Показать числа от -N до N
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
int count = ~ N;
count += 1;
Console.WriteLine("Это числа от -N до N:");
while(count < N + 1)
{
    Console.WriteLine(count);
    count = count + 1;
}
