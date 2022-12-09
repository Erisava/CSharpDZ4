// Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

int [] array = new int [8]; // целочисленный массив
void PrintArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.WriteLine(array[i]);
    }
}
PrintArray(array);









