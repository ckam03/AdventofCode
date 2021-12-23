/*Each player rolls 3 times and moves the sum of the 3 rolls
 * Add the space it lands on to total score so if player lands on 2, add 2
 * Wrap around to 1 after 10
 * if player1 has turn then roll 3 times
 * Move to new position then add score
 * else player 2 does that
 */

using AOCDay21;


var rolls = 0;
var dice = 0;
var PlayerOne = new Player(6, 0);
var PlayerTwo = new Player(9, 0);

var p1 = 0;
var p2 = 0;


while (true)
{
    p1 = 0;
    p2 = 0;
    for (var i = 0; i < 3; i++)
    {
        RollDice();
        p1 += dice;
    }

    PlayerOne.Position = (PlayerOne.Position + p1 - 1) % 10 + 1;
    PlayerOne.Score += PlayerOne.Position;

    for (var i = 0; i < 3; i++)
    {
        RollDice();
        p2 += dice;
    }

    PlayerTwo.Position = (PlayerTwo.Position + p2 - 1) % 10 + 1;
    PlayerTwo.Score += PlayerTwo.Position;

Console.WriteLine($"{PlayerOne.Score}, {PlayerTwo.Score}");
    if (PlayerOne.Score >= 1000)
    {
        break;
    }
    if (PlayerTwo.Score >= 1000)
    {
        break;
    }
}
Console.WriteLine(1005 * 921);
//Console.WriteLine(PlayerTwo.Score);

//do
//{
//    p1 = 0;
//    p2 = 0;
//    for (var i = 0; i < 3; i++)
//    {
//        RollDice();
//        p1 += dice;
//        rolls++;
//        //Console.WriteLine(p1);
//    }
//    //Console.WriteLine(p1);
//    PlayerOne.Position = (PlayerOne.Position + p1 - 1) % 10 + 1;
//    PlayerOne.Score += PlayerOne.Position;

//    for (var i = 0; i < 3; i++)
//    {
//        RollDice();
//        p2 += dice;
//        rolls++;
//    }
//    PlayerTwo.Position = (PlayerTwo.Position + p2 - 1) % 10 + 1;
//    PlayerTwo.Score += PlayerTwo.Position;
//    //Console.WriteLine(PlayerTwo.Position);
//} while (PlayerOne.Score < 1000 && PlayerTwo.Score < 1000);
//Console.WriteLine(PlayerOne.Score);
//Console.WriteLine(PlayerTwo.Score);
//Console.WriteLine(rolls);
void RollDice()
{
    rolls++;
    if (dice < 100)
    {
        dice++;
    }
    else
        dice = 1;
}

