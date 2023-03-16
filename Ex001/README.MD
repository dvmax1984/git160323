## Задача 2: 

Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void Metod3 (int [,] array)
{
    for (int m=0; m < arrey.GetLength(0); m++)
    {
        
        for (int n=0; n < array.GetLength(1); n++)
        {
            if (n%2==0 && m%2==0)
            {
            array[m][n]=array[m][n]*array[m][n];
            }
        }

    }
Console.Write($"массив: [ " + Metod3 (array) + "]");
}

Metod3(array);
