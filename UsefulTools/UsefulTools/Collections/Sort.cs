namespace UsefulTools.Collections;

public static class Sort<T>
{
    public delegate bool Сompare<T>(T a, T b);
    
    public static IEnumerable<T> Sort<T>(this IEnumerable<T> collection, Сompare<T> comparer)
    {
        var array = collection as T[] ?? collection.ToArray();
        
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (!comparer(array[j], array[i]))
                {
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
        }
        
        return array; 
    }
    
    public static bool IntСompare(int a, int b) => a > b;
    
    public static bool StringСompare(string a, string b) => a.Length > b.Length;
}