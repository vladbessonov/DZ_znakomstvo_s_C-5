// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Функция создания случайного одномерного массива:
int [] CreateNumbersArray() 
{
    int[] array = new int[6]; // размерность массива 6 (для удобства...)
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) // заполнение массива в цикле
    {
        array[i] = rnd.Next(100, 1000); // заполнение массива случайными положительными трёхзначными числами. 
    }
    return array;
}
void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int CheckAnEven(int[] array) // функция определения количества четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] numbersArray = CreateNumbersArray();
PrintArray(numbersArray, "Массив:");
Console.WriteLine("Количество четных чисел в массиве:");
Console.WriteLine(CheckAnEven(numbersArray));






