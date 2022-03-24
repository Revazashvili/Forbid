using System;
using System.Collections.Generic;
using System.Linq;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidDefaults
    {
        [Fact]
        public void LessThen_ThrowWhenLessThanSomething()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.LessThan(1, 2));
        }

        [Fact]
        public void LessThen_NotThrowWhenMoreThanSomething()
        {
            Forbids.Forbid.From.LessThan(2, 1);
            Forbids.Forbid.From.LessThan(2, 1);
        }

        [Fact]
        public void LessThanOrEqual_ThrowWhenLessSomethingOrEqual()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.LessThanOrEqual(1, 2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.LessThanOrEqual(2, 2));
        }

        [Fact]
        public void LessThanOrEqual_NotThrowWhenMoreThanSomething()
        {
            Forbids.Forbid.From.LessThanOrEqual(2, 1);
            Forbids.Forbid.From.LessThanOrEqual(2, 1);
        }

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