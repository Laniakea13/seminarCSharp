// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] arr = new int[50];
int count= 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
    Console.Write(arr[i] + " ");
}
for (int j = 0; j < arr.Length; j++)
{
    if(j%2 == 1) count = count + arr[j];
    
}
Console.WriteLine();
Console.Write("Сумма чисел стоящих на нечетной позиции в массиве равна - ");
Console.Write(count);
