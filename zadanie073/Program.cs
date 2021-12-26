// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int Function(int a, int b, int n)
{
    if(n==1) return a;
    if(n ==2) return b;
    
    return Function(a,b, n-1) + Function(a,b, n-2);
}
int count = 10;
for (int i = 1; i<count; i++)
{
    Console.Write($"{Function(1,2,i)} ");
}