// Метод заполнения m и n, размер 10х10 задается ранее
public static class Library2
{
    public static int[,] FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; i < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(0, 99);
            }
        }
        return arr;
    }
}