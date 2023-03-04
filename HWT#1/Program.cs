static int[,] CreateDoubleArray(int m, int n)
{
    int[,] arrayDuo = new int[m, n];
    for (int i = 0; i < arrayDuo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDuo.GetLength(1); j++)
            arrayDuo[i, j] = new Random().Next(2, 10);
    }
    return arrayDuo;
}

static void PrintDuoArray(int[,] duoArr)
{
    for (int i = 0; i < duoArr.GetLength(0); i++)
    {
        for (int j = 0; j < duoArr.GetLength(1); j++)
            Console.Write($"{duoArr[i, j]} ");
        Console.WriteLine();    
    }
}
