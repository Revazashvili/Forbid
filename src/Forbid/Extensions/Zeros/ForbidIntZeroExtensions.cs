using System;
using System.Runtime.InteropServices;

namespace Forbid
{
    public static class ForbidIntZeroExtensions
    {
        public static int Zero(this IForbid forbid, int input)
        {
            return ForbidZeroDefault.Zero(input);
        }
        
        public static int Zero(this IForbid forbid, int input,string message)
        {
            return ForbidZeroDefault.Zero(input,message);
        }
        
        public static int Zero(this IForbid forbid, int input,Exception exception)
        {
            return ForbidZeroDefault.Zero(input,null,exception);
        }
    }
}