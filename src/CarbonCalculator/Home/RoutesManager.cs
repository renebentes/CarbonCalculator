using System.Net.Http.Json;

namespace CarbonCalculator.Home;

public class RoutesManager(
    HttpClient httpClient,
    ILogger<RoutesManager> logger)
{
    private Route[] _routes = [];

    public async Task<IEnumerable<string>> GetAllCitiesAsync()
    {
        try
        {
            logger.LogInformation("Carregando dados das rotas...");
            _routes = await httpClient.GetFromJsonAsync<Route[]>("data/routes.json")
                ?? [];

            return _routes
                .SelectMany(r => new[] { r.Origin, r.Destination })
                .Distinct()
                .Order();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "❌ Erro ao carregar os dados das rotas!");
            throw;
        }
    }

    public int GetDistance(string origin, string destination)
    {
        Route? route = _routes
            .FirstOrDefault(r =>
            (r.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase)
                && r.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
            || (r.Origin.Equals(destination, StringComparison.OrdinalIgnoreCase)
                && r.Destination.Equals(origin, StringComparison.OrdinalIgnoreCase)));

        return route?.DistanceInKm ?? 0;
    }
}
