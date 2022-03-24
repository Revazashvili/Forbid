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
        public void NegativeOrZero_ThrowWhenZeroOrNegative()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NegativeOrZero(0));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.NegativeOrZero(-1));
        }

        [Fact]
        public void NegativeOrZero_NotThrowWhenPositiveBesideZero()
        {
            Forbids.Forbid.From.NegativeOrZero(1);
            Forbids.Forbid.From.NegativeOrZero(18937129);
        }

        [Fact]
        public void PositiveOrZero_ThrowWhenPositiveOrZero()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.PositiveOrZero(0));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.PositiveOrZero(190237));
        }

        [Fact]
        public void PositiveOrZero_NotThrowWhenNegativeBesideZero()
        {
            Forbids.Forbid.From.PositiveOrZero(-1);
            Forbids.Forbid.From.PositiveOrZero(5 - 8);
        }

        [Fact]
        public void True_ThrowWhenTrue()
        {
            var equal = 2 == 2;
            
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.True(true));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.True(equal));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.True(equal,true));
        }

        [Fact]
        public void True_NotThrowWhenFalse()
        {
            var equal = 2 == 3;
            
            Forbids.Forbid.From.True(false);
            Forbids.Forbid.From.True(equal);
            Forbids.Forbid.From.True(false, equal);
            var result = Forbids.Forbid.From.True(false, equal);
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void False_ThrowWhenFalse()
        {
            var equal = 2 == 3;
            
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(false));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(equal));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(equal,false));
        }

        [Fact]
        public void False_NotThrowWhenTrue()
        {
            var equal = 22 == 22; 
            Forbids.Forbid.From.False(equal);
            Forbids.Forbid.From.False(true);
            Forbids.Forbid.From.False(true,equal);
            var result = Forbids.Forbid.From.False(true,equal);
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void Range_ThrowWhenInRange()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Range(10, 9, 11));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Range(1, 0, 2));
        }

        [Fact]
        public void Range_NotThrowWhenOutOfRange()
        {
            Forbids.Forbid.From.Range(1, 2, 3);
            Forbids.Forbid.From.Range(0, 22, 39);
        }

        [Fact]
        public void MoreThan_ThrowWhenMoreThanSomething()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThan(3, 2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThan(30, 20));
        }

        [Fact]
        public void MoreThan_NotThrowWhenLessThanSomething()
        {
            Forbids.Forbid.From.MoreThan(2, 5);
        }

        [Fact]
        public void MoreThanOrEqual_ThrowWhenMoreThanSomethingOrEqual()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThanOrEqual(10, 2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.MoreThanOrEqual(10, 10));
        }

        [Fact]
        public void MoreThanOrEqual_NotThrowWhenLessThanSomething()
        {
            Forbids.Forbid.From.MoreThanOrEqual(10, 20);
        }

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