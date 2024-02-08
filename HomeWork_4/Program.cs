/*
    Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
    Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/
// Условие: Взять число проверить его на четность

int GetArrayFrCons() // Функция чтения цифр из консоли
{
    Console.Write("Enter number: ");
    int size = int.Parse(Console.ReadLine()!);
    return size;
}
void PrintArray(int digit) //  Функция для вывода текста на экран
{
    Console.Write("[ ");
    Console.Write(digit + " ");
    Console.WriteLine("]");
}
int ParityCheck(int size) // Функция изменения массива в цифру
{
    while (true)
    {
        
        //System.Console.WriteLine(size);
        if (size % 2 == 0)
        {
            System.Console.WriteLine("Число чётно!");
            break;
        }
        size = GetArrayFrCons();        
    }
    int num = 1;
    return num;
}





//PrintArray(digit); // Передача в функцию аргументов для печати
