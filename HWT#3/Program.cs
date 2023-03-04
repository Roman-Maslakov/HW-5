/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

double[,] ourArray = CreateDoubleArray(6, 5);
PrintDuoArray(ourArray);
Console.WriteLine("Среднее арифметическое каждого столбца: " + ArithmeticMean(ourArray));

double[,] CreateDoubleArray(int x, int y)
{
    double[,] arrayDuo = new double[x, y];
    for (int i = 0; i < arrayDuo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDuo.GetLength(1); j++)
            arrayDuo[i, j] = new Random().Next(10);
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

string ArithmeticMean(double[,] arr)
{
    double[] meanValue = new double[arr.GetLength(1)];
    int meanValueIndex = 0;
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        meanValue[meanValueIndex] = Math.Round(sum / arr.GetLength(0), 1, MidpointRounding.ToZero);
        meanValueIndex++;
        sum = 0;
    }
    return (String.Join("; ", meanValue) + ".");
}