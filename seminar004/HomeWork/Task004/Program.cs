// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] array  = new int[123];
Random rans = new Random();
int SumElements = 0 ;
for(int  i = 0;i < 123 ; i++ )
   array [i] = rans.Next(1,300);
for (int i = 10;i < 99 ; i++)
{
   SumElements++;
}
Console.WriteLine($"number of elements in the array from the segment [10,99] = {SumElements}");