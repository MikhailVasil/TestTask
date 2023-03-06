Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array elements: ");
string[] array = ArrayFiling(size);

int size1 = SearchNewArrayLength(array);
string[] newArray = SortArray(array, size1);
Console.Write(PrintingArray(array));
Console.Write(" -> ");
Console.WriteLine(PrintingArray(newArray));

string[] ArrayFiling(int size) // Задаём массив длинной size
{
    string[] array = new string [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int SearchNewArrayLength(string[] array) // Ищем длинну обработанного массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i] != "") count++;
    }
    return count;
}
string[] SortArray(string[] array, int size) // Сортируем массив по условию задачи
{
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i] != "")
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

string PrintingArray(string[] arr) // Вывод массива в консоль
{
    string array = ($"[\"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($"\", \"{arr[i]}");
    }
    array = array + ($"\"]");
    return array;
}
