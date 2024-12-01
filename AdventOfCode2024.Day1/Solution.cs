namespace AdventOfCode2024.Day1;

public class Solution
{
    private static string _sampleInput = """
                                        3   4
                                        4   3
                                        2   5
                                        1   3
                                        3   9
                                        3   3
                                        """;

    public int Part1(string input)
    {
        List<int> left = [];
        List<int> right = [];
        foreach (var line in input.Split("\n"))
        {
            var chars = line.Split("   ");
            left.Add(int.Parse(chars[0]));
            right.Add(int.Parse(chars[1]));
        }

        left = left.OrderBy(x => x).ToList();
        right = right.OrderBy(x => x).ToList();

        var differences = new List<int>();
        for (var i = 0; i < left.Count; i++)
        {
            var leftItem = left[i];
            var rightItem = right[i];
            var difference = leftItem > rightItem ? leftItem - rightItem : rightItem - leftItem;
            differences.Add(difference);
        }

        return differences.Sum();
    }

    public int Part2(string input)
    {
        List<int> left = [];
        List<int> right = [];
        foreach (var line in input.Split("\n"))
        {
            var chars = line.Split("   ");
            left.Add(int.Parse(chars[0]));
            right.Add(int.Parse(chars[1]));
        }

        left = left.OrderBy(x => x).ToList();
        right = right.OrderBy(x => x).ToList();
        
        var occurences = new List<(int number, int times)>();

        foreach (var number in left)
        {
            var times = right.Count(x => x == number);
            occurences.Add((number, times));
        }

        return occurences.Select(result => result.times * result.number).Sum();
    }
}