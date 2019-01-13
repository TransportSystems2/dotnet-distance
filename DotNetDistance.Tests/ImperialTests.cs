using System;
using NUnit.Framework;

namespace DotNetDistance.Tests
{
    /// <summary>
    /// Unit tests for imperial measurements.
    /// </summary>
    [TestFixture]
    public class ImperialTests
    {
        #region Inches

        /// <summary>
        /// Tests that inches are returned correctly.
        /// </summary>
        [Test]
        public void InchesAreReturnedCorrectly()
        {
            // Arrange
            const double Inches = 11234.5d;

            // Act
            var distance = Distance.FromInches(Inches);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Inches, distance.ToInches());
        }

        /// <summary>
        /// Tests that the conversion to inches works correctly.
        /// </summary>
        [Test]
        public void ConvertToInchesWorksCorrectly()
        {
            // Arrange
            const double Meters = 112345;
            const double Inches = 4423031.5;

            // Act
            var distance = new Distance(Meters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Inches, Math.Round(distance.ToInches(), 1));
        }

        #endregion

        #region Feet

        /// <summary>
        /// Tests that feet are returned correctly.
        /// </summary>
        [Test]
        public void FeetAreReturnedCorrectly()
        {
            // Arrange
            const double Feet = 11234.5d;

            // Act
            var distance = Distance.FromFeet(Feet);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Feet, distance.ToFeet());
        }

        /// <summary>
        /// Tests that the conversion to feet works correctly.
        /// </summary>
        [Test]
        public void ConvertToFeetWorksCorrectly()
        {
            // Arrange
            const double Meters = 112345;
            const double Feet = 368585.958;

            // Act
            var distance = new Distance(Meters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Feet, Math.Round(distance.ToFeet(), 3));
        }

        #endregion

        #region Yards

        /// <summary>
        /// Tests that yards are returned correctly.
        /// </summary>
        [Test]
        public void YardsAreReturnedCorrectly()
        {
            // Arrange
            const double Yards = 11234.5d;

            // Act
            var distance = Distance.FromYards(Yards);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Yards, distance.ToYards());
        }

        /// <summary>
        /// Tests that the conversion to yards works correctly.
        /// </summary>
        [Test]
        public void ConvertToYardsWorksCorrectly()
        {
            // Arrange
            const double Meters = 112345;
            const double Yards = 122861.986;

            // Act
            var distance = new Distance(Meters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Yards, Math.Round(distance.ToYards(), 3));
        }

        #endregion
    }
}