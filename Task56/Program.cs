// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.Clear();
Console.WriteLine($"\nВведите размер массива row x col и диапазон случайных значений:");
int row = InputNumbers("Введите row: ");
int col = InputNumbers("Введите col: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] matrix = new int[row, col];
CreateArray(matrix);
WriteArray(matrix);

int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0) ; i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i,j],3} " + " ");
    }
    Console.WriteLine();
  }
}