namespace DotNetDistance.Calcs
{
    /// <summary>
    /// Internal class to handle imperial calculations.
    /// </summary>
    internal static class ImperialCalculator
    {
        public const double CentimetersPerInch = 2.54;
        public const double InchesPerFoot = 12.0;
        public const double FeetPerYard = 3.0;
        public const double FeetPerMeter = MetricCalculator.CentimetersPerMeter / (CentimetersPerInch * InchesPerFoot);
        public const double InchesPerMeter = MetricCalculator.CentimetersPerMeter / CentimetersPerInch;

        #region Inches

        /// <summary>
        /// Converts inches to meters.
        /// </summary>
        /// <param name="inches">The distance in inches.</param>
        /// <returns>The distance in meters.</returns>
        public static double InchesToMeters(double inches)
        {
            return inches / InchesPerMeter;
        }

        /// <summary>
        /// Converts meters to inches.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>The distance in inches.</returns>
        public static double MetersToInches(double meters)
        {
            return meters * InchesPerMeter;
        }

        #endregion

        #region Feet

        /// <summary>
        /// Converts feet to meters.
        /// </summary>
        /// <param name="feet">The distance in feet.</param>
        /// <returns>The distance in meters.</returns>
        public static double FeetToMeters(double feet)
        {
            return feet / FeetPerMeter;
        }

        /// <summary>
        /// Converts meters to feet.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>The distance in feet.</returns>
        public static double MetersToFeet(double meters)
        {
            return meters * FeetPerMeter;
        }

        #endregion

        #region Yards

        /// <summary>
        /// Converts yards to meters.
        /// </summary>
        /// <param name="yards">The distance in yards.</param>
        /// <returns>The distance in meters.</returns>
        public static double YardsToMeters(double yards)
        {
            return yards * FeetPerYard / FeetPerMeter;
        }

        /// <summary>
        /// Converts meters to yards.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>The distance in yards.</returns>
        public static double MetersToYards(double meters)
        {
            return meters * FeetPerMeter / FeetPerYard;
        }

        #endregion
    }
}