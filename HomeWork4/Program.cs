internal class Program
{
    private static void Main(string[] args)
    {
        
        
    }
    

}


internal partial class Task25
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("введите возводимое в степень число: ");
        double numberForUp = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("введите степень возведения: ");
         double upNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(Pow(numberForUp, upNumber));
        
    }
    static double Pow (double number, double upNumber) 
    {
     double resoult = Math.Pow(number, upNumber);
         return resoult;
    }

}


internal class Task27
{
    private static void Main(string[] args)
    {
         int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
            Console.WriteLine(s);

    }
    

}
*/