/*
        Задание 3. Заполните массив на N (вводится с консоли, не более 8)
    случайных целых чисел от 0 до 9.
    Сформируйте целое число, которое будет состоять из цифр из
    массива. Старший разряд числа находится на 0-м индексе,
    младший – на последнем.
*/


int[] GetArrayFrCons() // Функция чтения цифр из консоли
{
    Console.Write("Enter Size<8: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);

    }
    return array;
}

int ConvertDigToInt(int[] array) // Функция изменения массива в цифру
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int tmpResult = array[i] * (int)Math.Pow(10, array.Length - i - 1);
        res += tmpResult;
    }
    return res;
}
void PrintArray(int[] array) //  Функция для вывода текста на экран
{
    Console.Write("[ ");
    foreach (int namber in array)
    {
        Console.Write(namber + " ");
    }
    Console.WriteLine("]");
}

int[] array = GetArrayFrCons();
PrintArray(array); // Передача в функцию аргументов для печати
System.Console.WriteLine($"результат {ConvertDigToInt(array)}");