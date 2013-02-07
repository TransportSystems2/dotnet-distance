// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MetricTests.cs" company="Tripsis">
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
//   Defines the MetricTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Tripsis.DotNetDistance.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Unit tests for metric calculations.
    /// </summary>
    [TestFixture]
    public class MetricTests
    {
        /// <summary>
        /// Tests that meters are set correctly through the direct constructor.
        /// </summary>
        [Test]
        public void MillimetersReturnsTheCorrectValueThroughDirectConstructor()
        {
            // Arrange
            const long Millimeters = 12345;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Millimeters, distance.ToMillimeters());
        }

        /// <summary>
        /// Tests that millimeters are set correctly through the static constructor.
        /// </summary>
        [Test]
        public void MillimetersReturnsTheCorrectValue()
        {
            // Arrange
            const long Millimeters = 12345;

            // Act
            var distance = Distance.FromMilliimeters(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Millimeters, distance.ToMillimeters());
        }

        /// <summary>
        /// Tests that centimeters are returned correctly.
        /// </summary>
        [Test]
        public void CentimetersAreReturnedCorrectly()
        {
            // Arrange
            const double Centimeters = 11234.5;

            // Act
            var distance = Distance.FromCentimeters(Centimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Centimeters, distance.ToCentimeters());
        }

        /// <summary>
        /// Tests that meters are returned correctly.
        /// </summary>
        [Test]
        public void MetersAreReturnedCorrectly()
        {
            // Arrange
            const double Meters = 123.45;

            // Act
            var distance = Distance.FromMeters(Meters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Meters, distance.ToMeters());
        }

        /// <summary>
        /// Tests that kilometers are returned correctly.
        /// </summary>
        [Test]
        public void KilometersAreReturnedCorrectly()
        {
            // Arrange
            const double Km = 1.12345;

            // Act
            var distance = Distance.FromKilometers(Km);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Km, distance.ToKilometers());
        }
    }
}
