public class Day1
{
    public IEnumerable<int> GetData(string filename)
    {
        var data = File.ReadAllText(filename)
            .Split(Environment.NewLine + Environment.NewLine) // split by empty line
            .Select(x => x.Split(Environment.NewLine)); // split by line;

        return data.Select(x => x.Sum(y => int.Parse(y))); // sum all ints in groups
    }

    public int Solve(string filename)
    {
        return GetData(filename)
            .Max(); // max
    }

    public int Solve2(string filename)
    {
        var ordered = GetData(filename)
            .OrderByDescending(x => x); // order

        return ordered.Take(3).Sum(); // top 3
    }
}