namespace MiniChallengeEightToTen___Endpoints.Services.GuessIt;
public class GuessItService : IGuessItService
{
    int numParsed = 0;
    Random random = new Random();
    public string EasyRange(string num)
    {
        int ranNum = random.Next(1, 11);
        bool isTrue = int.TryParse(num, out numParsed);

        if (isTrue) {
            if (numParsed < ranNum) {
                return $"{num} is less than the correct number";
            } else if (numParsed > ranNum) {
                return $"{num} is greater than the correct number";
            } else {
                return $"congrats, {num} is correct";
            }
        } else {
            return "not a valid number";
        }
    }

    public string HardRange(string num)
    {
        int ranNum = random.Next(1, 101);
        bool isTrue = int.TryParse(num, out numParsed);

        if (isTrue) {
            if (numParsed < ranNum) {
                return $"{num} is less than the correct number";
            } else if (numParsed > ranNum) {
                return $"{num} is greater than the correct number";
            } else {
                return $"congrats, {num} is correct";
            }
        } else {
            return "not a valid number";
        }
    }

    public string MediumRange(string num)
    {
        int ranNum = random.Next(1, 51);
        bool isTrue = int.TryParse(num, out numParsed);

        if (isTrue) {
            if (numParsed < ranNum) {
                return $"{num} is less than the correct number";
            } else if (numParsed > ranNum) {
                return $"{num} is greater than the correct number";
            } else {
                return $"congrats, {num} is correct";
            }
        } else {
            return "not a valid number";
        }
    }
}