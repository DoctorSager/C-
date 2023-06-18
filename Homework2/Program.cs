using System.Security.Cryptography;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число: ");
        string input = Console.ReadLine();
        Console.WriteLine("{0}->{1}",input, input[1]);
        ShowThirdNumber(input);


        Console.WriteLine("Введите цифру обозначающую день недели; ");
        int theDayOfWeek = Convert.ToInt32(Console.ReadLine());
        if(theDayOfWeek <= 5)
        {
            Console.WriteLine("Будний день");
        }
        else if(theDayOfWeek > 7)
        Console.WriteLine("Дней в неделе всего 7");
        else
        Console.WriteLine("Выходной!");
        
    }
    static void ShowThirdNumber(string input)
    {
        if(input.Length < 3)
        {
            Console.WriteLine("В числе меньше 3 знаков");
        }
        else
        Console.WriteLine("{0}->{1}",input, input[2]);
    }
    
}