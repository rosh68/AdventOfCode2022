//day 3 elves code https://adventofcode.com/2022/day/3

var lines = File.ReadAllLines("input.txt");

var groups = new List<List<string>>();
groups.Add(new List<string>());
var counter = 0;
foreach (var line in lines) {
    if (counter >= 3) {
        groups.Add(new List<string>());
        counter = 0;
    }

    groups[^1].Add(line);
    counter++;
}

var total = groups.Select(group => group[0].First(x => group[1].Contains(x) && group[2].Contains(x)))
    .Select(common => CharToPriority(common)).Sum();


Console.WriteLine(total);

int CharToPriority(char input) {
    if (char.IsUpper(input)) {
        return input - 38;
    }

    return input - 96;
}