using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Persona5Royal.Utilities
{
    public static class UrlJson
    {
        public static void OpenWebPage(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo(url)
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la página web: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetGuideURLFromAppSettings(string key)
        {
            string appSettingsFile = "appsettings.json";
            string jsonString = File.ReadAllText(appSettingsFile);
            var appSettings = JsonSerializer.Deserialize<JsonElement>(jsonString);

            if (appSettings.TryGetProperty(key, out var value) && value.ValueKind == JsonValueKind.String)
            {
                return value.GetString();
            }
            else
            {
                MessageBox.Show("La URL no está definida en la configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
