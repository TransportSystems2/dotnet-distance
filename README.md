dotnet-distance
===============

.NET object to handle distance.

Available as a [package on NuGet](http://www.nuget.org/packages/Tripsis.DistanceModel/).


## Usage
So you can do things like this:

    var distance = Distance.FromMeters(100);
    var miles = distance.ToMiles();
    var leagues = distance.ToLeagues();
    
Supports operators as well:

    var distance1 = Distance.FromYards(300);
    var distance2 = Distance.FromThou(1000);
    var totalMeters = (distance1 + distance2).ToMeters();
    
## Supported Units
### Metric
- Millimeters
- Centimeters
- Meters
- Kilometers

### Imperial
- Thou
- Inches
- Feet
- Yards
- Chains
- Furlongs
- Miles
- Leagues
