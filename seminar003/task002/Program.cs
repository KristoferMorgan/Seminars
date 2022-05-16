//Найти сумму чисел от 1 до А
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
int count = 1;
int result = 0;
while(count <= number)
{
    result = result + count;
    
    count=count + 1;
}
Console.WriteLine(result);
//n(n+1)\2
