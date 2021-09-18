using System;
using Forbids;
using Xunit;

namespace Forbid.UnitTests
{
    public class ForbidDefaults
    {
        [Fact]
        public void Equal_ThrowsExceptionWhenEqual()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(10, 10));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(1.2, 1.2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(189371293, 189371293));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Equal(TimeSpan.FromMinutes(20),TimeSpan.FromMinutes(20)));
        }
        
        [Fact]
        public void Equal_NotThrowsExceptionWhenNotEqual()
        {
            Forbids.Forbid.From.Equal(10, 2);
            Forbids.Forbid.From.Equal(1.2, 2);
            Forbids.Forbid.From.Equal(1131029380, 76);
        }

        [Fact]
        public void Zero_ThrowsWhenZero()
        {
            double zeroDouble = 0.0;
            long zeroLong = 0;
            
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(zeroDouble));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(zeroLong));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Zero(0));
        }
        
        [Fact]
        public void Zero_NotThrowsWhenNotEqualZero()
        {
            Forbids.Forbid.From.Zero(10);
            Forbids.Forbid.From.Zero(1.2);
            Forbids.Forbid.From.Zero(11231231);
            Forbids.Forbid.From.Zero(TimeSpan.MaxValue);
        }

        [Fact]
        public void Positive_ThrowsWhenPositive()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Positive(10));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Positive(1.2));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Positive(TimeSpan.MaxValue));
        }
        
        [Fact]
        public void Positive_NotThrowsWhenNegative()
        {
            Forbids.Forbid.From.Positive(-10);
            Forbids.Forbid.From.Positive(-1.2);
        }

        [Fact]
        public void Negative_ThrowWhenNegative()
        {
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Negative(-1));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.Negative(-1.2));
        }

        [Fact]
        public void Negative_NotThrowWhenPositive()
        {
            Forbids.Forbid.From.Negative(1);
            Forbids.Forbid.From.Negative(DateTime.MaxValue);
            Forbids.Forbid.From.Negative(123.123);
        }

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
        }

        [Fact]
        public void True_NotThrowWhenFalse()
        {
            var equal = 2 == 3;
            
            Forbids.Forbid.From.True(false);
            Forbids.Forbid.From.True(equal);
        }

        [Fact]
        public void False_ThrowWhenFalse()
        {
            var equal = 2 == 3;
            
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(false));
            Assert.Throws<ArgumentException>(() => Forbids.Forbid.From.False(equal));
        }

        [Fact]
        public void False_NotThrowWhenTrue()
        {
            var equal = 22 == 22; 
            Forbids.Forbid.From.False(equal);
            Forbids.Forbid.From.False(true);
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
        
        
    }
}