// Показать последнюю цифру трёхзначного числа
Console.Write("Введите любое трехзначное целое число - ");
int numberA = int.Parse(Console.ReadLine());
int divider = 100;
int ostatok = 0;
double result1 = numberA / divider;
int result3 = numberA%divider;
int result2 = result3%10;
if(result1 < 1) 
{
    Console.WriteLine("Это двухзначное число, дружочек");
}
else
{
    ostatok = result2;
    Console.WriteLine($"Последней цифрой этого чила является {ostatok}");
}
    



