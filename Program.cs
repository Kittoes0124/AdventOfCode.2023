using AdventOfCode2023;

foreach (var i in Enumerable.Range(count: 2, start: 0)) {
    switch (i) {
        case 0:
            Console.WriteLine(value: $"Day 1: {Day1.RunPart1()}, {Day1.RunPart2()}");
            break;
        case 1:
            Console.WriteLine(value: $"Day 2: {Day2.RunPart1()}, {Day2.RunPart2()}");
            break;
        default:
            throw new NotImplementedException();
    }
}
