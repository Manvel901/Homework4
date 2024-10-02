// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
int[] ArrayRandomXXXDigits(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i =0; i < size; i++)
    {
         array[i] = rnd.Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write($"[");
    for(int i = 0; i<array.Length; i++)
    {
        if(i<array.Length-1)
        {
            Console.Write($"{array[i]} ,");
        }
        else
        {
             Console.Write($"{array[i]}");
        }
    }
    Console.Write($"]");
}

int CountnumberEven(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j]%2==0)
        {
            count= count + 1;
        }
    }
    return count;
}
int[] arr =  ArrayRandomXXXDigits(10, 100, 1000);
PrintArray(arr);
int cto = CountnumberEven(arr);
Console.WriteLine($"=>  {cto} ");