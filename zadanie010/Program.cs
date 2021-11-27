// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число и я покажу его вторую цифру - ");
int numberA = int.Parse(Console.ReadLine());

int divider1 = 100;
int divider2 = 10;
int numberC = 0;
double numberB = numberA / divider1;
int numberN = numberA%divider1;
if(numberB < 1) 
{
    Console.Write("Это двухзначное число :|");
}
else
{
    numberC = numberN / 10;
    Console.Write($"Вторая цифра этого числа - {numberC}");
}
