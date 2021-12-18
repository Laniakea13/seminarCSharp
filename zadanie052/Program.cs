// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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
           Console.Write($"{matr[i,j]}  ");
       }
       Console.WriteLine();
   }
}
void EvenArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i % 2 ==0 && j % 2 == 0) matr[i,j] = matr[i,j] * matr[i,j];
        }
    }
}

Console.Write("Введите значение n -");
int n= int.Parse(Console.ReadLine());
Console.Write("Введите значение k -");
int k= int.Parse(Console.ReadLine());
Console.WriteLine();

int [,] matrix = new int[n,k];

FillArray(matrix);
PrintArray(matrix);
EvenArray(matrix);
Console.WriteLine();
PrintArray(matrix);
