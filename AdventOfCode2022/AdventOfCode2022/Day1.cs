//day 1 elves code https://adventofcode.com/2022/day/1

var lines = File.ReadAllLines("input.txt");
var elves = new List<int> {0};

foreach (var line in lines)
{
    if (string.IsNullOrWhiteSpace(line))
    {
        elves.Add(0);
        continue;
    }
    var elf = int.Parse(line);
    elves[^1] += elf;
}

var largest = elves.Max();
Console.WriteLine(largest);

elves.Sort();
var top3 = 0;
for (var i = 1; i <= 3; i++)
{
    top3 += elves[^i];
}
Console.WriteLine(top3);
