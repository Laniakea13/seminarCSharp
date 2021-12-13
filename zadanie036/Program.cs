// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] arr = new int[20];
int countEvent = 0;
int couuntNotEvent = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(99, 1000);
    Console.Write(arr[i] + " ");
}
for (int j = 0; j < arr.Length; j++)
{
    if(arr[j] % 2 ==0) countEvent = countEvent + 1;
    else couuntNotEvent = couuntNotEvent +1;
}
Console.WriteLine();
Console.Write($"Массив содержит {countEvent} четных чисел, а нечетных - ");
Console.WriteLine(couuntNotEvent);