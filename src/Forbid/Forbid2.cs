namespace Forbids
{
    public class Forbid2 : IForbid
    {
        /// <summary>
        /// An entry point for extension methods.
        /// </summary>
        public static IForbid From { get; } = new Forbid();
    }
}