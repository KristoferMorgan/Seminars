void CoordinatesArray(int[,] coord)
{ 
    int count = coord.GetLength(0);
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Enter coordinate x[{i}]: ");
         coord[i,0] = int.Parse(Console.ReadLine() ?? "0");
         Console.Write($"Enter coordinate y[{i}]: ");
         coord[i,1] = int.Parse(Console.ReadLine() ?? "0");
    }
}
void PrintArray(int[,] array, int k)
{
    int length = array.GetLength(0);
    for (int i = 0; i < length; i++)
    {
       Console.Write($"({array[i,0] * k};{array[i,1] * k}) " );
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Enter the number of vertices of the figure: ");
int count = int.Parse(Console.ReadLine() ?? "0");
int[,] coordinates = new int[count,2];
CoordinatesArray(coordinates);
int k = 1;
Console.WriteLine("Figure vertex coordinates before scaling:");
PrintArray(coordinates, k);
Console.WriteLine("Enter coefficient k:");
k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Figure vertex coordinates after scaling:");
PrintArray(coordinates, k);

// RealMadrig is the best)))