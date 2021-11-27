// Показать числа от -N до N
Console.Write("Введите любое целое число - ");
int numberN = int.Parse(Console.ReadLine());
int count = 0;
int times = 0;

times = numberN*2 +1;
numberN = numberN*(-1);

while(count<times)
{
    Console.Write($" {numberN} ,");
    numberN = numberN +1;
    count = count + 1;
}