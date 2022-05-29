// Показать двумерный массив размером mXn заполненный вещественными числами
void FullArray (double[,]array)
{
  Random rnd = new Random();
  int rowsLength = array.GetLength(0);
  int columnsLength = array.GetLength(1);
  for(int i = 0;i < rowsLength;i++)
  {
    for(int j =0;j < columnsLength;j++)
    {
      array [i,j] = rnd.NextDouble();
    }
  }
}

void PrintArray (double [,] array)
{
  int rowsLength = array.GetLength(0);
  int columnsLength = array.GetLength(1);
  for(int i = 0;i < rowsLength;i++)
  {
    for(int j = 0;j < columnsLength;j++ )
    {
      Console.Write(" {0:F8} ",array[i,j]+ "  ");
    }
    Console.WriteLine(); 
  }
}

Console.Clear();
Console.Write("Enter the number of rows in the array: ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.Write("Enter the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine()?? "");
double[,]array = new double[rows,columns];
FullArray(array);
PrintArray(array);