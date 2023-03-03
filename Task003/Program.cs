// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Используйте NextDouble().

int[] array = CreatArrayDouble(10, 0, 1);
int[] CreatArrayDouble(int size, int minValue, int maxValue) // Создание массива
{
    int[] result = new int[size]; // Создание массива на size элементов
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().NextDouble(minValue, maxValue + 1);
    }
    return result; // Вернули массив на size элементов, заполненный числами
    // от minValue до maxValue
}
// не понял ошибку которую выдает : D:\Документ\GeekBrains\C#Seminar5(3)HomeWork\Task003\Program.cs(13,34): error CS1501: Ни одна из перегрузок метода "NextDouble" не принимает 2 аргументов. [D:\Документ\GeekBrains\C#Seminar5
// (3)HomeWork\Task003\Task003.csproj]

Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");

