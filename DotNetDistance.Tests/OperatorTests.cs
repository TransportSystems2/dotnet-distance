using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DotNetDistance.Tests
{
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
            const int Distance = 123;
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
            const int Distance1 = 123;
            const int Distance2 = 321;
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

        #region +

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
            Assert.AreEqual(result.ToMeters(), Total);
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
            Assert.AreEqual(distance1.ToMeters(), Total);
        }

        [Test]
        public void SumEnumeration()
        {
            var distanceOfList = new List<Distance>
            {
                Distance.FromMeters(1),
                Distance.FromMeters(2),
                Distance.FromMeters(3)
            };

            var totalDistance = distanceOfList.Sum();

            Assert.IsNotNull(totalDistance);
            Assert.AreEqual(6, totalDistance.ToMeters());
        }

        #endregion

        #region -

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
            Assert.AreEqual(result.ToMeters(), Difference);
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
            Assert.AreEqual(distance2.ToMeters(), Difference);
        }

        #endregion

        #region > <

        [Test]
        public void CompareReturnsTrueIfFirsItemsIsGreaterThanSecond()
        {
            // Arrange
            var firstDistance = Distance.FromCentimeters(2);
            var secondDistance = Distance.FromCentimeters(1);

            // Assert
            Assert.IsTrue(firstDistance > secondDistance);
        }

        [Test]
        public void CompareReturnsFalseIfFirstItemsIsNotGreaterThanSecond()
        {
            // Arrange
            var firstDistance = Distance.FromCentimeters(2);
            var secondDistance = Distance.FromCentimeters(1);

            // Assert
            Assert.IsFalse(firstDistance < secondDistance);
        }

        [Test]
        public void CompareReturnsTrueIfFirsItemsIsGreaterOrEqualSecond()
        {
            // Arrange
            var firstDistance = Distance.FromCentimeters(2);
            var secondDistance = Distance.FromCentimeters(2);

            // Assert
            Assert.IsTrue(firstDistance >= secondDistance);
        }

        [Test]
        public void CompareReturnsFalseIfFirstItemsIsNotGreaterOrEqualSecond()
        {
            // Arrange
            var firstDistance = Distance.FromCentimeters(2);
            var secondDistance = Distance.FromCentimeters(3);

            // Assert
            Assert.IsFalse(firstDistance >= secondDistance);
        }

        #endregion
    }
}