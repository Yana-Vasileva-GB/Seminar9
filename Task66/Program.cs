// Домашняя задача 66. 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n, int sum)
{
    sum = n;
    if (m == n)
        return sum;
    return (sum+SumNumbers(m, n-1, sum));
}
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} составляет: {SumNumbers(M, N, 0)}");