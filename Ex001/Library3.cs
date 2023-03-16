//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

public static class Library3
{
    public static int[,] Metod3(int[,] array)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                if (n % 2 == 0  &&  m % 2 == 0)
                {
                    array[m,n] = array[m,n] * array[m,n];
                }
            }
        }
        return array;
    }
}


