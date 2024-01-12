namespace MiniChallengeEightToTen___Endpoints.Services.EightBall;
public class EightBallService : IEightBallService
{
    public string EightBall()
    {
        Random ranNum = new Random();
        int num = ranNum.Next(1,9);

        if(num == 1) {
            return "Outlook hazy, try again later.";
        } else if (num == 2) {
            return "Signs point to yes, but don't get too excited.";
        } else if (num == 3) {
            return "Cannot predict now, ask again when the stars align.";
        } else if (num == 4) {
            return "Reply hazy, ask again after a good night's sleep.";
        } else if (num == 5) {
            return "Don't count on it, but stranger things have happened.";
        } else if (num == 6) {
            return "Yes, but only if you believe in the power of positive thinking.";
        } else if (num == 7) {
            return "Ask a friend for advice, the answer may be clearer with some input.";
        } else {
            return "Better not tell you now, let the mystery unfold naturally.";
        }
    }
}