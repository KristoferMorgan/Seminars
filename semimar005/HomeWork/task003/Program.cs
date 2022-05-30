// Написать программу копирования массива
void PrintArray(int[]array)
{
   int length = array.Length;
    for(int i = 0;i < length;i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
void EnterArray(int[]array)
{
    int length = array.Length;
    for(int i = 0 ; i < length;i++)
    {
        Console.Write($"Enter {i+1} element array : ");
        array[i] = int.Parse(Console.ReadLine()?? "");
    }
}
void CopyArray(int[]array,int [] copy)
{
    int length = array.Length;
    for(int i = 0; i < length;i++)
    {
        copy[i] = array[i];
        }
    }

Console.Write("Enter the number of array elements");
int count = int.Parse(Console.ReadLine()?? "");
int [] arrayOne = new int[count];
int [] arrayTwo = new int[count];
EnterArray(arrayOne);
Console.WriteLine("output your array:  ");
PrintArray(arrayOne);
Console.WriteLine("1) Want to copy your array? In this case, enter:  ");
int variable = int.Parse (Console.ReadLine()?? "");
if (variable == 1)
{
       Console.WriteLine("Second array:");
       PrintArray(arrayTwo);
       CopyArray(arrayOne,arrayTwo);
       Console.WriteLine("Second array after copying:");
PrintArray(arrayTwo);
}   
else
{
    Console.WriteLine("Second array:");
       PrintArray(arrayTwo);
}

