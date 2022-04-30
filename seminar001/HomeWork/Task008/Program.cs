// Выяснить,кратно ли число заданному,если нет,вывести остаток
int Number = new Random().Next(0,10000);
Console.Write( "Введите число: ");
int Number_1 = int.Parse(Console.ReadLine());
int remainder = Number % Number_1;
Console.WriteLine("Ваше случайное число");
Console.WriteLine(Number);
if(Number % Number_1 == 0 )
  Console.WriteLine("Число кратно заданному");
  else
    Console.Write("Число не кратно заданному,его остаток = ");
    Console.WriteLine(remainder);