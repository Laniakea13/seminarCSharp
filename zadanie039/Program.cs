// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int N = 10;
int[] arr = new int[N];
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
for (int j = 0; j <= (N/2+1); j++)
{
    sum = arr[j] + arr[N-1]; 
    N = N - 1;
    Console.Write(sum + " ");
}

