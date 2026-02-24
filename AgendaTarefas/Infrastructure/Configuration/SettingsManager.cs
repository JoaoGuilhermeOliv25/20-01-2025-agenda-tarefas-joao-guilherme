using AgendaTarefas.Model;
using System.Text.Json;
using System;
using System.IO;

namespace AgendaTarefas.Infrastructure.Configuration
{
    public class SettingsManager
    {
        private static readonly string PastaApp =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "AgendaTarefas");

        private static readonly string JsonPath =
            Path.Combine(PastaApp, "appsettings.json");


        public static AppSettings CarregarConfig()
        {
            Directory.CreateDirectory(PastaApp);

            if (!File.Exists(JsonPath))
            {
                var configPadrao = ConfigPadrao();
                SalvarConfig(configPadrao);
                return configPadrao;
            }

            var json = File.ReadAllText(JsonPath);
            return JsonSerializer.Deserialize<AppSettings>(json);
        }


        public static void SalvarConfig(AppSettings app)
        {
            Directory.CreateDirectory(PastaApp);

            var json = JsonSerializer.Serialize(app, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(JsonPath, json);
        }


        public static AppSettings ConfigPadrao()
        {
            return new AppSettings(
                iniciarWindows: true,
                iniciarMinimizado: false,
                mostrarNotificacoes: true,
                tempoNotificacao: 600000
            );
        }
    }
}