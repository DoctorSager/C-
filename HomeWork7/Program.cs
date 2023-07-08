internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число строк m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random= new();

        int[,] array = new int[m,n];

        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;

        for (int i = 0; i < rows; i++)
        {

            for (int j = 0; j < columns; j++)
                {
                    int value = random.Next(0, 100);
                    array[i,j] = value;
                    Console.Write($"{array[i, j]} \t");

                }
            Console.WriteLine();
        }
        Console.Write("Введите номер строки которое необходимо найти: ");
        int numberOfRow = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Введите номер ряда: ");
        int numberOfColumn = Convert.ToInt32(Console.ReadLine());

        try
        {
            System.Console.WriteLine(array[numberOfRow,numberOfColumn]);
        }
        catch (Exception)
        {
            System.Console.WriteLine($"Элемента по адресу {numberOfRow},{numberOfColumn} в массиве нет");
        }

         for (int i = 0; i < n; i++) 
            {
                int srAr = 0;
                
                for (int t = 0; t < m; t++)
                {
                    srAr += array[t, i];
                    
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {srAr/m}");
            }
        }
      

        }
        
    


     
            
            

    
        





       
    
