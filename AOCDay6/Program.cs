/*
 * store the timers in a list
 * iterate through the amount of timers
 * reduce each timer by 1. If timer is 0, reset to 6 and create a new fish at 8 at end of list
 * find out how many lanternfish there would be after 80 days
 */

var input = File.ReadAllText(@"C:\Users\cwkam\development\Advent of Code\AOCDay6\AOCDay6.txt");
var timers = input.Split(",").Select(int.Parse).ToList();

for (var day = 0; day < 80; day++)
{
    for (var i = timers.Count - 1; i >= 0; i--)
    {
        if (timers[i] > 0)
        {
            timers[i]--;
        }
        else if (timers[i] == 0)
        {
            timers[i] = 6;
            timers.Add(8);
        }
    }
}
Console.WriteLine(timers.Count);