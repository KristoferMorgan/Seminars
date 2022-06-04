// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void FullArray(int[,]array)
{
Random rnd = new Random();
int rowsLength = array.GetLength(0);
int columnsLength = array.GetLength(1);
for (int i = 0;i < rowsLength;i++)
    for (int j = 0;j < columnsLength;j++)
       array[i,j] = rnd.Next(1,20);
}
void PrintArray(int[,]array)
{
   int rowsLength = array.GetLength(0);
   int columnsLength = array.GetLength(1);
   for (int i = 0;i < rowsLength;i++)
   {
     for(int j = 0;j < columnsLength;j++)
       Console.Write(array[i,j] + "  ");
    Console.WriteLine();   
   }    
}
void Sorting(int [,]array)
{
   int rowsLength = array.GetLength(0);
   int columnsLength = array.GetLength(1);
   for (int j = 0;j < rowsLength;j++) 
     for (int i = 0; i < rowsLength; i++)
        for (int b = 0; b < columnsLength - i - 1 ; b++)
            if (array[j,b] < array[j,b + 1])
            {
                int temp = array[j,b];
                array[j,b] = array[j,b + 1];
                array[j,b + 1] = temp;
            }
}
    

Console.Write("Enter the number of rows in the array: ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.Write("Enter the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine()?? "");
int[,]array = new int[rows,columns];
FullArray(array);
PrintArray(array);
Sorting(array);
Console.WriteLine("array after change");
PrintArray(array);

