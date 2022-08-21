/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] ArrayCreation(int arrayLenth)
{
    int[] array = new int[arrayLenth];
    for (int i = 0; i < arrayLenth; i++) array[i] = new Random().Next(1, 100);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}
void SumOfOddPosition(int[] array)
{
    int rezult = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        rezult +=  array[i];                            
    }                         
    Console.Write($"Сумма элементов, стоящих на нечётных позициях = {rezult}");
}

Console.Write("Введите длину желаемого массива ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] myArray = ArrayCreation(arrayLength);
PrintArray(myArray);
SumOfOddPosition(myArray);
