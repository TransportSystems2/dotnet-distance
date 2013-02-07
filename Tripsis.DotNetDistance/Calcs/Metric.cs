// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Metric.cs" company="Tripsis">
//   Distance object abstraction in .NET 4.
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
//   Internal class to handle metric calculations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Tripsis.DotNetDistance.Calcs
{
    /// <summary>
    /// Internal class to handle metric calculations.
    /// </summary>
    internal abstract class Metric
    {
        #region Centimeters

        /// <summary>
        /// Converts centimeters to millimeters.
        /// </summary>
        /// <param name="centimeters">The distance in centimeters.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double CentimetersToMillimeters(double centimeters)
        {
            return centimeters * 10;
        }

        /// <summary>
        /// Converts millimeters to centimeters.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in centimeters.</returns>
        public static double MillimetersToCentimeters(double millimeters)
        {
            return millimeters / 10d;
        }

        #endregion

        #region Meters

        /// <summary>
        /// Converts meters to millimeters.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double MetersToMillimetres(double meters)
        {
            return meters * 1000;
        }

        /// <summary>
        /// Converts millimeters to meters.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in meters.</returns>
        public static double MillimetersToMeters(double millimeters)
        {
            return millimeters / 1000d;
        }

        #endregion

        #region Kilometers

        /// <summary>
        /// Converts millimeters to kilometers.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in kilometers.</returns>
        public static double MillimetersToKilometers(double millimeters)
        {
            return millimeters / 1000000d;
        }

        /// <summary>
        /// Converts kilometers to millimeters.
        /// </summary>
        /// <param name="kilometers">The distance in kilometers.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double KilometersToMillimeters(double kilometers)
        {
            return kilometers * 10 * 100 * 1000;
        }

        #endregion
    }
}
