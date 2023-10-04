namespace StringGenerator;

public class Helper
{
    public static string GenerateRandomLengthString()
    {
        int randomNumber = GetRandomNumber(5, 11);
        string randomLengthString = Convert.ToBase64String(Guid.NewGuid().ToByteArray())[..(randomNumber - 1)];
        return randomLengthString;
    }

    public static int GetRandomNumber(int from, int to )
    {
        var random = new Random();
        int randomNumber = random.Next(from, to);
        return randomNumber;
    }

}
