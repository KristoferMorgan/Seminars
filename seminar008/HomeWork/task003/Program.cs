// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int[,,]array)
{
    int count = 10;
      for(int i  = 0;i < array.GetLength(0);i++)
                for(int j =0;j < array.GetLength(1);j++)
                    for(int k =0;k < array.GetLength(2);k++)
                   {  
                    array[i,j,k] = count;
                    Console.WriteLine($"{array[i,j,k]} [{i},{j},{k}]");
                    count++;
                       if(count == 100)
                      {   
                        Console.WriteLine("unique value overflow");
                        return;
                      }
                   }     
}
Console.WriteLine("enter the number of elements of the first dimension");
int firstDimension = int.Parse(Console.ReadLine()??"");
Console.WriteLine("enter the number of elements of the second dimension");
int secondDimension = int.Parse(Console.ReadLine()??"");
Console.WriteLine("enter the number of elements of the third dimension");
int thirdDimension = int.Parse(Console.ReadLine()??"");
int[,,] array = new int[firstDimension, secondDimension, thirdDimension]; 
Console.WriteLine("Printing array values ​​and their indices");
FillArray(array);




