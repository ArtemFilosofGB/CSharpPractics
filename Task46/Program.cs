// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1  4 8  19
// 5 -2 33 -2
// 77 3 8  1



int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i =0; i < rows; i++) // matrix.GetLength(0)
    {
        for (int j = 0; j < colums; j++) // matrix.GetLength(1)
        {
           matrix[i,j] = rnd.Next(min, max);  
        //matrix[i,j] = i+j;  
        }
    }
    return matrix;
}

void PrintMatrixInt(int[,] arr) //Метод, который выводит массив
{
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j], 5} "); // формат вывода в 5 символов
        }
        Console.WriteLine();
    }
  
}

int[,] matrix2d = CreateMatrixRndInt(3,4,-100,100);
PrintMatrixInt(matrix2d);