using AgendaTarefas.Model;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaTarefas.View.Forms;

namespace AgendaTarefas.Infrastructure.Configuration
{
    public class SettingsManager
    {
        private const string JsonPath = "appsettings.json";


        // Carrega a configuração do arquivo JSON
        public static AppSettings CarregarConfig()
        {
            if (!File.Exists(JsonPath))
            {
                var configPadrao = ConfigPadrao();
                SalvarConfig(configPadrao);
                return configPadrao;
            }
            else
            {
                var json = File.ReadAllText(JsonPath);
                return JsonSerializer.Deserialize<AppSettings>(json);
            }
        }


        // Salva as configurações no arquivo JSON
        public static void SalvarConfig(AppSettings app)
        {
            var json = JsonSerializer.Serialize(app, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(JsonPath, json);
        }


        // Aplica a config padrão
        public static AppSettings ConfigPadrao()
        {
            return new AppSettings
            (
                iniciarWindows: true,
                iniciarMinimizado: false,
                mostrarNotificacoes: true,
                tempoNotificacao: 1000
            // tempoNotificacao: 3600000
            );
        }
    }
}
