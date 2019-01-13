using System;
using DotNetDistance.Calcs;

namespace DotNetDistance
{
    /// <summary>
    /// Entity model for a distance.
    /// </summary>
    public struct Distance : IComparable, IComparable<Distance>, IEquatable<Distance>
    {
        #region Fields

        /// <summary>
        /// Local distance storage in meters.
        /// </summary>
        private readonly double meters;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        public Distance(double meters)
        {
            this.meters = meters;
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
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            return left.meters == right.meters;
        }

        /// <summary>
        /// Operator for !=.
        /// </summary>
        /// <param name="left">The left item.</param>
        /// <param name="right">The right item.</param>
        /// <returns><c>false</c> if the values are equal; otherwise <c>true</c>.</returns>
        public static bool operator !=(Distance left, Distance right)
        {
            return !(left == right);
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
            return new Distance(d1.ToMeters() + d2.ToMeters());
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
            return new Distance(d1.ToMeters() - d2.ToMeters());
        }

        public static bool operator >(Distance d1, Distance d2)
        {
            return d1.CompareTo(d2) > 0;
        }

        public static bool operator <(Distance d1, Distance d2)
        {
            return d1.CompareTo(d2) < 0;
        }

        public static bool operator <=(Distance d1, Distance d2)
        {
            return d1.CompareTo(d2) <= 0;
        }

        public static bool operator >=(Distance d1, Distance d2)
        {
            return d1.CompareTo(d2) >= 0;
        }

        #endregion

        #region Metric

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="meters"/>.
        /// </summary>
        /// <param name="meters">The distance in meters.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromMeters(double meters)
        {
            return new Distance(meters);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="centimeters"/>.
        /// </summary>
        /// <param name="centimeters">The distance in centimeters.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromCentimeters(double centimeters)
        {
            var distance = MetricCalculator.CentimetersToMeters(centimeters);
            return new Distance(distance);
        }

        /// <summary>
        /// Gets a <see cref="Distance"/> from a distance in kilometers.
        /// </summary>
        /// <param name="kilometers">The kilometers.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        public static Distance FromKilometers(double kilometers)
        {
            var distance = MetricCalculator.KilometersToMeters(kilometers);
            return new Distance(distance);
        }

        /// <summary>
        /// Returns the distance in meters.
        /// </summary>
        /// <returns>The distance in meters.</returns>
        public double ToMeters()
        {
            return meters;
        }

        /// <summary>
        /// Returns the distance in centimeters.
        /// </summary>
        /// <returns>The distance in centimeters.</returns>
        public double ToCentimeters()
        {
            return MetricCalculator.MetersToCentimeters(meters);
        }

        /// <summary>
        /// Returns the distance in kilometers.
        /// </summary>
        /// <returns>The distance in kilometers.</returns>
        public double ToKilometers()
        {
            return MetricCalculator.MetersToKilometers(meters);
        }

        #endregion

        #region Imperial

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="inches"/>.
        /// </summary>
        /// <param name="inches">The distance in inches.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 inch = 1000 thou</remarks>
        public static Distance FromInches(double inches)
        {
            var distance = ImperialCalculator.InchesToMeters(inches);
            return new Distance(distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="feet"/>.
        /// </summary>
        /// <param name="feet">The distance in feet.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 foot = 12 inches</remarks>
        public static Distance FromFeet(double feet)
        {
            var distance = ImperialCalculator.FeetToMeters(feet);
            return new Distance(distance);
        }

        /// <summary>
        /// Gets a new <see cref="Distance"/> from the distance in <paramref name="yards"/>.
        /// </summary>
        /// <param name="yards">The distance in yards.</param>
        /// <returns>A new <see cref="Distance"/> object.</returns>
        /// <remarks>1 yard = 3 feet</remarks>
        public static Distance FromYards(double yards)
        {
            var distance = ImperialCalculator.YardsToMeters(yards);
            return new Distance(distance);
        }

        /// <summary>
        /// Returns the distance in inches.
        /// </summary>
        /// <returns>The distance in inches.</returns>
        public double ToInches()
        {
            return ImperialCalculator.MetersToInches(meters);
        }

        /// <summary>
        /// Returns the distance in feet.
        /// </summary>
        /// <returns>The distance in feet.</returns>
        public double ToFeet()
        {
            return ImperialCalculator.MetersToFeet(meters);
        }

        /// <summary>
        /// Returns the distance in yards.
        /// </summary>
        /// <returns>The distance in yards.</returns>
        public double ToYards()
        {
            return ImperialCalculator.MetersToYards(meters);
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
            return string.Format("{0} m", ToMeters());
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

            return meters == other.meters;
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

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Distance)obj);
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
            return meters.GetHashCode();
        }

        #endregion

        #region Comarable
        public int CompareTo(Distance other)
        {
            return meters.CompareTo(other.meters);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Distance))
            {
                throw new InvalidCastException();
            }

            return CompareTo((Distance)obj);
        }
        #endregion
    }
}