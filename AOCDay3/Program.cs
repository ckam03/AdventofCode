/*
 * Read the text file and store into an array and loop through the lines
 * convert to char array 
 */
var input = File.ReadAllLines(@"C:\Users\cwkam\development\Advent of Code\AOCDay3\AOCDay3.txt");
var zeros = new int[12];
var ones = new int[12];
foreach (var line in input)
{
    for (var i = 0; i < line.Length; i++)
    {
        if (line[i] == '0')
        {
            zeros[i]++;
        }
        else
            ones[i]++;
    }
}
var gamma = "";
var epsilon = "";
for (var i = 0; i < ones.Length; i++)
{
    if (ones[i] > zeros[i])
    {
        gamma += "1";
        epsilon += "0";
    }
    else
    {
        epsilon += "1";
        gamma += "0";
    }
}
Console.WriteLine(Convert.ToInt64(gamma, 2) * Convert.ToInt64(epsilon, 2));

void PartTwo()
{
    //check first bit, keep only the numbers that have the most common value as first number
    var data = new List<int>();
    var zerostwo = new int[12];
    var onestwo = new int[12];

    foreach (var line in input)
    {
        for (var i = 0; i < line.Length; i++)
        {
            if (line[i] == '0')
            {
                zerostwo[i]++;
            }
            else
                onestwo[i]++;
        }
    }

    for (var i = 0; i < onestwo.Length; i++)
    {
        if (onestwo[i] > zerostwo[i])
        {
            data.Add(onestwo[i]);
        }
        else
            data.Add(zerostwo[i]);
    Console.WriteLine(data[i]);
    }
}

PartTwo();



