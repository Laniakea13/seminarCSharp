// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] arr = new int[123];
int count= 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 1000);
    Console.Write(arr[i] + " ");
}
for (int j = 0; j < arr.Length; j++)
{
    if(arr[j] > 10 & arr[j] < 99) count = count + 1;
}
Console.WriteLine();
Console.Write("Массив совержит следующее количество элементов из отрезка [10,99] - ");
Console.Write(count);