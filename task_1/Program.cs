internal class Program
{
    private static void Main(string[] args)
    {
        int[] GetArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(minValue, maxValue);
            }

            return array;
        }

        void PrintArray(int[] array)
        {
            Console.Write($"[{String.Join(", ", array)}]");
        }

        int CountPositive(int[] array)
        {
            int count = 0;
            foreach (int el in array)
            {
                if (el % 2 == 0)
                    count++;
            }
            return count;
        }

        int[] array = GetArray(4, 100, 1000);
        int count = CountPositive(array);
        PrintArray(array);
        Console.WriteLine($" -> {count}");
    }
}