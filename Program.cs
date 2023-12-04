using AdventOfCode2023;

foreach (var i in Enumerable.Range(count: 1, start: 0)) {
    switch (i) {
        case 0:
            Console.WriteLine(value: $"Day 1: {Day1.RunPart1()}, {Day1.RunPart2()}");
            break;
        default:
            throw new NotImplementedException();
    }
}
