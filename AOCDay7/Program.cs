/*
 *iterate through the data
 *find a horizontal position to align all positions on that use the least amount of fuel
 * choose a number then find the difference between them and add all the differences at the end
 * Do that for every number then find the lowest sum
 */
var fuel = 0;
//var positions = new int[] {16,1,2,0,4,2,7,1,2,14};
var input = File.ReadAllText(@"C:\Users\cwkam\development\Advent of Code\AOCDay7\AOCDay7.txt");
var positions = input.Split(",").Select(int.Parse).ToList();

