// В двумерном массиве n×k заменить четные элементы на противоположные
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
            if(matr[i,j] % 2 == 0) matr[i,j] = matr[i,j] * -1;
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
