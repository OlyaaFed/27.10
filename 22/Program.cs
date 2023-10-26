Console.WriteLine("Введите колличество чисел");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b=Convert.ToInt32(Console.ReadLine());
int c= Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 0;
for (int i = 0; i < a; i++)
{
    if (b % 10 == c)
    {
        sum += i;
        count++;
    }

}
if (count > 3)
{
    Console.WriteLine($"Сумма  чисел, которые оканчиваются на {c} равна {sum}");
}
else
{
    Console.WriteLine($"Недостаточно чисел, которые оканчиваются на {c}, чтобы найти сумму");
}
