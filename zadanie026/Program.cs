// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число, которое будем возводить в степень");
int A = int.Parse(Console.ReadLine());
int A1 = A;
Console.WriteLine("В какую сепень будем возводить?");
int B = int.Parse(Console.ReadLine());
for (int i = 1; i < B; i++)
{
    A = A * A1;
}
Console.WriteLine($"Число {A1} в степени {B} равно {A}");