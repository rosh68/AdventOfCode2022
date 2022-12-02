//day 2 elves code https://adventofcode.com/2022/day/2


var lines = File.ReadAllLines("input.txt");
var score = 0;

foreach (var line in lines)
{
    var enemyMove = (Move) line[0] - 65;
    var gameState = (GameState) line[2] - 88;
    //Console.WriteLine(" enemy move " + enemyMove.ToString() + " player move " + playerMove.ToString());

    if (gameState == GameState.LOSE)
    {
        if (enemyMove == Move.ROCK)
        {
            score += 3;
        }
        else if (enemyMove == Move.PAPER)
        {
            score += 1;
        }
        else if (enemyMove == Move.SCISSORS)
        {
            score += 2;
        }
    }
    else if (gameState == GameState.DRAW)
    {
        score += 3;
        if (enemyMove == Move.ROCK)
        {
            score += 1;
        }
        else if (enemyMove == Move.PAPER)
        {
            score += 2;
        }
        else if (enemyMove == Move.SCISSORS)
        {
            score += 3;
        }
    }
    else if (gameState == GameState.WIN)
    {
        score += 6;
        if (enemyMove == Move.ROCK)
        {
            score += 2;
        }
        else if (enemyMove == Move.PAPER)
        {
            score += 3;
        }
        else if (enemyMove == Move.SCISSORS)
        {
            score += 1;
        }
    }
}

Console.WriteLine(score);

enum Move
{
    ROCK,
    PAPER,
    SCISSORS
}

enum GameState
{
    LOSE,
    DRAW,
    WIN
}