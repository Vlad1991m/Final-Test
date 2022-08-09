string[] CreateArray(int size) 
{
    string[] arrayA = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        arrayA[i] = Convert.ToString(Console.ReadLine());
    }
    return arrayA;
}

string[] stringselect(string[] arrayB)  
{
    int count = 0;
    string[] newArray = new string[arrayB.Length];
    for (int i = 0; i < arrayB.Length; i++)
    {
        if (arrayB[i].Length <= 3)
        {
            newArray[count] = arrayB[i];
            count++;
        }
    }
    return newArray;
}

void ShowArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

Console.WriteLine("Введите размер массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(elements);
string[] newArray = stringselect(myArray);
ShowArray(myArray);
Console.Write("--> ");
ShowArray(newArray);