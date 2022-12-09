// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void NumPow (int N1, int N2) // не возвращает данные в основную программу
{
    int sqrt = 1;
    for (int i=1; i<=N2; i++)
    {
        sqrt = sqrt*N1;
    }
    Console.WriteLine(sqrt);
}

Console.WriteLine("Введите первое целое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int N2 = Convert.ToInt32(Console.ReadLine());
NumPow(N1, N2);