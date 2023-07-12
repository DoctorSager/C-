internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = {{3,4,5},
                         {2,3,4},
                         {7,4,2},
                         {2,3,7}};

        int sum = 0;
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            int temp = 0;
            for (int j = 0; j < 4; j++)
            {
                temp += matrix[j, i];
            }
            if (temp > sum)
            {
                sum = temp;
                index = i;
            }
        }
        Console.WriteLine("Столбец: ");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(matrix[i, index]);

        }
    }
}