// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 99);
Console.WriteLine($"Рандомное число - {number}");
int number1 = number / 10;
int number2 = number % 10;
if (number1 > number2)
{
    Console.WriteLine($"Наибольшая цифра - {number1}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Наибольшая цифра - {number2}");
}
else
 {
    Console.WriteLine("Обе цифры одинаковые");
 }