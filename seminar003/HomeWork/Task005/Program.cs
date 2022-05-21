// Подсчитать сумму цифр в числе
Random rnd = new Random();
int number = rnd.Next(0,100000);
Console.WriteLine($" your random number = {number}");
int sum = 0;
while(number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine($" sum of digits of your number = {sum} ");