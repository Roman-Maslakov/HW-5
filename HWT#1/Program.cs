/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//Console.WriteLine("Quantity of even numbers in created array is - " + Sort(CreateArray()));
int[] MyArr = CreateArray();
string array = String.Join(", ", MyArr);
int S = Sort(MyArr);
Console.WriteLine("[" + array + "] -> " + S);
Console.WriteLine("Sum of odd numbers in created array is - " + S);

int Fill()
{
    int n = new Random().Next(100, 1000);
    return n;
}

int Sort(int[] arr)
{
    int sort = 0;
    for (int i = 0; i < arr.Length; i++) 
        if (arr[i] % 2 == 0) sort++;
    return sort;
}

int[] CreateArray()
{
    int i = new Random().Next(4, 11); //в условии не указано кол-во элементов массива
    int[] Arr = new int[i];
    for (int j = 0; j < Arr.Length; j++) Arr[j] = Fill();
    return Arr;
}