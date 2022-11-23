﻿// Написать программу, которая из имеющегося массива строк сформирует массив из строк , длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreateArrayString(int num)
{
    var array = new string[num];

    for (int i = 0; i < array.Length; i++)
    {
        string row = Console.ReadLine();
        array[i] = row;

    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

string[] FilterArrayThreeChars(string[] arr)
{
    var arrayFilter = new string[arr.Length];
    for (int i = 0; i < arrayFilter.Length; i++)
    {
        if (arr[i].Length <= 3) arrayFilter[i] = arr[i];
    }
    return arrayFilter;
}

Console.WriteLine("Задайте количество элементов в массиве: ");
int numOfrRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение элемента массива (строку из символов): ");
string[] arrayOfRows = CreateArrayString(numOfrRow);
Console.WriteLine("Первоначальный массив: ");
PrintArray(arrayOfRows);


string[] arrayFilter = FilterArrayThreeChars(arrayOfRows);
Console.WriteLine("Отфильтрованный массив : ");
PrintArray(arrayFilter);
