// Найти максимальное из трех чисел
int numberA = 56;
int numberB = 45;
int numberC = 76;
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
Console.Write("Максимальное число из трех - ");
Console.WriteLine(max);