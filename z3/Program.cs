// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Функция создания случайного массива:
float [] CreateNumbersArray() 
{
    float[] array = new float[6]; // размерность массива 6 (для удобства...)
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) // заполнение массива в цикле
    {
        array[i] = rnd.Next(-99, 99); // заполнение массива числами от -99 до 99 (для удобства...)
    }
    return array;
}

// функция вывода массива на печать
void PrintArray(float[] array, string message)
{
    Console.WriteLine(message);
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine($"]");
}

// Функция определения максимального и минимального чисел в массиве
(float, float) MinMax(float[] array)
{
    float min = array[0]; // предполагаем, что начальный элемент массива минимальный
    float max = array[0]; // предполагаем, что начальный элемент массива максимальный
    for (int i = 0; i < array.Length; i++) // проверяем в цикле все элементы массива на условия мин и макс
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (min, max); // возвращаем максимальное и минимальное числа в массиве
}

// Алгоритм решения задачи посредством вышеопределенных функций:

// Создаем случайный массив:
float[] BaseArray = CreateNumbersArray();

// Печатаем этот массив:
PrintArray(BaseArray, "Массив:");

// Определяем максимальное и минимальное числа в массиве:
(float min, float max) = MinMax(BaseArray);

// Печатаем максимальное и минимальное числа в массиве:
Console.WriteLine($"В массиве Максимальное = {max}, Минимальное = {min}");

// Находим разницу между максимальным и минимальным элементом массива:
float difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {difference}");

