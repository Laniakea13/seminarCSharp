// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] arr = new int[9];
int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(- 9, 10);
    Console.Write(arr[i] + " ");
    if(arr[i] >= 0) sumPlus = arr[i] + sumPlus;
    else sumMinus = arr[i] + sumMinus;
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {sumPlus}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumMinus}");