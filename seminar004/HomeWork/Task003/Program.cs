// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел.
int [] array = new int [10];
Random rand = new Random();
 Console.WriteLine("It's your random numbers:");
 int even_number = 0;
 int odd_number= 0;

for(int i = 0;i<array.Length;i++)
{
   array[i] = rand.Next(100,999);
   Console.WriteLine(array[i]);
   if(array[i] % 2 == 0)
     even_number = even_number + 1;
   if(array[i] % 2 != 0)
     odd_number = odd_number + 1;  
}
Console.Write($"number of even_number of array = {even_number};   ");
Console.WriteLine($"number of odd numbers in array = {odd_number}");
