// определяем массив и добавляем метод

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//              0  1  2  3  4  5  6  7  8
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[0] = 12;                                 // меняем в массиве значение 1 на значение 12 под нулевым индексом
Console.WriteLine(array[5]);                   // считываем значение из массива под требуемым индексом



