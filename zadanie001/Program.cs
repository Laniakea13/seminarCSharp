// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое целое число - ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число - ");
int numberB = int.Parse(Console.ReadLine());

int numberC = numberA *numberA;

if(numberB == numberC)
{
    Console.WriteLine($"Число {numberA} дейстительно является квадратом {numberB}");
}
else
{
    Console.WriteLine($"Число {numberA} не является квадратом числа {numberB} ");
}

