using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetDistance
{
    public static class DistanceExtensions
    {
        public static Distance Sum<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, Distance> selector)
        {
            return source.Select(selector).Aggregate(Distance.FromMeters(0), (t1, t2) => t1 + t2);
        }

        public static Distance Sum(this IEnumerable<Distance> source)
        {
            return source.Aggregate(Distance.FromMeters(0), (t1, t2) => t1 + t2);
        }
    }
}