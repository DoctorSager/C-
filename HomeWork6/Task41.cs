/* 
internal class Task41
{
    private static void Main(string[] args)
    {
        Console.Write("Введите числа чеерез пробел: ");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                 {
                    count++;
                 }
        }

        Console.WriteLine("Cумма положительных чисел" + count);
    }
}
*/