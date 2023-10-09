// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.



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

void ReplaceEvenIndexNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] *= matrix[i,j];
        }       
    }
}

int[,] matrix2d = CreateMatrixSumIndex(3,4);
PrintMatrixInt(matrix2d);
Console.WriteLine();
ReplaceEvenIndexNumbers(matrix2d);
PrintMatrixInt(matrix2d);

