// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine();
int [] array = new int [20];
Random rand = new Random();
for(int i = 0;i < 20 ;i++)
{
    array[i] = rand.Next(1,200);
    Console.Write($"{i}: {array[i]};   ");
}
int NumberMin = 0;
int NumberMax = 19;
int productOfNumbers = 0;
Console.WriteLine();
for( int  j = 1;NumberMin < NumberMax ;j++ )
{
    productOfNumbers = array[NumberMax] * array[NumberMin];
    Console.Write($"Holding a {j} pair of numbers= {productOfNumbers};  "); 
    NumberMax = NumberMax - 1;
    NumberMin++;
}   