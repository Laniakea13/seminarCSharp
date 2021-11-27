// Даны два числа. Показать большее и меньшее число
Console.Write("Введите первое число - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int numberB = int.Parse(Console.ReadLine());

int bolshe = numberA;

if(numberA > numberB) bolshe = numberA;
if(numberA < numberB) bolshe = numberB;

Console.Write($"Число {bolshe} явно больше");

