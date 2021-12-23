/*
 * store text data in array
 * iterate through the array and check input pairs against rule and store rule letter between the pairs
 * use a stringbuilder or list to update the input
 */

using System.Text;

var inputData = File.ReadAllLines(@"C:\Users\cwkam\development\Advent of Code\AOCDay14\AOCDay14.txt");
var input = inputData.First();
var polymerMatches = new Dictionary<string, char>();
var polymer = new StringBuilder();

for (var i = 2; i < inputData.Length; i++)
{
    var inputLine = inputData[i];
    var insertedCharacter = inputLine.Length - 1;
    var pair = inputLine.Substring(0, 2);
    polymerMatches.Add(pair, inputLine[insertedCharacter]);
}

//var inputPair = " ";
//for (var j = 0; j < 10; j++)
//{
//    polymer.Clear();
//    for (var k = 0; k < input.Length - 1; k++)
//    {
//        inputPair = input.Substring(k, 2);
//        for (var l = 0; l < polymerMatches.Count; l++)
//        {
//            if (polymerMatches.ContainsKey(inputPair))
//            {
//                polymer.Append($"{inputPair[0]}{polymerMatches[inputPair]}");
//                break;
//            }
//        }
//    }
//    polymer.Append("C");
//    input = polymer.ToString();
//}
//var max = polymer.ToString().GroupBy(x => x).OrderByDescending(y => y.Count()).First().Count();
//var min = polymer.ToString().GroupBy(x => x).OrderBy(y => y.Count()).First().Count();
//Console.WriteLine(polymer.Length);
//Console.WriteLine(max - min);
//19457 Length

// part 2
/*
 * store pair counts in dictionary
 * loop through initial input and store in dictionary
 * if matches contain pair, insert character between and move to the next pair
 * if dictionary contains pair, don't add key, increment value. 
 * if dictionary does not contain pair, add new kvp
 */
var polymerDictionary = new Dictionary<string, int>();
var pairs = String.Empty;
//iterate through the input pairs
for (var k = 0; k < input.Length - 1; k++)
{
    pairs = input.Substring(k, 2);
    if (polymerMatches.ContainsKey(pairs))
    {
        polymerDictionary.Add(pairs, 1);
    }
}
//iterate the amount of steps
for (var i = 0; i < 1; i++)
{
    for (var j = 0; j < polymerMatches.Count; j++)
    {

    }
}
foreach (var p in polymerDictionary)
{
    //var total = 0;
    //total = total + p.Value;
    //Console.WriteLine(total);
    Console.WriteLine(p);
}


