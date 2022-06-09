// Найти произведение двух матриц
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
     Random rnd = new Random();
     for(int i = 0;i < array.GetLength(0);i++)
       for(int j =0;j < array.GetLength(1);j++)
         array[i,j] = rnd.Next(1,100);
}

Console.WriteLine("Enter number of rows fist array");
int aRows = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Enter number of columns fist array");
int aColumns = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Enter number of rows second array");
int bRows = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Enter number of columns second array");
int bColumns = int.Parse(Console.ReadLine()??"");
int [,] arrayA = new int[aRows,aColumns];
int [,] arrayB = new int[bRows,bColumns]; 
int[,] ProductOfTwoMatrices(int [,] arrayA,int[,]arrayB)
{
  int [,] arrayProduct = new int[arrayA.GetLength(0),arrayB.GetLength(1)];
    
    for (int i = 0; i < arrayA.GetLength(0); i++) 
    {
      for (int j = 0; j < arrayB.GetLength(1); j++)
        for (int k = 0; k < arrayA.GetLength(0);k++)
          arrayProduct[i,j] = arrayA[i,k] * arrayB[k,j];
    }
    return arrayProduct;  
               
}
if (arrayA.GetLength(0) == arrayB.GetLength(1))
{  
   FullArray(arrayA);
   FullArray(arrayB);
   Console.WriteLine("We derive the first matrix: ");
   PrintArray(arrayA);
   Console.WriteLine("Output the second matrix: "); 
   PrintArray(arrayB);
   Console.WriteLine("Your product of matrices");
   PrintArray(ProductOfTwoMatrices(arrayA,arrayB));
}
else
   Console.WriteLine("It is not possible to return the product of these matrices"); 
       