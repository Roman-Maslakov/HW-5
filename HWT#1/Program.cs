/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.WriteLine("Создайте массив размером m*n");
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

PrintDuoArray(CreateDoubleArray(m, n));

double[,] CreateDoubleArray(int x, int y)
{
    double[,] arrayDuo = new double[x, y];
    int maxNumber = 10; //ввел диапозон
    int minNumber = -10;
    for (int i = 0; i < arrayDuo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDuo.GetLength(1); j++)
            arrayDuo[i, j] = Math.Round(new Random().NextDouble() * (maxNumber - minNumber) + minNumber, 1);
    }
    return arrayDuo;
}

void PrintDuoArray(double[,] duoArr)
{
    for (int i = 0; i < duoArr.GetLength(0); i++)
    {
        for (int j = 0; j < duoArr.GetLength(1); j++)
            Console.Write($"{duoArr[i, j]} ");
        Console.WriteLine();    
    }
}