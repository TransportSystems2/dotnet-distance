// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Tripsis">
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
//   Entity model for a distance.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Tripsis.DotNetDistance
{
    using System;

    using Tripsis.DotNetDistance.Calcs;

    /// <summary>
    /// Entity model for a distance.
    /// </summary>
    public class Distance : IEquatable<Distance>
    {
        #region Fields

        /// <summary>
        /// Local distance storage in millimeters.
        /// </summary>
        private readonly double millimeters;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        public Distance(double millimeters)
        {
            this.millimeters = millimeters;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Operator for ==.
        /// </summary>
        /// <param name="left">The left item.</param>
        /// <param name="right">The right item.</param>
        /// <returns><c>true</c> if the values are equal; otherwise <c>false</c>.</returns>
        public static bool operator ==(Distance left, Distance right)
        {
            return object.Equals(left, right);
        }

        /// <summary>
        /// Operator for !=.
        /// </summary>
        /// <param name="left">The left item.</param>
        /// <param name="right">The right item.</param>
        /// <returns><c>false</c> if the values are equal; otherwise <c>true</c>.</returns>
        public static bool operator !=(Distance left, Distance right)
        {
            return !object.Equals(left, right);
        }

        /// <summary>
        /// Operator for +.
        /// </summary>
        /// <param name="d1">The first item.</param>
        /// <param name="d2">The second item.</param>
        /// <returns>A new <see cref="Distance"/> object that has a distance
        /// value that is the total of the two operator values.</returns>
        public static Distance operator +(Distance d1, Distance d2)
        {
            return new Distance(d1.ToMillimeters() + d2.ToMillimeters());
        }

        /// <summary>
        /// Operator for -.
        /// </summary>
        /// <param name="d1">The first item.</param>
        /// <param name="d2">The second item.</param>
        /// <returns>A new <see cref="Distance"/> object that has a distance
        /// value that is the difference of the two operator values.</returns>
        public static Distance operator -(Distance d1, Distance d2)
        {
            return new Distance(d1.ToMillimeters() - d2.ToMillimeters());
        }

        #endregion

        #region Metric

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="millimeters"/>.
        /// </summary>
        /// <param name="millimeters">The distance in millimeters.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromMillimeters(double millimeters)
        {
            return new Distance(millimeters);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="centimeters"/>.
        /// </summary>
        /// <param name="centimeters">The distance in centimeters.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromCentimeters(double centimeters)
        {
            var distance = MetricCalculator.CentimetersToMillimeters(new decimal(centimeters));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="meters"/>.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromMeters(double meters)
        {
            var distance = MetricCalculator.MetersToMillimetres(new decimal(meters));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a <see cref="Distance"/> from a distance in kilometers.
        /// </summary>
        /// <param name="kilometers">The kilometers.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromKilometers(double kilometers)
        {
            var distance = MetricCalculator.KilometersToMillimeters(new decimal(kilometers));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Returns the distance in millimeters.
        /// </summary>
        /// <returns>The distance in millimeters.</returns>
        public double ToMillimeters()
        {
            return this.millimeters;
        }

        /// <summary>
        /// Returns the distance in centimeters.
        /// </summary>
        /// <returns>The distance in centimeters.</returns>
        public double ToCentimeters()
        {
            return (double)MetricCalculator.MillimetersToCentimeters(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in meters.
        /// </summary>
        /// <returns>The distance in meters.</returns>
        public double ToMeters()
        {
            return (double)MetricCalculator.MillimetersToMeters(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in kilometers.
        /// </summary>
        /// <returns>The distance in kilometers.</returns>
        public double ToKilometers()
        {
            return (double)MetricCalculator.MillimetersToKilometers(new decimal(this.millimeters));
        }

        #endregion

        #region Imperial

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="thou"/>.
        /// </summary>
        /// <param name="thou">The distance in thou.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromThou(double thou)
        {
            var distance = ImperialCalculator.ThouToMillimeters(new decimal(thou));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="inches"/>.
        /// </summary>
        /// <param name="inches">The distance in inches.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 inch = 1000 thou</remarks>
        public static Distance FromInches(double inches)
        {
            var distance = ImperialCalculator.InchesToMillimeters(new decimal(inches));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="feet"/>.
        /// </summary>
        /// <param name="feet">The distance in feet.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 foot = 12 inches</remarks>
        public static Distance FromFeet(double feet)
        {
            var distance = ImperialCalculator.FeetToMillimeters(new decimal(feet));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="yards"/>.
        /// </summary>
        /// <param name="yards">The distance in yards.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 yard = 3 feet</remarks>
        public static Distance FromYards(double yards)
        {
            var distance = ImperialCalculator.YardsToMillimeters(new decimal(yards));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="chains"/>.
        /// </summary>
        /// <param name="chains">The distance in chains.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 chain = 22 yards</remarks>
        public static Distance FromChains(double chains)
        {
            var distance = ImperialCalculator.ChainsToMillimeters(new decimal(chains));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="furlongs"/>.
        /// </summary>
        /// <param name="furlongs">The distance in furlongs.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 furlong = 10 chains</remarks>
        public static Distance FromFurlongs(double furlongs)
        {
            var distance = ImperialCalculator.FurlongsToMillimeters(new decimal(furlongs));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="miles"/>.
        /// </summary>
        /// <param name="miles">The distance in miles.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 mile = 8 furlongs</remarks>
        public static Distance FromMiles(double miles)
        {
            var distance = ImperialCalculator.MilesToMillimeters(new decimal(miles));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="leagues"/>.
        /// </summary>
        /// <param name="leagues">The distance in leagues.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 league = 3 miles</remarks>
        public static Distance FromLeagues(double leagues)
        {
            var distance = ImperialCalculator.LeaguesToMillimeters(new decimal(leagues));
            return new Distance((double)distance);
        }

        /// <summary>
        /// Returns the distance in thou.
        /// </summary>
        /// <returns>The distance in thou.</returns>
        public double ToThou()
        {
            return (double)ImperialCalculator.MillimetersToThou(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in inches.
        /// </summary>
        /// <returns>The distance in inches.</returns>
        public double ToInches()
        {
            return (double)ImperialCalculator.MillimetersToInches(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in feet.
        /// </summary>
        /// <returns>The distance in feet.</returns>
        public double ToFeet()
        {
            return (double)ImperialCalculator.MillimetersToFeet(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in yards.
        /// </summary>
        /// <returns>The distance in yards.</returns>
        public double ToYards()
        {
            return (double)ImperialCalculator.MillimetersToYards(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in chains.
        /// </summary>
        /// <returns>The distance in chains.</returns>
        public double ToChains()
        {
            return (double)ImperialCalculator.MillimetersToChains(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in furlongs.
        /// </summary>
        /// <returns>The distance in furlongs.</returns>
        public double ToFurlongs()
        {
            return (double)ImperialCalculator.MillimetersToFurlongs(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in miles.
        /// </summary>
        /// <returns>The distance in miles.</returns>
        public double ToMiles()
        {
            return (double)ImperialCalculator.MillimetersToMiles(new decimal(this.millimeters));
        }

        /// <summary>
        /// Returns the distance in leagues.
        /// </summary>
        /// <returns>The distance in leagues.</returns>
        public double ToLeagues()
        {
            return (double)ImperialCalculator.MillimetersToLeagues(new decimal(this.millimeters));
        }

        #endregion

        #region Overrides of Object

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return string.Format("{0} mm", this.ToMillimeters());
        }

        #endregion

        #region Equality members

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Distance other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.millimeters == other.millimeters;
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((Distance)obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return this.millimeters.GetHashCode();
        }

        #endregion
    }
}
