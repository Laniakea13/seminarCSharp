// Показать двумерный массив размером m×n заполненный целыми числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matr)
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



int [,] matr = new int[5,6];

FillArray(matr);
PrintArray(matr);
Console.WriteLine();