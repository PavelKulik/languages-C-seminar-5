internal partial class Program_2
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

        int SumElement(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i = i + 2)
                sum += array[i];
            return sum;
        }

        int [] array = GetArray(5, 1, 30);
        PrintArray(array);
        Console.WriteLine($" -> {SumElement(array)}");
    }
}