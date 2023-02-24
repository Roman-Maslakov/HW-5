/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] MyArr = CreateArray();
string array = String.Join(", ", MyArr);
int SON = SumOfOdd(MyArr);
Console.WriteLine("[" + array + "] -> " + SON);
Console.WriteLine("Sum of numbers with odd index in created array is - " + SON);

int[] CreateArray()
{
    int i = new Random().Next(4, 11); //в условии не указано кол-во элементов массива
    int[] Arr = new int[i];
    for (int j = 0; j < Arr.Length; j++) Arr[j] = new Random().Next(-99, 100);
    return Arr;
}

int SumOfOdd(int[] arr)
{
    int Sodd = 0;
    for (int i = 1; i < arr.Length; i += 2) Sodd += arr[i];
    return Sodd;
}