// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = CreatArray(10, 1, 10);
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

int sumEvenNumbersArray = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sumEvenNumbersArray = sumEvenNumbersArray + array[i];
    }

}

System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях равна {sumEvenNumbersArray}");