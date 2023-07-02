using System.Collections.Concurrent;

internal class Program
{
    private static void Main(string[] args)
    {
        double[] array = new double[5];
        Random rnd = new Random();
        
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.NextDouble() * (10.00 + 0.01) - 0.01;
            array[i] = Math.Round(array[i],2);
        
            System.Console.WriteLine(array[i]);
        }
        double sum  = array.Min() + array.Max();
        sum = Math.Round(sum,2);
       System.Console.WriteLine(sum);
    }
}