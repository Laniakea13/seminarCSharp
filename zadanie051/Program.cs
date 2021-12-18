// Задать двумерный массив следующим правилом: Aₘₙ = m+n (элемент должен быть равен сумме индексов)
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i+j; 
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

Console.Write("Введите значение m -");
int m= int.Parse(Console.ReadLine());

Console.Write("Введите значение n -");
int n= int.Parse(Console.ReadLine());


double[,] matr = new double[m,n];

FillArray(matr);
PrintArray(matr);
Console.WriteLine();
