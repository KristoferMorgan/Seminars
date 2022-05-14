// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("enter the number : ");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 || number % 6 == 0 )
{
  Console.WriteLine("This day is a day off!!!");
}
else if (number < 0 || number >31 )
{
  Console.WriteLine("your number is not showing the day of the month");
}
else 
{
  Console.WriteLine("This day is working");
}  
