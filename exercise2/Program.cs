// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumN(int num)
{
    int N = 0;
    while (num>0)
    {
        N=N+num%10;
        num=num/10;
    }
return N;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumN(num));
