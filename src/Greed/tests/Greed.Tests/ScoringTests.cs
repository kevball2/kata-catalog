using FluentAssertions;
using Greed.Domain;

namespace Greed.Tests;

public class ScoringTests
{
    [Fact]
    public void ListContains3Ones_Return1000()
    {
        List<int> diceRolls = new List<int>();
        diceRolls.Add(1);
        diceRolls.Add(1);
        diceRolls.Add(1);

        int result = ScoringCalculator.CalculateScore(diceRolls);
        result.Should().Be(1000);


    }

    [Fact]
    public void ListContains4OnesAnd1Five_Return2050() {
        List<int> diceRolls = new List<int>();
        diceRolls.Add(1);
        diceRolls.Add(1);
        diceRolls.Add(1);
        diceRolls.Add(1);
        diceRolls.Add(5);

        int result = ScoringCalculator.CalculateScore(diceRolls);
        result.Should().Be(2050);


    }

    [Fact]
    public void ListContainsStraight_Return1200() {
        List<int> diceRolls = new List<int>();
        diceRolls.Add(1);
        diceRolls.Add(2);
        diceRolls.Add(3);
        diceRolls.Add(4);
        diceRolls.Add(5);
        diceRolls.Add(6);

        diceRolls.Sort();

        int result = ScoringCalculator.CalculateScore(diceRolls);
        result.Should().Be(1200);
    }

    [Fact]
    public void ListContains3Pairs_Return800() {
        List<int> diceRolls = new List<int>();
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(3);
        diceRolls.Add(3);
        diceRolls.Add(4);
        diceRolls.Add(4);

        diceRolls.Sort();

        int result = ScoringCalculator.CalculateScore(diceRolls);
        result.Should().Be(800);
    }

    [Fact]
    public void ListContains4ofaKind_Return400() {
        List<int> diceRolls = new List<int>();
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);
        
        diceRolls.Sort();

        int result = ScoringCalculator.CalculateScore(diceRolls);
        result.Should().Be(400);
    }

    [Fact]
    public void ListContains5ofaKind_Return800() {
        List<int> diceRolls = new List<int>();
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);

        diceRolls.Sort();

        int result = ScoringCalculator.CalculateScore(diceRolls);
        result.Should().Be(800);
    }

    [Fact]
    public void ListContains6ofaKind_Return1600() {
        List<int> diceRolls = new List<int>();
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);
        diceRolls.Add(2);

        diceRolls.Sort();

        int result = ScoringCalculator.CalculateScore(diceRolls);
        result.Should().Be(1600);
    }

}