namespace Forbid
{
    /// <summary>
    /// 
    /// </summary>
    public class Forbid : IForbid
    {
        public static IForbid From { get; } = new Forbid();
    }
}