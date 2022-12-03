//day 3 elves code https://adventofcode.com/2022/day/3

var lines = File.ReadAllLines("input.txt");
var total = 0;

foreach (var line in lines) {
    var half = line.Length / 2;
    var part1 = line[..half];
    var part2 = line[half..];
    
    
    //Console.WriteLine("part 1 " + part1 + " part 2 " + part2);
}

int CharToPriority(char input) {
    if (Char.IsUpper(input)) {
        return input - 38;
    }
    return input - 96;
}