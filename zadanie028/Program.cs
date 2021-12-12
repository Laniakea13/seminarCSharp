// Определить количество цифр в числе
Console.Write("Введите число - ");
string number = Console.ReadLine();
double numberX = Convert.ToInt32(number);
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    sum = sum +1;
}
Console.WriteLine(sum);