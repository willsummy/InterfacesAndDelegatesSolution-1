using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InterfacesAndDelegates
{
    public class FilteringNumbers
    {
        [Fact]
        public void CanFilterOutEvenNumbers()
        {
            // Given
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numberFilter = new NumberFilter();
            // When
            List<int> odds = numberFilter.FilterOutEvens(numbers);

            // Then
            Assert.Equal(1, odds[0]);
            Assert.Equal(3, odds[1]);
            Assert.Equal(5, odds[2]);
            // etc. etc.
        }

        [Fact]
        public void CanFilterOutOddNumbers()
        {
            // Given
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numberFilter = new NumberFilter();
            // When
            List<int> odds = numberFilter.FilterOutOdds(numbers);

            // Then
            Assert.Equal(2, odds[0]);
            Assert.Equal(4, odds[1]);
            Assert.Equal(6, odds[2]);
            // etc. etc.
        }
    }
}
