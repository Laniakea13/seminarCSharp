// Показать натуральные числа от N до 1, N задано
void Number(int n)
{
    Console.Write($"{n} ");
    if (n  !=1) 
    {
        Number(n-1);
    }
    
}
Number(10);
