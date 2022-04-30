// Найти третью цифру числа или сообщить,что ее нет
int Number = new Random().Next(0,10000);
Console.Write("Ваше случайное число ");
Console.WriteLine(Number);
int Number_3 = Number / 100 % 10;
if(Number / 100 != 0)
{
  Console.Write("Третья цифра числа ");
    Console.WriteLine(Number_3);
    }
  else
   {
       Console.WriteLine("У числа нет третьей цифры");
} 