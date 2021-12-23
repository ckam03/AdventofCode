var input = File.ReadAllLines(@"C:\Users\cwkam\development\Advent of Code\AOCDay1\AOCDay1.txt");
var intInput = input.Select(x => int.Parse(x)).ToArray();
var count = 0;
var previous = 0;
for (var i = 0; i < intInput.Length; i++)
{
    if (intInput[i] != intInput.First() && intInput[i] > previous)
    {
        count++;
    }
    previous = intInput[i];
}
Console.WriteLine(count);

// part 2

var tripleCount = 0;
var sums = new List<int>();
var prev = 0;

for (var j = 2; j < intInput.Length; j++)
{
    sums.Add(intInput[j] + intInput[j - 1] + intInput[j - 2]);
}
    for (var i = 0; i < sums.Count; i++)
    {       
        if (sums[i] != sums.First() && sums[i] > prev)
        {
            tripleCount++;
        }
        prev = sums[i];
    }
Console.WriteLine(tripleCount);