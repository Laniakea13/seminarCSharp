// Программа проверяет пятизначное число на палиндромом
Console.WriteLine("Введите пятизначное число - ");
int number = int.Parse(Console.ReadLine());
if(number > 99999 | number < 10000) Console.WriteLine("Число не пятизначное. Попробуйте еще раз");
int n5 = number % 10; //Console.WriteLine(n5);
int n1 = number / 10000; //Console.WriteLine(n1);
int n2 = (number - (n1 * 10000)) / 1000; //Console.WriteLine(n2);
int n3 = (number - (n1 * 10000) - (n2 * 1000)) / 100; //Console.WriteLine(n3);
int n4 = (number - (n1 * 10000) - (n2 * 1000) - (n3 * 100)) / 10; //Console.WriteLine(n4);
if (n1 == n5 & n2 == n4) 
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}