// Узнать является ли число кротно 7 и 23
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
   Console.WriteLine ("Ваше число кратно 7 и 23");
else
   Console.WriteLine("Ваше число не кратно 7 и 23");