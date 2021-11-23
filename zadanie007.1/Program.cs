// Показать числа от -N до N
int numberN = 10;
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