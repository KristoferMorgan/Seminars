Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");

int[] array = new int[8];

for (int i=0; i<8; i++)
    array[i] =  new Random().Next(0,100);
    
int count = 1;

foreach (int k in array)
{
    Console.WriteLine($"{count} элемент массива - {k}");
    count++;
}