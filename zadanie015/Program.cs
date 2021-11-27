// Дано число. Проверить кратно ли оно 7 и 23
Console.Write("Введите любое целое число - ");
int numberA = int.Parse(Console.ReadLine());

int ost7 = numberA % 7;
int ost23 = numberA % 23;

if(ost7 == 0 && ost23 ==0)
{
    Console.Write($"{numberA} кратно 7-ми и одновременно кратно 23-м");
}
else
{
    Console.WriteLine("Заданное число не является кратным 7-ми и 23-м одновременно");
}
