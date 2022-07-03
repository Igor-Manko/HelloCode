// Создание методов рандомного заполнения, затем поочередного вывода массива

void FillArray(int[] collection)  // метод FillArray заполнения массива аргумент collection
{
    int length = collection.Length;                    // задали длинну массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);   // до тех пор пока выполняется цикл заполняй массив рандомно
        index++;
    }
}

void PrintArray(int[] col)         // метод последовательной печати заполненного рандомного массива
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)   // функция поиска индекса элемента массива равный find
{
    int count = collection.Length;
    int index = 0;
    int position = -1;             // ставим -1 для визуального понимания в случае отсутствия результата
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 7);
Console.WriteLine(pos);