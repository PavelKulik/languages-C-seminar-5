internal partial class Program_3
{
    private static void Main(string[] args)
    {
        double[] GetArray(int size)
        {
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().NextDouble() * 10;
            }

            return array;
        }

        void PrintArray(double[] array)
        {
            Console.Write($"[{String.Join(", ", array)}]");
        }

        double DifferenceMaxMin(double[] array)
        {
            double max = 0;
            double min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];

                if (min > array[i])
                    min = array[i];
            }

            return max - min;
        }

        double[] array = GetArray(5);
        PrintArray(array);
        Console.WriteLine($" -> {DifferenceMaxMin(array)}");
    }
}