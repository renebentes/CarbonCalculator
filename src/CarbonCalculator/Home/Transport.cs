namespace CarbonCalculator.Home;

public sealed record Transport(
    TransportMode Mode,
    string Name,
    double EmissionFactor,
    string Icon)
{
    public double CalculateCarbonEmission(int distanceInKm)
        => distanceInKm * EmissionFactor;
}
