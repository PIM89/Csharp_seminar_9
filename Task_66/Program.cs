/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
int SumNumbers (int m, int n)
{
    if (m <= n) return m + SumNumbers(m+1, n);
    else return 0;
}
Console.WriteLine(SumNumbers(m, n));