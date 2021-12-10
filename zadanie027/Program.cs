// Определить количество цифр в числе
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int z = 0;
for (int i = 0; i < number; i++)
{
    number = number / 10;
    z= z +1;
}
if(z == 1 | z == 2| z ==3) Console.WriteLine(z);
else Console.WriteLine($"Заданное число содержит {(z+1)} цифр");