// определяем массив и добавляем метод

int Max(int arg1, int arg2, int arg3)         // пример функции поиска наибольшего значения из трёх групп по три числа
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//              0  1  2  3  4  5  6  7  8
int[] array = { 1, 2, 3, 4, 511, 6, 7, 81, 9 };
// array[0] = 12;                                 // меняем в массиве значение 1 на значение 12 под нулевым индексом
// Console.WriteLine(array[5]);                   // считываем значение из массива под требуемым индексом

int result = Max(                              // поиск в массиве при помощи функции Max
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);