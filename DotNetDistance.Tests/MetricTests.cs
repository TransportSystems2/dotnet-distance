using NUnit.Framework;

namespace DotNetDistance.Tests
{
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
        public void MetersReturnsTheCorrectValueThroughDirectConstructor()
        {
            // Arrange
            const long Meters = 12345;

            // Act
            var distance = new Distance(Meters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Meters, distance.ToMeters());
        }

        /// <summary>
        /// Tests that meters are set correctly through the static constructor.
        /// </summary>
        [Test]
        public void MetersReturnsTheCorrectValue()
        {
            // Arrange
            const long Meters = 12345;

            // Act
            var distance = Distance.FromMeters(Meters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Meters, distance.ToMeters());
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
        /// Tests that the conversion to centimeters works correctly.
        /// </summary>
        [Test]
        public void ConvertToCentimetersWorksCorrectly()
        {
            // Arrange
            const double Meters = 1123.45;
            const double Centimeters = 112345;

            // Act
            var distance = new Distance(Meters);

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
        /// Tests that the conversion to meters works correctly.
        /// </summary>
        [Test]
        public void ConvertToMetersWorksCorrectly()
        {
            // Arrange
            const double Meters = 112345;

            // Act
            var distance = new Distance(Meters);

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

        /// <summary>
        /// Tests that the conversion to kilometers works correctly.
        /// </summary>
        [Test]
        public void ConvertToKilometersWorksCorrectly()
        {
            // Arrange
            const double Meters = 112345678;
            const double Kilometers = 112345.678;

            // Act
            var distance = new Distance(Meters);

            // Assert
            Assert.IsNotNull(distance);
            Assert.AreEqual(Kilometers, distance.ToKilometers());
        }
    }
}