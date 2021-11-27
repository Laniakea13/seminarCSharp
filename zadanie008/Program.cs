// Показать четные числа от 1 до N
Console.Write("Введите любое целое число - ");
int numberN = int.Parse(Console.ReadLine());
int count = 0;
int chetnie =2;
int schet = numberN - chetnie;

Console.WriteLine($"Четные числа от 1 до {numberN}:");

while(count <= schet /2)
{
    Console.Write($"{chetnie}, ");
    chetnie = chetnie + 2;
    count = count +1;
}