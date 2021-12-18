// Показать двумерный массив размером m×n заполненный вещественными числами
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(new Random().Next(1,10) + new Random().NextDouble(),2);  
        }
    }
}
void PrintArray(double[,] matr)
{
   for(int i=0; i<matr.GetLength(0); i++)
   {
       for (int j=0; j< matr.GetLength(1); j++)
       {
           Console.Write($"{matr[i,j]}");
       }
       Console.WriteLine();
   }
}

Console.WriteLine("Введите значение m -");
int m= int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение n -");
int n= int.Parse(Console.ReadLine());


double[,] matr = new double[m,n];

FillArray(matr);
PrintArray(matr);
Console.WriteLine();