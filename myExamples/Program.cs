namespace MyExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("\n======================\nDuplicate Counter\n======================");
            // DuplicateCounter.Run();

            // Console.WriteLine("\n======================\nTranslator\n======================");
            // Translator.Run();

            int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 5 };
            Dictionary<int, int> duplicates = CountDuplicates(numbers);

            // Print the count of duplicates
            foreach (var kvp in duplicates)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"{kvp.Key} appears {kvp.Value} times.");
                }
            }
        }
    }
}