using System.ComponentModel.DataAnnotations;

namespace CarbonCalculator.Home;

public sealed class Calculator(TransportsManager transportModesManager)
{
    private readonly CarbonCredit _carbonCredit = new(1_000, 50, 150);

    [Required(ErrorMessage = "⚠️ Por favor, preencha a origem.")]
    public string Origin { get; set; } = string.Empty;

    [Required(ErrorMessage = "⚠️ Por favor, preencha o destino")]
    public string Destination { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "⚠️ Por favor, preencha a distância da viagem.")]
    public int DistanceInKm { get; set; }

    [Required]
    public TransportMode TransportMode { get; set; } = TransportMode.Car;

    public Transport SelectedTransport => transportModesManager.GetByMode(TransportMode);

    public string Route => $"{Origin} → {Destination}";

    public double CalculateEmissionByMode(TransportMode mode)
        => transportModesManager.GetByMode(mode).CalculateCarbonEmission(DistanceInKm);

    public (double SavedInKg, double SavedInPercentage) CalculateSavings(double emissionsInKg)
    {
        double carEmissions = CalculateEmissionByMode(TransportMode.Car);
        double savedInKg = carEmissions - emissionsInKg;
        double savedInPercentage = carEmissions > 0 ? (savedInKg / carEmissions) : 0;
        return (savedInKg, savedInPercentage);
    }

    public IEnumerable<ComparisonSummaryData> CalculateAllEmissions()
    {
        double carEmissions = CalculateEmissionByMode(TransportMode.Car);
        foreach (var transport in transportModesManager.GetAllTransports())
        {
            double emissionInKg = CalculateEmissionByMode(transport.Mode);
            double percentageRelatedToCar = carEmissions > 0 ? (emissionInKg / carEmissions) : 0;
            yield return new(
                transport,
                transport.Mode == SelectedTransport.Mode,
                emissionInKg,
                percentageRelatedToCar);
        }
    }

    public double CalculateCarbonCredits(double emissionsInKg)
        => emissionsInKg / _carbonCredit.KgPerCredit;

    public (double MinimumPriceInBrl, double MaximumPriceInBrl, double AveragePriceInBrl) EstimateCreditsPrice(double credits)
    {
        double minimumPrice = credits * _carbonCredit.MinimumPriceInBrl;
        double maximumPrice = credits * _carbonCredit.MaximumPriceInBrl;
        return (minimumPrice,
                maximumPrice,
                (minimumPrice + maximumPrice) / 2);
    }
}
