// Выяснить является ли число чётным
Console.Write("Введите любое целое число - ");
int a = int.Parse(Console.ReadLine());
int b = 2;
int d = 0;
int e = 1;
int c = (a % b);
if(c == d) Console.Write($"Число {a} является чётным");
if(c == e) Console.Write($"Число {a} является нечётным");