// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



int[,] CreateMatrixSumIndex(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];

    for (int i =0; i < rows; i++) // matrix.GetLength(0)
    {
        for (int j = 0; j < colums; j++) // matrix.GetLength(1)
        {
            matrix[i,j] = i+j;  
        }
    }
    return matrix;
}

void PrintMatrixInt(int[,] arr) //Метод, который выводит массив
{
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j], 5} "); // формат вывода в 5 символов
        }
        Console.WriteLine(" |");
    }
  
}

int[,] matrix2d = CreateMatrixSumIndex(3,4);
PrintMatrixInt(matrix2d);