﻿namespace Slicedbread.CompareTo.Tests
{
    using CompareTo.Models;
    using Shouldly;
    using Xunit;

    public class DifferenceTests
    {
        [Fact]
        public void Returns_Difference_As_String()
        {
            // Given
            var diff = new Difference(typeof (int), "MyProperty", 789, 999);

            // When
            var diffString = diff.ToString();

            // Then
            diffString.ShouldBe("'MyProperty' changed from '789' to '999'");
        }
    }
}
