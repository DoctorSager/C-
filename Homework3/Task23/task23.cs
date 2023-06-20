internal partial class Program
{
    private static void TaskTwentyThree(string[] args)
    {
        System.Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; Math.Pow(i,3))
        {
            System.Console.WriteLine(i);
        }

    }
}