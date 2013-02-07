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
        public static decimal ThouToMillimeters(decimal thou)
        {
            return thou * (decimal)0.0254;
        }

        /// <summary>
        /// Converts millimeters to thou.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in thou.</returns>
        public static decimal MillimetersToThou(decimal millimeters)
        {
            return millimeters / (decimal)0.0254;
        }

        #endregion

        #region Inches

        /// <summary>
        /// Converts inches to millimeters.
        /// </summary>
        /// <param name="inches">The distance in inches.</param>
        /// <returns>The distance in millimeters.</returns>
        public static decimal InchesToMillimeters(decimal inches)
        {
            return inches * (decimal)25.4;
        }

        /// <summary>
        /// Converts millimeters to inches.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in inches.</returns>
        public static decimal MillimetersToInches(decimal millimeters)
        {
            return millimeters / (decimal)25.4;
        }

        #endregion

        #region Feet

        /// <summary>
        /// Converts feet to millimeters.
        /// </summary>
        /// <param name="feet">The distance in feet.</param>
        /// <returns>The distance in millimeters.</returns>
        public static decimal FeetToMillimeters(decimal feet)
        {
            return feet * (decimal)304.8;
        }

        /// <summary>
        /// Converts millimeters to feet.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in feet.</returns>
        public static decimal MillimetersToFeet(decimal millimeters)
        {
            return millimeters / (decimal)304.8;
        }

        #endregion

        #region Yards

        /// <summary>
        /// Converts yards to millimeters.
        /// </summary>
        /// <param name="yards">The distance in yards.</param>
        /// <returns>The distance in millimeters.</returns>
        public static decimal YardsToMillimeters(decimal yards)
        {
            return yards * (decimal)914.4;
        }

        /// <summary>
        /// Converts millimeters to yards.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in yards.</returns>
        public static decimal MillimetersToYards(decimal millimeters)
        {
            return millimeters / (decimal)914.4;
        }

        #endregion

        #region Chains

        /// <summary>
        /// Converts chains to millimeters.
        /// </summary>
        /// <param name="chains">The distance in chains.</param>
        /// <returns>The distance in millimeters.</returns>
        public static decimal ChainsToMillimeters(decimal chains)
        {
            return chains * (decimal)20116.8;
        }

        /// <summary>
        /// Converts millimeters to chains.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in chains.</returns>
        public static decimal MillimetersToChains(decimal millimeters)
        {
            return millimeters / (decimal)20116.8;
        }

        #endregion

        #region Furlongs

        /// <summary>
        /// Converts furlongs to millimeters.
        /// </summary>
        /// <param name="furlongs">The distance in furlongs.</param>
        /// <returns>The distance in millimeters.</returns>
        public static decimal FurlongsToMillimeters(decimal furlongs)
        {
            return furlongs * 201168;
        }

        /// <summary>
        /// Converts millimeters to furlongs.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in furlongs.</returns>
        public static decimal MillimetersToFurlongs(decimal millimeters)
        {
            return millimeters / 201168;
        }

        #endregion

        #region Miles

        /// <summary>
        /// Converts miles to millimeters.
        /// </summary>
        /// <param name="miles">The distance in miles.</param>
        /// <returns>The distance in millimeters.</returns>
        public static decimal MilesToMillimeters(decimal miles)
        {
            return miles * 1609344;
        }

        /// <summary>
        /// Converts millimeters to miles.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in miles.</returns>
        public static decimal MillimetersToMiles(decimal millimeters)
        {
            return millimeters / 1609344;
        }

        #endregion

        #region Leagues

        /// <summary>
        /// Converts leagues to millimeters.
        /// </summary>
        /// <param name="leagues">The distance in leagues.</param>
        /// <returns>The distance in millimeters.</returns>
        public static decimal LeaguesToMillimeters(decimal leagues)
        {
            return leagues * 5556000;
        }

        /// <summary>
        /// Converts millimeters to leagues.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>The distance in leagues.</returns>
        public static decimal MillimetersToLeagues(decimal millimeters)
        {
            return millimeters / 5556000;
        }

        #endregion
    }
}
