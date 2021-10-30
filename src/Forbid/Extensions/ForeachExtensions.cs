namespace Forbids;

internal static class ForeachExtensions
{
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        Forbid.From.NullOrEmpty(source);
        Forbid.From.Null(action);
        foreach (var item in source)
            action(item);
    }
    
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Func<T,T> predicate)
    {
        Forbid.From.NullOrEmpty(source);
        Forbid.From.Null(predicate);
        foreach (var item in source)
            yield return predicate(item);
    }
}