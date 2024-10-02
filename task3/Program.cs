// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

int [] ArrayDigits(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i< size ; i++)
    {
        array[i] = rnd.Next(min, max);
    } 
    return array;
}
void PrintArray(int[] array)
{
    Console.Write($"[");
    for ( int i = 0; i< array.Length; i++)
    {
        if(i<array.Length-1)
        {
            Console.Write($"{array[i]} ,");
        }
        else 
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.Write($"]");
}
int [] ArrayInverted( int[] array)
{
    for (int i = 0;i< array.Length/2 ;i++ )
    {
         int x = array[i];
         array[i]=array[array.Length - 1 -i];
         array[array.Length - 1 -i]=x;
    }
    return array;
}
void PrintArray2(int[] array)
{
    Console.Write($"[");
    for ( int i = 0; i< array.Length; i++)
    {
        if(i<array.Length-1)
        {
            Console.Write($"{array[i]} ,");
        }
        else 
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.Write($"]");
}
int [] arr = ArrayDigits(10, 10, 101);
PrintArray(arr);
int [] hoho = ArrayInverted(arr);
PrintArray(hoho);