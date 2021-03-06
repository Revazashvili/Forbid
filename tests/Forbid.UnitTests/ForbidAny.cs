using System;
using System.Collections.Generic;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidAny
    {
        [Fact]
        public void Any_ThrowWhenAnyElementSatisfiesCondition()
        {
            IEnumerable<int> integerList = new List<int> { 1, 2, 3 };
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Any(integerList, x => x % 2 == 0));
        }
        
        [Fact]
        public void Any_NotThrowWhenNotASingleElementSatisfiesCondition()
        {
            IEnumerable<int> integerList = new List<int> { 1, 2, 3 };
            Forbids.Forbid.From.Any(integerList, x => x > 4);
        }
    }
}