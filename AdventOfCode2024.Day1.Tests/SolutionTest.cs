using System.IO;
using AdventOfCode2024.Day1;
using JetBrains.Annotations;
using Xunit;

namespace AdventOfCode2024.Day1.Tests;

[TestSubject(typeof(Solution))]
public class SolutionTest(Solution solution) : IClassFixture<Solution>
{
    private readonly Solution _solution = solution;

    [Fact]
    public void SampleInput_ReturnsExpectedValue()
    {
        const string sampleInput = """
                                   3   4
                                   4   3
                                   2   5
                                   1   3
                                   3   9
                                   3   3
                                   """;
        
        var actual = solution.Part1(sampleInput);
        
        Assert.Equal(11, actual);
    }

    [Fact]
    public void PuzzleInput_ReturnsExpectedValue()
    {
        var file = File.ReadAllText("./input.txt");
        var actual = _solution.Part1(file);
        Assert.Equal(1834060, actual);
    }

    [Fact]
    public void Part2Example_ReturnsExpectedValue()
    {
        const string sampleInput = """
                                   3   4
                                   4   3
                                   2   5
                                   1   3
                                   3   9
                                   3   3
                                   """;
        
        var actual = _solution.Part2(sampleInput);
        
        Assert.Equal(31, actual);
    }

    [Fact]
    public void Part2ChallengeInputs_ReturnsExpectedValue()
    {
        var file = File.ReadAllText("./input.txt");
        var actual = _solution.Part2(file);
        Assert.Equal(21607792, actual);
    }
}