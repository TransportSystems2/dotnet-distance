// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImperialCalculator.cs" company="Tripsis">
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
//   Internal class to handle imperial calculations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Tripsis.DotNetDistance.Calcs
{
    /// <summary>
    /// Internal class to handle imperial calculations.
    /// </summary>
    internal static class ImperialCalculator
    {
        #region Thou

        /// <summary>
        /// Converts thou to millimeters.
        /// </summary>
        /// <param name="thou">The distance in thou.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double ThouToMillimeters(double thou)
        {
            return thou * 0.0254d;
        }

        /// <summary>
        /// Converts millimeters to thou.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in thou.</returns>
        public static double MillimetersToThou(double millimeters)
        {
            return millimeters / 0.0254d;
        }

        #endregion

        #region Inches

        /// <summary>
        /// Converts inches to millimeters.
        /// </summary>
        /// <param name="inches">The distance in inches.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double InchesToMillimeters(double inches)
        {
            return inches * 25.4d;
        }

        /// <summary>
        /// Converts millimeters to inches.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in inches.</returns>
        public static double MillimetersToInches(double millimeters)
        {
            return millimeters / 25.4d;
        }

        #endregion

        #region Feet

        /// <summary>
        /// Converts feet to millimeters.
        /// </summary>
        /// <param name="feet">The distance in feet.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double FeetToMillimeters(double feet)
        {
            return feet * 304.8d;
        }

        /// <summary>
        /// Converts millimeters to feet.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in feet.</returns>
        public static double MillimetersToFeet(double millimeters)
        {
            return millimeters / 304.8d;
        }

        #endregion

        #region Yards

        /// <summary>
        /// Converts yards to millimeters.
        /// </summary>
        /// <param name="yards">The distance in yards.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double YardsToMillimeters(double yards)
        {
            return yards * 914.4d;
        }

        /// <summary>
        /// Converts millimeters to yards.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in yards.</returns>
        public static double MillimetersToYards(double millimeters)
        {
            return millimeters / 914.4d;
        }

        #endregion

        #region Chains

        /// <summary>
        /// Converts chains to millimeters.
        /// </summary>
        /// <param name="chains">The distance in chains.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double ChainsToMillimeters(double chains)
        {
            return chains * 20116.8d;
        }

        /// <summary>
        /// Converts millimeters to chains.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in chains.</returns>
        public static double MillimetersToChains(double millimeters)
        {
            return millimeters / 20116.8d;
        }

        #endregion

        #region Furlongs

        /// <summary>
        /// Converts furlongs to millimeters.
        /// </summary>
        /// <param name="furlongs">The distance in furlongs.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double FurlongsToMillimeters(double furlongs)
        {
            return furlongs * 201168d;
        }

        /// <summary>
        /// Converts millimeters to furlongs.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in furlongs.</returns>
        public static double MillimetersToFurlongs(double millimeters)
        {
            return millimeters / 201168d;
        }

        #endregion

        #region Miles

        /// <summary>
        /// Converts miles to millimeters.
        /// </summary>
        /// <param name="miles">The distance in miles.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double MilesToMillimeters(double miles)
        {
            return miles * 1609344d;
        }

        /// <summary>
        /// Converts millimeters to miles.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in miles.</returns>
        public static double MillimetersToMiles(double millimeters)
        {
            return millimeters / 1609344d;
        }

        #endregion

        #region Leagues

        /// <summary>
        /// Converts leagues to millimeters.
        /// </summary>
        /// <param name="leagues">The distance in leagues.</param>
        /// <returns>The distance in millimeters.</returns>
        public static double LeaguesToMillimeters(double leagues)
        {
            return leagues * 5556000d;
        }

        /// <summary>
        /// Converts millimeters to leagues.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in leagues.</returns>
        public static double MillimetersToLeagues(double millimeters)
        {
            return millimeters / 5556000d;
        }

        #endregion
    }
}
