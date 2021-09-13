using System;
using System.Diagnostics.CodeAnalysis;
using static System.String;

namespace Forbid
{
    public static class ForbidExtensions
    {
        public static T Null<T>(this IForbid forbid, T input,string? message = null)
        {
            if (input is null)
            {
                if (!IsNullOrEmpty(message))
                    throw new ArgumentNullException(message);    
                throw new ArgumentNullException(nameof(input));
            }
            return input;
        }

        public static string NullOrEmpty(this IForbid forbid, string input, string? message = null)
        {
            Null(forbid, input, message);
            if (input == Empty)
            {
                throw new ArgumentNullException(message ?? "Required input was empty.");
            }

            return input;
        }
        
        public static Guid NullOrEmpty(this IForbid forbid, Guid input, string? message = null)
        {
            Null(forbid, input, message);
            if (input == Guid.Empty)
            {
                throw new ArgumentNullException(message ?? "Required input was empty.");
            }

            return input;
        }
    }
}