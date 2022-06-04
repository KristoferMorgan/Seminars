// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
void SumMinElementsRows(int[,]array)
{
  int rowsLength = array.GetLength(0);
  int columnsLength =  array.GetLength(1);
  int indexSumMin = 0;
  int sumRows = 0;
  int sumRowsMin = 100 * rowsLength;
  for(int j = 0;j < columnsLength;j++)
  {
      if(sumRowsMin > sumRows)
      {
        sumRowsMin = sumRows;     
        indexSumMin = j + 1;
      }
      for(int i = 0;i < rowsLength;i++)
         sumRows = sumRows + array[i,j];
  }
  Console.WriteLine($"the smallest sum of elements in row {indexSumMin}");
}
Console.WriteLine("Enter number of rows");
int rows = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Enter number of columns");
int columns = int.Parse(Console.ReadLine()??"");
int[,]array = new int[rows,columns];
FullArray(array);
PrintArray(array);
SumMinElementsRows(array);