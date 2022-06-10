//Найти сумму элементов от M до N, N и M заданы
Console.Clear();
int NumberSum(int NumberTo,int NumberDo)
{
  int sum = NumberTo;
  if(NumberTo < NumberDo)
    return sum = sum + NumberSum(NumberTo + 1,NumberDo);
  else
     return sum;
}
int m = 1;
int n = 10;
NumberSum(m,n);
Console.WriteLine($"the sum of the elements from m to n is {NumberSum(m,n)}");