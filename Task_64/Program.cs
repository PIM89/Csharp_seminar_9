/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

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

string NaturalNumbers(int m, int n)
{
    if (m <= n) return $"{m}, " + NaturalNumbers(m + 1, n);
    else return string.Empty;
}
Console.WriteLine(NaturalNumbers(m, n));