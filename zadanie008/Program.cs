// Показать четные числа от 1 до N
int numberN = 99;
int count = 0;
int chetnie =2;
int schet = numberN - chetnie;

Console.Write("Четные числа:");

while(count <= schet /2)
{
    Console.Write($"{chetnie}, ");
    chetnie = chetnie + 2;
    count = count +1;
}