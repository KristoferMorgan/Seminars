// Найти в какой четверти плоскости находятся x и y
// X и Y не равны нулю
Console.Write("Введите x:");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y:");
int y = int.Parse(Console.ReadLine());
if(x < 0 && y < 0)
   Console.WriteLine("число находится в третьей четверти плоскости");
if(x < 0 && y > 0)
   Console.WriteLine("число находится в четвертой четверти плоскости");
if(x > 0 && y < 0 ) 
   Console.WriteLine("число находится в четвертой четветри плоскости");
if(x > 0 && y > 0)
  Console.WriteLine("число находится в первой четверти плоскости");
if(x == 0)
  Console.WriteLine("x  не может быть равен 0,введите данные заного");
if(y == 0)
  Console.WriteLine("y не может быть равен 0,введите значение заного");