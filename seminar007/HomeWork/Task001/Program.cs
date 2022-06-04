// Написать программу, которая обменивает элементы первой строки и последней строки
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
void ReplacementOfSetElements(int [,]array)
{
  int rowsLength = array.GetLength(0);
  int columnsLength = array.GetLength(1);
  int a = 0;
  for(int i = 0;i < rowsLength;i++)
  {
        a = array[i,0];
      array[i,0] = array[i,rowsLength - 1];
      array[i,rowsLength -1] = a; 
  }      
         
    
}    
Console.Write("Enter the number of rows in the array: ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.Write("Enter the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine()?? "");
int[,]array = new int[rows,columns];
FullArray(array);
PrintArray(array);
ReplacementOfSetElements(array);
Console.WriteLine("array after change");
PrintArray(array);

