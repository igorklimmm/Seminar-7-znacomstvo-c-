// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void FillArrayRandomNumbers (int [,] matrix, int m, int n)
{

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        matrix[i,j] = new Random().Next (0, 10);
        Console.Write(matrix [i,j] + "\t");  
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер двумерного массива (вертикаль): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер двумерного массива (горизонталь): ");
int n = Convert.ToInt32(Console. ReadLine());
Console.WriteLine("Ваш двумерный массив");

int[,] matrix = new int[n, m];
FillArrayRandomNumbers (matrix, m, n);
Console.WriteLine("Среднее значение: ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / n;
    
    Console.Write(avarage + "; ");
}





