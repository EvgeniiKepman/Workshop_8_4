// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.WriteLine("Введите колличество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество рядов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите глубину массива: ");
int l = int.Parse(Console.ReadLine());

int[,,] matrix = new int[m, n, l];

Console.WriteLine($"Массив размером {m}, {n}, {l}: ");

CreateArray(matrix);
PrintArray(matrix);

void PrintArray (int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write( $"{matrix[i,j,k]} ({i}, {j}, {k}); ");
      }
      Console.WriteLine();
    }
  }
}

void CreateArray(int[,,] matrix)
{
  int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < matrix.GetLength(0); m++)
  {
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
      for (int l = 0; l < matrix.GetLength(2); l++)
      {
        matrix[m, n, l] = temp[count];
        count++;
      }
    }
  }
}
