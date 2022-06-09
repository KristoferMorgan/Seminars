// Показать треугольник Паскаля 
//*Сделать вывод в виде равнобедренного треугольника
Console.Write("enter the number of lines: ");
int n = int.Parse(Console.ReadLine()??"");
Console.WriteLine("your pascal's triangle:");          
int[][] pascalTriangle = new int[n][];
pascalTriangle[0] = new int[] { 1 }; 
for (int i = 1; i < pascalTriangle.Length; i++)
{
    pascalTriangle[i] = new int[i + 1];  
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
            pascalTriangle[i][j] = 1;
        else
        {
            pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
        }
    }
} 
for (int i = 0; i < pascalTriangle.Length; i++)
{
    for (int j = 0; j < pascalTriangle[i].Length; j++)
        {
          Console.Write("{0,-3} ", pascalTriangle[i][j]);
        }
    Console.WriteLine();
} 
Console.ReadKey();
            