namespace CarbonCalculator.Home;

public class TransportsManager(ILogger<RoutesManager> logger)
{
    private readonly IEnumerable<Transport> _transports = [
        new (TransportMode.Bicycle, "Bicicleta", 0.0, "🚲"),
        new (TransportMode.Car, "Carro",0.12,"🚗"),
        new (TransportMode.Bus, "Ônibus",0.089,"🚌"),
        new (TransportMode.Truck, "Caminhão",0.96,"🚚")
        ];

    public IEnumerable<Transport> GetAllTransports()
    {
        logger.LogInformation("Carregando meios de transportes...");
        return _transports;
    }

    public Transport GetByMode(TransportMode mode)
        => _transports
            .FirstOrDefault(
                transport => transport.Mode == mode,
                _transports.Single(transport => transport.Mode == TransportMode.Car));
}
