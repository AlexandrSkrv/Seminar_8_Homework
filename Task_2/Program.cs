// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int m, int n)
{
  int[,] matrix = new int[m, n];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(1, 10);
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
int[,] matrixResult = GetMatrix(4, 4);
PrintMatrix(matrixResult);





int sumStringNum(int[,] matrixResult, int i)
{
  int sumString = matrixResult[i, 0];
  for (int j = 1; j < matrixResult.GetLength(1); j++)
  {
    sumString = sumString + matrixResult[i, j];
  }
  return sumString;
}

int sumString = sumStringNum(matrixResult, 0);

void result(int[,] matrixResult)
{
  int minSumString = 0;
  for (int i = 1; i < matrixResult.GetLength(0); i++)
  {
    int SumString = sumStringNum(matrixResult, i);
    if (sumString > SumString)
    {
      sumString = SumString;
      minSumString = i;
    }
  }

  Console.WriteLine($"{minSumString + 1} - строкa с наименьшей суммой ({sumString}) элементов ");
}

result(matrixResult);


