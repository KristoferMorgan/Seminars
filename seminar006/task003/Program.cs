//В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет

void FillArray(int[,] array)
{
    Random rnd           = new Random();
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i,j] = rnd.NextDouble();
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void SearchElement(int[,] array, int number)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    bool   found         = false;
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            if(array[i,j] == number)
            {
             Console.WriteLine($"Элемент {number} находится на позиции [{i},{j}]");
             found = true;
            }
        }       
    }
    if(!found) Console.WriteLine($"Элемент {number} не найден в массиве!");
}
//--------------------------------------------------------------------------------------------+
void PrintArray(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            Console.Write(" {0:F8} ",array[i,j] + " ");
        } 
        Console.WriteLine();      
    }

}
//--------------------------------------------------------------------------------------------+
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine()?? "");

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
SearchElement(array,number);
