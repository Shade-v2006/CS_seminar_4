/*
        Задайте массив из N случайных чисел (N вводится с клавиатуры).
    Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
*/

int[] GetRandomArrayFromConsole() //  Функция для ввода числа с консоли и принятие ее как число элементов массива
{
    Console.Write("Size: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100 + 1); // Добавляем 1 для того чтоб было именно до 100
    }
    return array;

}
int checkeQuality(int[] array) //  Функция для проверки чисел, которые оканчиваются на 1 и делятся нацело на 7.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1)
        {
            if (array[i] % 7 == 0)
                count++;
        }
    }
    return count;
}
void PrintArray(int[] array) //  Функция для вывода текста на экран
{
    Console.Write("[");
    foreach (int namber in array)
    {
        Console.Write(namber + " ");
    }
    Console.WriteLine("]");
}

//int[] array = { 21, 22, 91, 33, 345 };
int[] array = GetRandomArrayFromConsole(); // Передача в массив аргументов введенных с клавиатуры
PrintArray(array); // Передача в функцию аргументов для печати
System.Console.WriteLine($"результат: {checkeQuality(array)}");