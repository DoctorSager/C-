internal partial class Program
{
    private static void TaskNineTeen(string[] args)
    {
         Console.WriteLine("Введите пятизначное число: ");
        string input = Console.ReadLine();
        input.ToCharArray();

        if (input.Length > 5)
        {
            Console.WriteLine("Введено число длиннее 5 цифр");
        }
        else if (input.Length < 5)
            Console.WriteLine("Введено число короче 5 цифр");
        
        else 
        {
            if (input[0] == input[4] && input[1] == input[3])
            {
                System.Console.WriteLine($"Число {input} является полиндромом");
            }
            else
            System.Console.WriteLine($"Число {input} не является полиндромом");
        }
    }
}