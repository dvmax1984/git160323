## Задача 2: 

Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void Metod3 (int [,] array)
{
    for (int m=0; m < arrey.GetLenth(0); m++)
    {
        if (m%2==0)
        {
            array[m]=array[m]*array[m];
        }
        for (int n=0; n < arrey.GetLenth(0); n++)
        {
            if (n%2==0)
            {
            array[n]=array[n]]*array[n];
            }
        }

    }
Console.Write($"массив: [ " + Metod3 (array) + "]");
}

Metod3(array);
