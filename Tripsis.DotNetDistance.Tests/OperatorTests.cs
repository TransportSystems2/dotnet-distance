// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperatorTests.cs" company="Tripsis">
//   Distance object abstraction in .NET 2.
//   Copyright (C) 2013 Kevin Wilson
//   
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//   
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <summary>
//   Tests for operator calculations on <see cref="Distance" /> objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Tripsis.DotNetDistance.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Tests for operator calculations on <see cref="Distance"/> objects.
    /// </summary>
    [TestFixture]
    public class OperatorTests
    {
        #region ==

        /// <summary>
        /// Tests that the == operator returns <c>true</c> if the values are the same.
        /// </summary>
        [Test]
        public void EqualsReturnsTrueIfItemsAreEqual()
        {
            // Arrange
            const long Distance = 123;
            var distance1 = new Distance(Distance);
            var distance2 = new Distance(Distance);

            // Assert
            Assert.IsTrue(distance1 == distance2);
        }

        /// <summary>
        /// Tests that the == operator returns <c>false</c> if the values are not the same.
        /// </summary>
        [Test]
        public void EqualsReturnsFalseIfItemsAreNotEqual()
        {
            // Arrange
            const long Distance1 = 123;
            const long Distance2 = 321;
            var distance1 = new Distance(Distance1);
            var distance2 = new Distance(Distance2);

            // Assert
            Assert.IsFalse(distance1 == distance2);
        }

        #endregion

        #region !=

        /// <summary>
        /// Tests that the != operator returns <c>true</c> if the values are not the same.
        /// </summary>
        [Test]
        public void NotEqualsReturnsTrueIfItemsAreNotEqual()
        {
            // Arrange
            const long Distance1 = 123;
            const long Distance2 = 321;
            var distance1 = new Distance(Distance1);
            var distance2 = new Distance(Distance2);

            // Assert
            Assert.IsTrue(distance1 != distance2);
        }

        /// <summary>
        /// Tests that the != operator returns <c>false</c> if the values are the same.
        /// </summary>
        [Test]
        public void NotEqualsReturnsFalseIfItemsAreEqual()
        {
            // Arrange
            const long Distance = 123;
            var distance1 = new Distance(Distance);
            var distance2 = new Distance(Distance);

            // Assert
            Assert.IsFalse(distance1 != distance2);
        }

        #endregion

        /// <summary>
        /// Tests that + adds the distances of two items together.
        /// </summary>
        [Test]
        public void PlusAddsTwoItemsTogether()
        {
            // Arrange
            const long Distance1 = 123;
            const long Distance2 = 456;
            const long Total = 579;

            var distance1 = new Distance(Distance1);
            var distance2 = new Distance(Distance2);

            // Act
            var result = distance1 + distance2;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToMillimeters(), Total);
        }

        /// <summary>
        /// Tests that += adds the distances of two items together.
        /// </summary>
        [Test]
        public void PlusEqualsAddsTwoItemsTogether()
        {
            // Arrange
            const long Distance1 = 123;
            const long Distance2 = 456;
            const long Total = 579;

            var distance1 = new Distance(Distance1);
            var distance2 = new Distance(Distance2);

            // Act
            distance1 += distance2;

            // Assert
            Assert.IsNotNull(distance1);
            Assert.AreEqual(distance1.ToMillimeters(), Total);
        }

        /// <summary>
        /// Tests that - subtracts one distance from another.
        /// </summary>
        [Test]
        public void SubtractTakesOnesDistanceAwayFromAnother()
        {
            // Arrange
            const long Distance1 = 123;
            const long Distance2 = 456;
            const long Difference = 333;

            var distance1 = new Distance(Distance1);
            var distance2 = new Distance(Distance2);

            // Act
            var result = distance2 - distance1;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToMillimeters(), Difference);
        }

        /// <summary>
        /// Tests that -= subtracts one distance from another.
        /// </summary>
        [Test]
        public void SubtractEqualsTakesOnesDistanceAwayFromAnother()
        {
            // Arrange
            const long Distance1 = 123;
            const long Distance2 = 456;
            const long Difference = 333;

            var distance1 = new Distance(Distance1);
            var distance2 = new Distance(Distance2);

            // Act
            distance2 -= distance1;

            // Assert
            Assert.IsNotNull(distance2);
            Assert.AreEqual(distance2.ToMillimeters(), Difference);
        }
    }
}
