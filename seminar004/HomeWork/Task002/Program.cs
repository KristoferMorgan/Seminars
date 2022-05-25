// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива.
int [] array = new int [12];
Random rand = new Random();
 Console.WriteLine("It's your random numbers:");
 int sum_of_positive = 0;
 int sum_of_negative = 0;

for(int i = 0;i<array.Length;i++)
{
   array[i] = rand.Next(0,9);
   Console.WriteLine(array[i]);
   if(array[i] > 0)
     sum_of_positive = sum_of_positive + array[i];
   if(array[i] < 0)
     sum_of_negative = sum_of_negative + array[i];  
}
Console.Write($"sum of positive = {sum_of_positive};   ");
Console.WriteLine($"sum of negative = {sum_of_negative}");