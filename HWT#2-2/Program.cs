/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет */

int[,] ourArray = CreateDoubleArray(5, 5);
PrintDuoArray(ourArray);
Console.Write("Введите искомое число - ");
int num = Convert.ToInt32(Console.ReadLine());
if (FindAdress(ourArray)) Console.WriteLine(num + " -> такого числа в массиве нет");

int[,] CreateDoubleArray(int x, int y)
{
    int[,] arrayDuo = new int[x, y];
    for (int i = 0; i < arrayDuo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDuo.GetLength(1); j++)
            arrayDuo[i, j] = new Random().Next(100);
    }
    return arrayDuo;
}

void PrintDuoArray(int[,] duoArr)
{
    for (int i = 0; i < duoArr.GetLength(0); i++)
    {
        for (int j = 0; j < duoArr.GetLength(1); j++)
            Console.Write($"{duoArr[i, j]} ");
        Console.WriteLine();    
    }
}

bool FindAdress(int[,] duoArr)
{
    for (int i = 0; i < duoArr.GetLength(0); i++)
    {
        for (int j = 0; j < duoArr.GetLength(1); j++)
        {
            if (duoArr[i, j] == num) 
            {
                Console.WriteLine($"Адрес искомого числа - [{i + 1}; {j + 1}]");
                return false;
            }    
        }
    }
    return true;
}