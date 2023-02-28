﻿// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма.

int NumberElementsOfSpecifiedLength(string[] array, int size)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) count++;
    }
    return count;
}

string[] LeaveElementsOfSpecifiedLengthInArray(string[] array, int size)
{
    string[] newArray = new string[NumberElementsOfSpecifiedLength(array, size)];

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}