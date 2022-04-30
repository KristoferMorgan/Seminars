// Удалить вторую цифру трехзначниго числа
int Number = new Random().Next(100,999);
Console.WriteLine("Ваше случайное число");
Console.WriteLine(Number);
int Number_2 = Number % 10;
int Number_1 = Number /10/10;
Console.Write("Убрали среднюю цифру,получилось = ");
Console.Write(Number_1);
Console.Write(Number_2);