// Домашняя задача 66.
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int M, int N)
{
    if (M == N)
        return M;
    return M + SumNumbers(M + 1, N);
}
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} составляет: {SumNumbers(M, N)}");