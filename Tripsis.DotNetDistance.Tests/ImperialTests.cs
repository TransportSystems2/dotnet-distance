// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImperialTests.cs" company="Tripsis">
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
//   Defines the ImperialTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Tripsis.DotNetDistance.Tests
{
    using System;

    using NUnit.Framework;

    /// <summary>
    /// Unit tests for imperial measurements.
    /// </summary>
    [TestFixture]
    public class ImperialTests
    {
        #region Thou

        /// <summary>
        /// Tests that thou are returned correctly.
        /// </summary>
        [Test]
        public void ThouAreReturnedCorrectly()
        {
            // Arrange
            const double Thou = 11234.5d;

            // Act
            var distance = Distance.FromThou(Thou);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Thou, distance.ToThou());
        }

        /// <summary>
        /// Tests that the conversion to thou works correctly.
        /// </summary>
        [Test]
        public void ConvertToThouWorksCorrectly()
        {
            // Arrange
            const double Millimeters = 112345d;
            const double Thou = 4423031.5d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Thou, Math.Round(distance.ToThou(), 1));
        }

        #endregion

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
            const double Millimeters = 112345d;
            const double Inches = 4423.0315d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Inches, Math.Round(distance.ToInches(), 4));
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
            const double Millimeters = 112345d;
            const double Feet = 368.585958d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Feet, Math.Round(distance.ToFeet(), 6));
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
            const double Millimeters = 112345d;
            const double Yards = 122.861986d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Yards, Math.Round(distance.ToYards(), 6));
        }

        #endregion

        #region Chains

        /// <summary>
        /// Tests that chains are returned correctly.
        /// </summary>
        [Test]
        public void ChainsAreReturnedCorrectly()
        {
            // Arrange
            const double Chains = 11234.5d;

            // Act
            var distance = Distance.FromChains(Chains);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Chains, distance.ToChains());
        }

        /// <summary>
        /// Tests that the conversion to chains works correctly.
        /// </summary>
        [Test]
        public void ConvertToChainsWorksCorrectly()
        {
            // Arrange
            const double Millimeters = 112345d;
            const double Chains = 5.58463573d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Chains, Math.Round(distance.ToChains(), 8));
        }

        #endregion

        #region Furlongs

        /// <summary>
        /// Tests that furlongs are returned correctly.
        /// </summary>
        [Test]
        public void FurlongsAreReturnedCorrectly()
        {
            // Arrange
            const double Furlongs = 11234.5d;

            // Act
            var distance = Distance.FromFurlongs(Furlongs);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Furlongs, distance.ToFurlongs());
        }

        /// <summary>
        /// Tests that the conversion to furlongs works correctly.
        /// </summary>
        [Test]
        public void ConvertToFurlongsWorksCorrectly()
        {
            // Arrange
            const double Millimeters = 1123456d;
            const double Furlongs = 5.58466555d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Furlongs, Math.Round(distance.ToFurlongs(), 8));
        }

        #endregion

        #region Miles

        /// <summary>
        /// Tests that miles are returned correctly.
        /// </summary>
        [Test]
        public void MilesAreReturnedCorrectly()
        {
            // Arrange
            const double Miles = 11234.5d;

            // Act
            var distance = Distance.FromMiles(Miles);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Miles, distance.ToMiles());
        }

        /// <summary>
        /// Tests that the conversion to miles works correctly.
        /// </summary>
        [Test]
        public void ConvertToMilesWorksCorrectly()
        {
            // Arrange
            const double Millimeters = 11234567d;
            const double Miles = 6.98083629d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Miles, Math.Round(distance.ToMiles(), 8));
        }

        #endregion

        #region Leagues

        /// <summary>
        /// Tests that leagues are returned correctly.
        /// </summary>
        [Test]
        public void LeaguesAreReturnedCorrectly()
        {
            // Arrange
            const double Leagues = 11234.5d;

            // Act
            var distance = Distance.FromLeagues(Leagues);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Leagues, distance.ToLeagues());
        }

        /// <summary>
        /// Tests that the conversion to leagues works correctly.
        /// </summary>
        [Test]
        public void ConvertToLeaguesWorksCorrectly()
        {
            // Arrange
            const double Millimeters = 11234566d;
            const double Leagues = 2.02206012d;

            // Act
            var distance = new Distance(Millimeters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Leagues, Math.Round(distance.ToLeagues(), 8));
        }

        #endregion
    }
}
