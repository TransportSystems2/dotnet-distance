dotnet-distance
===============

.NET object to handle distance.

Available as a [package on NuGet](http://www.nuget.org/packages/Tripsis.DistanceModel/).


## Usage
So you can do things like this:

    var distance = Distance.FromMeters(100);
    var feet = distance.ToFeet();
    var yards = distance.ToYards();
    
Supports operators as well:

    var distance1 = Distance.FromYards(300);
    var distance2 = Distance.FromThou(1000);
    var totalMeters = (distance1 + distance2).ToMeters();
    
    var listOfDistance = new List<Distance> { distance1, distance2 };
    var totalMeters = listOfDistance.Sum().ToMeters();
    
## Supported Units
### Metric
- Centimeters
- Meters
- Kilometers

### Imperial
- Inches
- Feet
- Yards
- Miles
