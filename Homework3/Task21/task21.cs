internal partial class Program
{
    private static void TaskTwentyOne(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки: ");
        Console.Write("X1 = ");
        double x1 = Convert.ToDouble(Console.ReadLine());     
        Console.Write("Y1 = ");
        double y1 = Convert.ToDouble(Console.ReadLine()); 
        Console.Write("Z1 = ");
        double z1 = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Введите координаты второй точки: ");
        Console.Write("X2 = ");
        double x2 = Convert.ToDouble(Console.ReadLine()); ;
        Console.Write("Y2 = ");
        double y2 = Convert.ToDouble(Console.ReadLine()); 
        Console.Write("Z2 = ");
        double z2 = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine(Distance(x1,y1,z1,x2,y2,z2));

    }
    static double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
        return Math.Round(distance,2);
    }

}