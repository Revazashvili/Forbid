using System;
using System.Collections.Generic;

namespace Forbid
{
    internal static class ForbidZeroDefault
    {
        internal static T Zero<T>(T input,string? message = null,Exception? exception = null)
        {
            if (EqualityComparer<T>.Default.Equals(input, default!))
            {
                if(string.IsNullOrEmpty(message) && exception is null)
                    throw new ArgumentNullException(nameof(input));
                if(exception is not null)
                    Thrower.ThrowIfNotNull(exception,nameof(input));
                if(!string.IsNullOrEmpty(message))
                    Thrower.ThrowIfNotNull(message,nameof(input));
            }

            return input;
        }
    }
}