// Написать программу, которая в двумерном массиве заменяет строки на столбцы или 
// сообщить, что это невозможно (в случае, если матрица не квадратная).
void PrintArray(int[,]array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for(int i = 0;i < rowsLength;i++)
    {
      for(int j = 0;j < columnsLength;j++)
        Console.Write(array[i,j]+"  ");
        
    Console.WriteLine();
    }    
}
void FullArray(int[,]array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength =  array.GetLength(1);
     Random rnd = new Random();
     for(int i = 0;i < rowsLength;i++)
       for(int j =0;j < columnsLength;j++)
         array[i,j] = rnd.Next(1,100);
}
void SwapRowsAndColumns(int[,]array)
{
  int rowsLength = array.GetLength(0);
  int columnsLength =  array.GetLength(1);
  int temp = 0;
  int b = -1;
  for(int j = 0;j < columnsLength;j++)
  {b++;
  for(int i = 0 + b;i < columnsLength;i++)
    {
      temp = array[i,j];
      array[i,j] = array[j,i];
      array[j,i] = temp;
    } 
   } 
Console.WriteLine("Change the value of rows and columns with each other");
PrintArray(array);
}
Console.WriteLine("Enter number of rows");
int rows = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Enter number of columns");
int columns = int.Parse(Console.ReadLine()??"");
int[,]array = new int[rows,columns];
FullArray(array);
PrintArray(array);
if(rows!= columns)
   Console.WriteLine("Error!!!Entered not a square matrix");
else   
   SwapRowsAndColumns(array);
