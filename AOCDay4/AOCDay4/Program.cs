public class Program
{
    public static void Main(string[] args)
    {
        /*
         * read the text file
         * loop through the array
         * Read and loop through the drawn numbers separately
         * Check the boards for a match
         * how to check if a row and column are full?
         * After there's a winning board, find the sum of unmarked numbers on the board then multiply by the number
         * that was just called which made the board win
         */
        var text = File.ReadAllLines(@"C:\Users\cwkam\development\Advent of Code\AOCDay4\AOCDay4\AOCDay4.txt");
        var drawnNumbers = text.First();
 
        for (int i = 0; i < text.Length; i++)
        {
        }
            Console.WriteLine(text[1]);
    }
}
