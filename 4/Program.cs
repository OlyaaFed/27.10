Console.WriteLine("Введите число");
double N = Convert.ToDouble(Console.ReadLine());
double a=0;
double b=0;
double res=1;
for (int i=1; i<=N; i++)
{
    a += Math.Cos(i);
    b += Math.Sin(i);
    res *= (a / b);
}
Console.WriteLine($"Выражение {res}");

