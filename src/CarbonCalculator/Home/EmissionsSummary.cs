namespace CarbonCalculator.Home;

public sealed record EmissionsSummary(
    string Route,
    Transport Transport,
    double CarbonEmissionInKg,
    double BaselineEmissionInKg,
    int DistanceInKm,
    (double SavedInKg, double SavedInPercentage) Saving);
