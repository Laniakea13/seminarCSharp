// Найти максимальное из трех чисел
Console.Write("Введите первое число - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
int numberC = int.Parse(Console.ReadLine());
int max = 0;

if(numberB > numberA)
{
    max = numberB;
}
else
{
    max = numberA;
}
if(max < numberC)
{
    max = numberC;
}
else
{
    max = max;
}
Console.Write("Максимальное число из этих трех - ");
Console.WriteLine(max);
