namespace CarbonCalculator.Home;

public record ComparisonSummaryData(
    Transport Transport,
    bool IsSelected,
    double EmissionInKg,
    double PercentageVsCar);
