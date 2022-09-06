// Домашняя задача 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Ackerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    if (N == 0 && M > 0)
        return Ackerman(M - 1, 1);
    if (M > 0 && N > 0)
        return Ackerman(M - 1, Ackerman(M, N - 1));
    return Ackerman(M, N);
}

Console.WriteLine($"Число Аккермана для А({M}, {N}) = {Ackerman(M, N)}");