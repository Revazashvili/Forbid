using System;

namespace Forbid
{
    public class Tester
    {
        public void Test()
        {
            Forbid.From.Null(1);
            Forbid.From.NullOrEmpty(Guid.Empty, new Exception());
        }
    }
}