namespace DotNetDistance.Calcs
{
    /// <summary>
    /// Internal class to handle metric calculations.
    /// </summary>
    internal static class MetricCalculator
    {
        public const double MetersPerKilometer = 1000.0;
        public const double CentimetersPerMeter = 100.0;

        #region Centimeters

        /// <summary>
        /// Converts centimeters to meters.
        /// </summary>
        /// <param name="centimeters">The distance in centimeters.</param>
        /// <returns>The distance in meters.</returns>
        public static double CentimetersToMeters(double centimeters)
        {
            return centimeters / CentimetersPerMeter;
        }

        /// <summary>
        /// Converts meters to centimeters.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>The distance in centimeters.</returns>
        public static double MetersToCentimeters(double meters)
        {
            return meters * CentimetersPerMeter;
        }

        #endregion

        #region Kilometers

        /// <summary>
        /// Converts meters to kilometers.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>The distance in kilometers.</returns>
        public static double MetersToKilometers(double meters)
        {
            return meters / MetersPerKilometer;
        }

        /// <summary>
        /// Converts kilometers to meters.
        /// </summary>
        /// <param name="kilometers">The distance in kilometers.</param>
        /// <returns>The distance in meters.</returns>
        public static double KilometersToMeters(double kilometers)
        {
            return kilometers * MetersPerKilometer;
        }

        #endregion
    }
}