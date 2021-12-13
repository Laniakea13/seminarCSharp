// Написать программу замену элементов массива на противоположные
int[] arr= new int[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-10, 10);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
for (int j = 0; j< arr.Length; j++)
{
    arr[j] = arr[j] * -1;
    Console.Write(arr[j] + " ");
}
