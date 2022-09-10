namespace UsefulTools.Collections;

public static class FillingCollection
{
    public static IEnumerable<int> FillingArray(this IEnumerable<int> collection, int randomMin)
    {
        return FillingArray(collection, randomMin, 100);
    }

    public static IEnumerable<int> FillingArray(this IEnumerable<int> collection)
    {
        return FillingArray(collection, 0, 100);
    }
    
    public static IEnumerable<int> FillingArray(this IEnumerable<int> collection, int randomMin, int randomMax)
    {
        Random random = new(DateTime.Now.Millisecond);
        var array = collection as int[] ?? collection.ToArray();
        
        for (var i = 0; i < array.Length; i++)
        {
            yield return random.Next(randomMin, randomMax);
        }
    }
}