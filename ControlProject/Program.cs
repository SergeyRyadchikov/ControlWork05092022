/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

Console.Write("Введите массив через запятую: ");
string enter = Console.ReadLine();
Console.Write("Укажите максимальное количество символов для элемента нового массива: ");
int maxElementLength = Convert.ToInt32(Console.ReadLine());
string[] mass = enter.Split(",");
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].Length <= maxElementLength) count++;
}

string[] newMass = new string[count];

int index = 0;
for (int j = 0; j < mass.Length; j++)
{
    if (mass[j].Length <= 3)
    {
        newMass[index] = mass[j];
        index++;
    }
}

for (int i = 0; i < newMass.Length; i++)
{
    Console.Write($"{newMass[i]}    ");
}