// В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void PrintArray(int[,]array)
{
    for(int i = 0;i < array.GetLength(0);i++)
    {   
        Console.WriteLine();
          for(int j = 0;j < array.GetLength(1);j++)
            Console.Write(array[i,j] + "  ");
    }
}
void FillArray(int[,]array)
{
    Random rnd = new Random();
    for(int i = 0;i < array.GetLength(0);i++)
      for(int j = 0;j < array.GetLength(1);j++)
        array[i,j] = rnd.Next(1,100); 
}

Console.WriteLine("Enter number of rows  array");
int rows = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Enter number of columns  array");
int columns = int.Parse(Console.ReadLine()??"");
int [,]array = new int[rows,columns];
int rows1 = rows - 1;
int columns1 = columns - 1;
int [,]newArray = new int[rows1 ,columns1 ];
FillArray(array);
Console.WriteLine("it's your array:");
PrintArray(array);
int indexRowsMin = -0;
 int indexColumnsMin = 0;
int min = array[0,0];
 for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                 min = array[i, j];
                 indexRowsMin = i;
                 indexColumnsMin = j;
            }
Console.WriteLine();            
Console.WriteLine($"minimum number in array:{array[indexRowsMin,indexColumnsMin]}");
int rowsNewArray = 0;
for(int i = 0;i < array.GetLength(0);i++)
{
  int columnsNewArray = 0;
        for(int j = 0;j < array.GetLength(1);j++)
        {
           if ( j != indexColumnsMin  )
           {
              newArray[rowsNewArray,columnsNewArray] = array[i  ,j ];
              columnsNewArray++; 
           }
        }
        if (i != indexRowsMin  )
     rowsNewArray++;  
}
Console.WriteLine("removes the row and column containing the minimum number");
Console.WriteLine("Print new array");
PrintArray(newArray);
