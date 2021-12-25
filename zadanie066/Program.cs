// Показать натуральные числа от 1 до N, N задано
void Number(int n)
{
    
    if (n  ==1) 
    {
        Console.Write();
    }    
    else
    {
        Number(n-1);
    
    }
    Console.Write($"{n} ");
}
Number(10);
