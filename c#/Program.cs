// See https://aka.ms/new-console-template for more information
var sw = Stopwatch.StartNew();

const string filename = "../data.txt";

var day = new Day1();

var result = day.Solve(filename);
var result2 = day.Solve2(filename);

sw.Stop();

Console.WriteLine($"Solution: {result}");
Console.WriteLine($"Solution 2: {result2}");
Console.WriteLine($"Time Taken: {sw.ElapsedMilliseconds}");
