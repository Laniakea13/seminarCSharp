// Задать массив из 8 элементов и вывести их на экран
int[] arr= new int[8];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 999);
    Console.Write(arr[i] + " ");

}
