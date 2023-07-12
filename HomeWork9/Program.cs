internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Введите число N: ");
        int number = Convert.ToInt32(Console.ReadLine());

         System.Console.WriteLine(Task64(number));

         System.Console.Write("Введите число M2: ");
         int secondM = Convert.ToInt32(Console.ReadLine());

         System.Console.Write("Введите число N2: ");
         int secondN = Convert.ToInt32(Console.ReadLine());
         int summ = 0;

         System.Console.WriteLine(Task66(secondM, secondN,summ));

         System.Console.WriteLine("Функция Аккермана");
         Console.Write("Введите значение M: ");
         int m = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите значение N: ");
         int n = Convert.ToInt32(Console.ReadLine());
         Console.Write($"Функция Аккермана равно {akkerman(m, n)}");


    }
    static int Task64 (int number)
    {
         if (number == 1) return 1;
       
         System.Console.WriteLine(number);

        return Task64(number - 1);
    }

    static int Task66 (int numberM , int numberN, int summ)
    {
        for (int i = numberM; i <= numberN; i++)
        {
            summ +=  i;
        }
            return summ;
    }
static int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return akkerman(m - 1, 1);
    else return akkerman(m - 1, akkerman(m, n - 1));
}

}