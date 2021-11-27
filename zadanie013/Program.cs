// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("ВВедите ваше число");

int numberA = 100;
int numberB = int.Parse(Console.ReadLine());
int numberC = numberA % numberB;

if(numberC == 0 )
{
  Console.WriteLine("Число кратно заданному");
}
else
{
  Console.WriteLine("Число не кратно заданному программой");
  Console.WriteLine($"Остаток от деления {numberC}");
}
