// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Функция создания случайного одномерного массива:
int [] CreateNumbersArray() 
{
    int[] array = new int[4]; // размерность массива 4 (для удобства...)
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) // заполнение массива в цикле
    {
        array[i] = rnd.Next(-99, 99); // заполнение массива числами от -99 до 99 (для удобства...)
    }
    return array;
}

// функция вывода массива на печать
void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine($"]");
}
// функция нахождения суммы элементов, стоящих на нечётных позициях массива:
int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum; // возвращаем сумму
}
// Алгоритм решения задачи посредством вышеопределенных функций:

// Создаем случайный массив:
int[] BaseArray = CreateNumbersArray();

// Печатаем этот массив:
PrintArray(BaseArray, "Заданный массив:");

// Определяем сумму элементов, стоящих на нечётных позициях массива:
int Sum = SumOdd(BaseArray);

// Печатаем сумму элементов, стоящих на нечётных позициях массива:
Console.Write($"Сумма элементов, стоящих на нечётных позициях массива {Sum}");







