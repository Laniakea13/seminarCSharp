// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите трехзначное число и я сообщу его третью цифру - ");
int numberA = int.Parse(Console.ReadLine());

int divider1 = 100;
int divider2 = 10;
int numberC = 0;
double numberB = numberA / divider1;
int numberN = numberA%divider1;
if(numberB < 1) 
{
    Console.Write("Это двухзначное число :| и соответственно третьей цифры в нем нет");
}
else
{
    numberC = numberN / 10;
    Console.Write($"Третья цифра этого числа - {numberC}. Очевидно же!");
}
