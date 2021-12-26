// Написать программу возведения числа А в целую стень B
double Number(double a, double b)
{
    if (b==0) return 1;
    if (b > 0) return Number(a, b-1)*a;
    else return Number (a,b +1) * 1/a;
}
Console.WriteLine(Number(5, 4));