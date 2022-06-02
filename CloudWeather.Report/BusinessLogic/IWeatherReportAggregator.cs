using CloudWeather.Report.DataAccess;

namespace CloudWeather.Report.BusinessLogic
{
    public interface IWeatherReportAggregator
    {
        public Task<WeatherReport> BuildReport(string zip, int days);
    }
}
