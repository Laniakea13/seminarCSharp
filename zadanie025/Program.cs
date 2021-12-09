// Найти сумму чисел от 1 до А
Console.WriteLine("Укажите чему будет ровняться А -");
int A = int.Parse(Console.ReadLine());

int[] arr = new int[A];
     
arr[0] = 1;
int i = 0;
while (i < A)
{
     arr[i] = i + 1;
     i++;
}

int sum = arr.Sum();
Console.WriteLine("Сумма чисел от 1 до А = " + sum);

/*i = 0;
while (i < arr.Length)
{
     Console.Write(arr[i] + " ");
     i++;
}
i = 0;
*/