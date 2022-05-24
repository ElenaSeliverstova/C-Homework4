// Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[num];
int[] PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 9);
        Console.Write(array[i] + " ");
    }
    return array;
}
PrintArray(arr);
