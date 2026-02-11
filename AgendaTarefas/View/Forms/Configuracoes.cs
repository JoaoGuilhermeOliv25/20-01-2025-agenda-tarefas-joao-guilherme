using AgendaTarefas.Infrastructure.Configuration;
using AgendaTarefas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTarefas.View.Forms
{
    public partial class Configuracoes : Form
    {
        AppSettings config;

        public Configuracoes()
        {
            InitializeComponent();
        }


        // Ao carregar o Form:
        private void Configuracoes_Load(object sender, EventArgs e)
        {
            config = SettingsManager.CarregarConfig();
            AplicarConfigCarregadaUI();

            
        }


        // Método para aplciar as configs feitas pelo usuário
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja aplicar as alterações feitas?", "Aplicar Configurações", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (msg == DialogResult.Yes)
            {

                AppSettings novaConfig = new AppSettings(
                    cbIniciarWindows.Checked,
                    cbIniciarMinimizado.Checked,
                    cbHabilitarNoti.Checked,
                    rb30Min.Checked ? 1800000 : rb1H.Checked ? 3600000 : rb2H.Checked ? 7200000 : 1800000
                );
                SettingsManager.SalvarConfig(novaConfig);
                Application.Restart();
            }

        }




        // Método para aplicar as configs feitas pelo usuário na interface
        private void AplicarConfigCarregadaUI()
        {
            if (config.iniciarWindows) cbIniciarWindows.Checked = true;
            else cbIniciarWindows.Checked = false;

            if (config.mostrarNotificacoes) cbHabilitarNoti.Checked = true;
            else cbHabilitarNoti.Checked = false;

            if (config.iniciarMinimizado) cbIniciarMinimizado.Checked = true;
            else cbIniciarMinimizado.Checked = false;


            // Tempo das notificações:
            switch (config.tempoNotificacao)
            {
                // 30min
                case 1800000:
                    rb30Min.Checked = true;
                    break;

                // 1H
                case 3600000:
                    rb1H.Checked = true;
                    break;

                // 2H
                case 7200000:
                    rb2H.Checked = true;
                    break;

                default:
                    rb30Min.Enabled = false;
                    rb1H.Enabled = false;
                    rb2H.Enabled = false;
                    break;
            }

        }

    }
}
