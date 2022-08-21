// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetMatrix1(int m, int n)
{
  int[,] matrix = new int[m, n];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(1, 5);
    }
  }
  return matrix;
}

int[,] GetMatrix2(int m, int n)
{
  int[,] matrix = new int[m, n];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(1, 5);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == 0) Console.Write("[");
      if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
      else Console.Write($"{array[i, j],3}]");
    }
    Console.WriteLine();
  }
}

int[,] firstMatrix = GetMatrix1(2, 2);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = GetMatrix2(2, 2);
PrintMatrix(secondMatrix);
Console.WriteLine();

int[,] GetMatrix3(int m, int n)
{
  int[,] matrix = new int[m, n];
  return matrix;
}
int[,] resultMatrix = GetMatrix3(2, 2);

void multiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  int sum = 0;

  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      for (int k = 0; k < resultMatrix.GetLength(1); k++)
      {
        sum = sum + firstMatrix[i, k] * secondMatrix[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
}

multiplicationMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);