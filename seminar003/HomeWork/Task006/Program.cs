// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("This program will show cubes of random numbers");
int [] array = new int [5];
Random rand = new Random();
 Console.WriteLine("It's your random numbers:");
for(int i =0;i<array.Length;i++)
{
   array[i] = rand.Next(-100,100);
   Console.WriteLine(array[i]);
   if(array[i] % 2 == 0)
   {
      Console.WriteLine("number is even,it's cube:");
      Console.WriteLine( array[i] * array[i] * array[i]);
   }
   if(array[i] % 2 != 0)
      Console.WriteLine("this number is not even");
}