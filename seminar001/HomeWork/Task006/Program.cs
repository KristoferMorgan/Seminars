// Дано число из отрезка [10 , 99].Показать наибольшую цифру числа
int Number = new Random().Next(10,100);
Console.WriteLine("Ваше случайное число");
Console.WriteLine(Number);
int Number_2 = Number % 10;
int Number_1 = Number / 10;
if (Number_1 > Number_2){
   Console.Write("Наибольшая цифра числа ");
   Console.WriteLine(Number_1);}
   if(Number_1 < Number_2){
     Console.Write("Наибольшая цифра числа ");
     Console.WriteLine(Number_2);}
       if (Number_1 == Number_2)
         {Console.WriteLine("Первая цифра равна второй,цифра = ");
         Console.WriteLine(Number_1);}