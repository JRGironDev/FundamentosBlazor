namespace FundamentosBlazor.Data;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IDatosDemo _bd;

    public WeatherForecastService(IDatosDemo bd)
    {
        _bd = bd;
    }

    public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        // Clase inyección de dependencia
        var rnd = new Random();
        int numMaximo = _bd.GetEdad();

        return Task.FromResult(Enumerable.Range(1, numMaximo).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }
}
