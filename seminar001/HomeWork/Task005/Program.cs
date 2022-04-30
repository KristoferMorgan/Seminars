// Показать вторую цифру трехзначного числа
Console.WriteLine("Введите трехзначное число,что бы найти вторую цифру");
int Number = int.Parse(Console.ReadLine());
int Number_2 = Number / 10 % 10;
Console.Write("Вторая цифра вашего числа :");
Console.WriteLine(Number_2);

