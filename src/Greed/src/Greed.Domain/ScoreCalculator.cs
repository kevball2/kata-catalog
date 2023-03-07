namespace Greed.Domain;
public class ScoringCalculator
{

    public static int CalculateScore(List<int> diceRolls)
    {
        int result = 0;
        
        var groupedNumbers = diceRolls.GroupBy(x => x);
        foreach ( var groupedNumber in groupedNumbers) {
            result += scoreTriple(groupedNumber);
            result = scoreMultipler(groupedNumber, result);
            result += scoreSingle(groupedNumber);
            
        }

        if (groupedNumbers.Count() == 3 && diceRolls.Count == 6) {
            result = 800;
        }

        var listStraight = new List<int> { 1, 2, 3, 4, 5, 6};
        if (diceRolls.SequenceEqual(listStraight)) {
            result = 1200; 
        }

        return result;
    }

    private static int scoreMultipler(IGrouping<int, int> groupedNumber, int currentScore) {
        int total = 0;
        switch (groupedNumber.Count()) {

            case (4):
                total += (2 * currentScore);
                break;
            case (5):
                total += (4 * currentScore);
                break;
            case (6):
                total += (8 * currentScore);
                break;
            default:
                return currentScore;
        }
        return total;
    }

    private static int scoreSingle(IGrouping<int, int> groupedNumber) {
        int total = 0;
        switch (groupedNumber.Key, groupedNumber.Count()) {

            case (1, 1):
                total += 100;
                break;
            case (1, 2):
                total += 200;
                break;
            case (5, 1):
                total += 50;
                break;
            case (5, 2):
                total += 100;
                break;
            default:
                break;
        }
        return total;
    }

    private static int scoreTriple(IGrouping<int, int> groupedNumber) {
        int total = 0;
        switch (groupedNumber.Key, groupedNumber.Count()) {
            
            case (1, >= 3):
                total += 1000;
                break;
            case (2,  >= 3):
                total += 200;
                break;
            case (3, >= 3):
                total += 300;
                break;
            case (4, >= 3):
                total += 400;
                break;
            case (5, >= 3):
                total += 500;
                break;
            case (6, >= 3):
                total += 600;
                break;
            default:
                break;
        }
        return total;
    }
}


