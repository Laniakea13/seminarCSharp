// Показать натуральные числа от M до N, N и M заданы
string Numbers(int m, int n)
{
    if (m<=n) return Numbers(m, n-1) + $"{n} ";
    else return string.Empty;
    Console.Write($"{n} ");
}
Console.WriteLine(Numbers(3,10));