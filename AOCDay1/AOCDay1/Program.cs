// See https://aka.ms/new-console-template for more information

//read text file and store in array
//loop through array and compare values
//keep a count of how many times there are increases through the file

string[] text = File.ReadAllLines(@"C:\Users\cwkam\development\AOCDay1\AOCDay1\input.txt");
int[] textInts = Array.ConvertAll(text, t => int.Parse(t));
int count = 0;
for (int i = 0; i < textInts.Length - 1; i++)
{
    if (textInts[i+1] > textInts[i])
    {
        count++;
    }
}
Console.WriteLine(count);