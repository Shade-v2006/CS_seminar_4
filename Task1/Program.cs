//int temp = 123; // Переменная для примера ее можно изменить в функции

//**********ШАБЛОН ФУНКЦИИ******************
int Mult(int a, int b, int c) // Если нужен temp в функции его необходимо передать в неё.
{
    //temp = 2; // Но этого делать не нужно так как можно запутаться
    int res = a * b * c;
    return res;
}

Console.Clear();
int res = Mult(5, 6, 3); // в 12 и 13 строках два разных вызова фунции и они работают по разному!!!
System.Console.WriteLine(Mult(5, 3, 3));// в 12 и 13 строках два разных вызова фунции и они работают по разному!!!
System.Console.WriteLine(res);

/*
        Задайте одномерный массив, заполненный случайными
    числами. Определите количество простых чисел в этом
    массиве.
    Примеры:
    [1 3 4 19 3] => 2
    [4 3 4 1 9 5 21 13] => 3

*/

bool IsPrime(int namber) //  Функция для проверки числа простое оно или нет
{
    for (int i = 2; i < namber; i++)
    {
        if (namber % i == 0)
            return false;
    }
    return true;
}
int[] GetRandomArray(int size, int minValue, int maxValue) //  Функция для создания рандомного массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1); // Добавляем 1 для того чтоб было именно до 100
    }
    return array;
}
int[] GetArrayFromConsole() //  Функция для ввода числа с консоли
{
    Console.Write("Size: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Console.WriteLine($"Enter {size} elements:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;

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
int CountPrimeNumbers(int[] array) //  Функция для подсчета простых чисел в массиве
{
    int count = 0;
    foreach (int elem in array)
    {
        if (IsPrime(elem))
        {
            count++;
        }
    }
    return count;
}


int[] array = GetRandomArray(7, 1, 100); // Передача в функцию аргументов
PrintArray(array); // Передача в функцию аргументов для печати

int[] array2 = GetArrayFromConsole(); // Передача в массив аргументов введенных с клавиатуры
PrintArray(array2); // Передача в функцию массива для печати

System.Console.WriteLine($"результат: {CountPrimeNumbers(array)}");
System.Console.WriteLine($"результат: {CountPrimeNumbers(array2)}");