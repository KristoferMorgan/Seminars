//Определить количество цифр в числе
//Console.WriteLine("Insert ur number");
//int number = int.Parse(Console.ReadLine());
//int count = 0;
//int tmpnumber = number;
//while(tmpnumber > 0)
//{
    //tmpnumber = tmpnumber / 10;
    //count++;
//}
//Console.WriteLine($"Digits in {number} is {count}");


Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
string c;
c = number.ToString();
int c1 = c.Length;
Console.WriteLine($"Digits in {number} is {c1}");

