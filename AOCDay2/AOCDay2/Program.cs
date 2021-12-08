/*
 * Read the file into array
 * loop through the array
 * Each index will probably need to be split so I can read the string and number separately
 * if line is foward, add 5 etc.
 */

int depth = 0;
int horizontalPosition = 0;

string[] inputLines = File.ReadAllLines(@"C:\Users\cwkam\development\AdventofCode\AOCDay2\AOCDay2\input.txt");

foreach (string line in inputLines)
{
    var split = line.Split(" ");
    string command = split[0];
    int value = int.Parse(split[1]);
    switch (command)
    {
        case "forward":
            horizontalPosition += value;
            break;
        case "up":
            depth -= value;
            break;
        case "down":
            depth += value;
            break;
        default:
            Console.WriteLine(command);
            break;
    }
}
Console.WriteLine($"{horizontalPosition} {depth}");

//part 2

int aim = 0;
int depthtwo = 0;
int horizontalPositiontwo = 0;
foreach(string ptwoline in inputLines)
{
    string[] ptwosplit = ptwoline.Split(" ");
    string ptwocommand = ptwosplit[0]; 
    int ptwovalue = int.Parse(ptwosplit[1]);
    switch (ptwocommand)
    {
        case "forward": // increases horizontal position by ptwovalue if aim is 0, depth does not change
            horizontalPositiontwo += ptwovalue;    
            depthtwo += aim * ptwovalue;
            break;
        case "up":
            aim -= ptwovalue;
            break;
        case "down":
            aim += ptwovalue;
            break;
        default:
            Console.WriteLine(ptwocommand);
            break;
    }
}
    Console.WriteLine($"{horizontalPositiontwo} {depthtwo}");
    Console.WriteLine(horizontalPositiontwo * depthtwo);
//1765720035
