// Показать последнюю цифру трехзначного числа
int remainder = 0;
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
remainder = number % 10;
Console.Write("Последняя цифра вашего числа ");
Console.WriteLine(remainder);
