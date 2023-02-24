/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

// int[] MyArr = CreateArray();
// string array = String.Join(" ", MyArr);
// int SON = SumOfOdd(MyArr);
// Console.WriteLine("[" + array + "] -> " + SON);
// Console.WriteLine("Sum of numbers with odd index in created array is - " + SON);

int[] CreateArray(string msg, string msg2)
{
    Console.WriteLine(msg);
    int i = Convert.ToInt32(Console.ReadLine()); //в условии не указано кол-во элементов массива
    int[] Arr = new int[i];
    Console.WriteLine(msg2);
    for (int j = 0; j < Arr.Length; j++) Arr[j] = Convert.ToInt32(Console.ReadLine());
    return Arr;
}

int FindDiff(int[] A)
{
    int max = A[0];
    int min = A[0];
    foreach (int el in A)
    {
        if (el > max) max = el;
        else if (el < min) min = el;
    }
    int diff = max - min;
    return diff;
}

int[] ARRAY = CreateArray("What size of array?", "Fill it");
string array = String.Join(" ", ARRAY);
Console.WriteLine("[" + array + "] -> " + FindDiff(ARRAY));