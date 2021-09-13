using System;

namespace Forbid
{
    public static class ForbidDoubleZeroExtensions
    {
        public static double Zero(this Forbid forbid, double input)
        {
            return ForbidZeroDefault.Zero(input);
        }
        
        public static double Zero(this Forbid forbid, double input,string message)
        {
            return ForbidZeroDefault.Zero(input,message);
        }
        
        public static double Zero(this Forbid forbid, double input,Exception exception)
        {
            return ForbidZeroDefault.Zero(input,null,exception);
        }
    }
}