// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] array = CreatArray(15, 1, 999);
int[] CreatArray(int size, int minValue, int maxValue) // Создание массива
{
    int[] result = new int[size]; // Создание массива на size элементов
    for (int i = 0; i < result.Length; i++) 
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; // Вернули массив на size элементов, заполненный числами
    // от minValue до maxValue
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");
int evenNumbers = 0;
for(int i=0; i< array.Length;i++)
{
    if(array[i]%2 == 0)
    {
        evenNumbers++;
    }

}
System.Console.WriteLine($"Количество четных чисел в массиве = {evenNumbers} ");