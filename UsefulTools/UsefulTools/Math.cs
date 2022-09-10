namespace UsefulTools;

public class Math
{
    public static IEnumerable<int> GetFibanachi(int count)
    {
        var numsFibanachi = new List<int> { 0, 1 };
        
        for (var i = 2; i < count; i++)
        {
            yield return numsFibanachi[i - 1] + numsFibanachi[i - 2];
        }
    }
}