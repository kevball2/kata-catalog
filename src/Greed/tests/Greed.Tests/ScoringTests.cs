using FluentAssertions;
using Greed.Domain;

namespace Greed.Tests;

public class ScoringTests
{
    private List<int> _diceRolls = new();

    [Fact]
    public void ListContains3Ones_Return1000()
    {
        _diceRolls.Add(1);
        _diceRolls.Add(1);
        _diceRolls.Add(1);


        int result = ScoringCalculator.CalculateScore(_diceRolls);
        result.Should().Be(1000);
        _diceRolls.Clear();

    }

    [Fact]
    public void ListContains4OnesAnd1Five_Return2050() {
        _diceRolls.Add(1);
        _diceRolls.Add(1);
        _diceRolls.Add(1);
        _diceRolls.Add(1);
        _diceRolls.Add(5);

        int result = ScoringCalculator.CalculateScore(_diceRolls);
        result.Should().Be(2050);
        _diceRolls.Clear();

    }

    [Fact]
    public void ListContainsStraight_Return1200() {
        _diceRolls.Add(1);
        _diceRolls.Add(2);
        _diceRolls.Add(3);
        _diceRolls.Add(4);
        _diceRolls.Add(5);
        _diceRolls.Add(6);

        int result = ScoringCalculator.CalculateScore(_diceRolls);
        result.Should().Be(1200);
        _diceRolls.Clear();
    }

    [Fact]
    public void ListContains3Pairs_Return800() {        
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(3);
        _diceRolls.Add(3);
        _diceRolls.Add(4);
        _diceRolls.Add(4);

        int result = ScoringCalculator.CalculateScore(_diceRolls);
        result.Should().Be(800);
        _diceRolls.Clear();
    }

    [Fact]
    public void ListContains4ofaKind_Return400() {
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        
        int result = ScoringCalculator.CalculateScore(_diceRolls);
        result.Should().Be(400);
        _diceRolls.Clear();
    }

    [Fact]
    public void ListContains5ofaKind_Return800() {
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);


        int result = ScoringCalculator.CalculateScore(_diceRolls);
        result.Should().Be(800);
        _diceRolls.Clear();
    }

    [Fact]
    public void ListContains6ofaKind_Return1600() {
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);
        _diceRolls.Add(2);

        int result = ScoringCalculator.CalculateScore(_diceRolls);
        result.Should().Be(1600);
        _diceRolls.Clear();
    }

}