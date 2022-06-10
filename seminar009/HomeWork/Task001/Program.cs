// Показать натуральные числа от M до N, N и M заданы
Console.Clear();
void NumberMtoN(int NumberTo, int NumberDo)
{
    if(NumberDo + 1 > NumberTo)
        if(NumberDo > 0 )
        {
          Console.WriteLine(NumberTo);
          NumberTo++;
          NumberMtoN(NumberTo,NumberDo);
        }
        else
            {
              Console.WriteLine("$number {NumberTo} is not a natural number");
              NumberTo++;
              NumberMtoN(NumberTo,NumberDo);     
            }   
    else
      return;
}
int n = 10;
int m = 2;
NumberMtoN(m , n );

