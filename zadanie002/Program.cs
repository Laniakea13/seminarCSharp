// Даны два числа. Показать большее и меньшее число
int numberA = 89;
int numberB = 45;

int bolshe = numberA;

if(numberA > numberB) bolshe = numberA;
if(numberA < numberB) bolshe = numberB;

Console.WriteLine(bolshe);
Console.Write("Это число больше");
