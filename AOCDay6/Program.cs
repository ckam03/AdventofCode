/*
 * store the timers in a list
 * iterate through the amount of timers
 * reduce each timer by 1. If timer is 0, reset to 6 and create a new fish at 8 at end of list
 * find out how many lanternfish there would be after 80 days
 */

using System.Linq;

var input = File.ReadAllText(@"C:\Users\cwkam\development\Advent of Code\AOCDay6\AOCDay6.txt");
var timers = input.Split(",").Select(int.Parse).ToList();
var fishTimers = new Dictionary<int, ulong>();
for (var i = 0; i <= 8; i++)
{
    ulong count = (ulong)timers.Where(x => x == i).Count();
    fishTimers.Add(i, count);
    Console.WriteLine(count);
}

for (var day = 0; day < 256; day++)
{
    fishTimers[9] = fishTimers[0];
    fishTimers[7] += fishTimers[0];
    fishTimers[0] = 0;
    for (var i = 0; i < fishTimers.Count - 1; i++)
    {
        fishTimers[i] = fishTimers[i + 1];
        //Console.WriteLine($"[{fishTimers.ElementAt(i).Key},{fishTimers.ElementAt(i).Value}]");
    }
}
ulong sum = 0;
foreach (var timer in fishTimers)
{
    sum += timer.Value;
}
    Console.WriteLine(sum);
    Console.WriteLine(1787530844831 - 143244770807);
//Console.WriteLine(sum);
//for (var day = 0; day < 80; day++)
//{
//    for (var i = timers.Count - 1; i >= 0; i--)
//    {
//        if (timers[i] > 0)
//        {
//            timers[i]--;
//        }
//        else if (timers[i] == 0)
//        {
//            timers[i] = 6;
//            timers.Add(8);
//        }
//    }
//}
//363101




