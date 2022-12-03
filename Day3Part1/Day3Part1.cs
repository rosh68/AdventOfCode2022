//day 3 elves code https://adventofcode.com/2022/day/3

var lines = File.ReadAllLines("input.txt");
var total = (from line in lines
    let half = line.Length / 2
    let part1 = line[..half]
    let part2 = line[half..]
    select part1.First(part2.Contains)
    into match
    select CharToPriority(match)).Sum();

Console.WriteLine(total);

int CharToPriority(char input) {
    if (char.IsUpper(input)) {
        return input - 38;
    }

    return input - 96;
}