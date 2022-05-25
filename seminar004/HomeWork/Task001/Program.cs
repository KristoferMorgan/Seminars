// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("This program fills the array 0 and 1");
int [] array = new int [10];
Random rand = new Random();
 Console.WriteLine("It's your random numbers:");
for(int i = 0;i<array.Length;i++)
{
   array[i] = rand.Next(0,2);
   Console.WriteLine(array[i]);
}
