using System.Text.Json;

namespace AutomationFramework.Utilities
{
    public class ConfigReader
    {
        private readonly JsonElement config;

        public ConfigReader()
        {
            string json = File.ReadAllText("C:\\Users\\luisb\\OneDrive\\Documentos\\Automation Projects\\AutomationPracticeNUnit\\AutomationPracticeNUnit\\Configuration\\settings.js");

            config = JsonSerializer.Deserialize<JsonElement>(json);
        }

        public string Environment =>
            config.GetProperty("Environment").GetString()!;

        public string BaseUrl =>
            config.GetProperty("BaseUrl").GetString()!;

        public string Browser =>
            config.GetProperty("Browser").GetString()!;

        public int Timeout =>
            config.GetProperty("Timeout").GetInt32();
    }
}