/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */


/* Метод создает новый массив размерности, соответствующей количеству элементов заданой длины, 
заполняет его и возвращает */
string[] ArrayOfElementsGivenLength(string[] array, int maxElementLength)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxElementLength) count++;
    }

    string[] newArray = new string[count];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxElementLength)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

/* Метод выводит массив в консоль */
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}    ");
    }
}

Console.Write("Введите массив через запятую: ");
string enter = Console.ReadLine();
Console.Write("Укажите максимальное количество символов для элемента нового массива: ");
int elementLength = Convert.ToInt32(Console.ReadLine());
string[] massive = enter.Split(",");

string[] newMassive = ArrayOfElementsGivenLength(massive, elementLength);
Console.WriteLine($"Массив из элементов не более {elementLength}-х символов: ");
PrintArray(newMassive);
