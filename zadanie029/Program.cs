// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите чему будет ровняться N");
int N = int.Parse(Console.ReadLine());
int rez = 1;
int[] arr = new int[N];
     
arr[0] = 1;
int i = 0;
while (i < N)
{
     arr[i] = i + 1;
     rez = rez * arr[i];
     i++;
}
Console.WriteLine($"Произведение чисел от 1 до {N} = {rez}");
