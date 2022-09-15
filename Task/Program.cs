// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("Введите количество элементов массива");
int Array_Size = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[Array_Size];
for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    string Array_Element = Console.ReadLine()!;
    Array[i] = Array_Element;
}
string[] New_Array = new string[Array_Size];
int j = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        New_Array[j] = Array[i];
        j++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
PrintArray(Array);
Console.WriteLine();
PrintArray(New_Array);