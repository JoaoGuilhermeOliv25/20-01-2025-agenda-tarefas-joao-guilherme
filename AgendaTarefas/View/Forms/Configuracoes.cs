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
        bool alterou = false;
        public static int tempNotificacao;

        public Configuracoes()
        {
            InitializeComponent();
        }


        // Ao carregar o Form:
        private void Configuracoes_Load(object sender, EventArgs e)
        {
            config = SettingsManager.CarregarConfig();
            AplicarConfigCarregadaUI();
            VerificarAplicacaoConfig();
        }


        // Método para aplciar as configs feitas pelo usuário
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja aplicar as alterações feitas? O programa será reiniciado.",
                "Aplicar Configurações", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (msg == DialogResult.Yes)
            {

                AppSettings novaConfig = new AppSettings(
                    cbIniciarWindows.Checked,
                    cbIniciarMinimizado.Checked,
                    cbHabilitarNoti.Checked,
                    rb30Min.Checked ? 1000 : rb1H.Checked ? 3600000 : rb2H.Checked ? 7200000 : 1800000
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

            if (config.iniciarMinimizado) cbIniciarMinimizado.Checked = true;
            else cbIniciarMinimizado.Checked = false;


            if (config.mostrarNotificacoes)
            {
                cbHabilitarNoti.Checked = true;
                rb30Min.Enabled = true;
                rb1H.Enabled = true;
                rb2H.Enabled = true;

                // Tempo das notificações:
                switch (config.tempoNotificacao)
                {
                    // 30min
                    case 1000:
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
                        rb30Min.Checked = true;
                        rb30Min.Enabled = false;
                        rb1H.Enabled = false;
                        rb2H.Enabled = false;
                        break;
                }
            }
            else
            {
                cbHabilitarNoti.Checked = false;
                rb30Min.Checked = true;
                rb30Min.Enabled = false;
                rb1H.Enabled = false;
                rb2H.Enabled = false;
            }
        }


        



        // ALTERAÇÕES DA CONFIGURAÇÃO

        // Habilita e desabilita o botão de aplicação
        private void VerificarAplicacaoConfig()
        {
            if (alterou)
            {
                btnAplicar.Enabled = true;
            }
            else
            {
                btnAplicar.Enabled = false;
            }
        }

        // Eventos de alteração das configs:
        private void cbIniciarWindows_Click(object sender, EventArgs e)
        {
            alterou = true;
            VerificarAplicacaoConfig();
        }

        private void cbIniciarMinimizado_Click(object sender, EventArgs e)
        {
            alterou = true;
            VerificarAplicacaoConfig();
        }


        // Verifica se as notificações foram habilitadas ou desabilitadas
        private void cbHabilitarNoti_Click(object sender, EventArgs e)
        {
            alterou = true;

            if (cbHabilitarNoti.Checked)
            {
                rb30Min.Enabled = true;
                rb1H.Enabled = true;
                rb2H.Enabled = true;
            }
            else
            {
                rb30Min.Enabled = false;
                rb1H.Enabled = false;
                rb2H.Enabled = false;
            }

            VerificarAplicacaoConfig();
        }

        private void rb30Min_Click(object sender, EventArgs e)
        {
            alterou = true;
            VerificarAplicacaoConfig();
        }

        private void rb1H_Click(object sender, EventArgs e)
        {
            alterou = true;
            VerificarAplicacaoConfig();
        }

        private void rb2H_Click(object sender, EventArgs e)
        {
            alterou = true;
            VerificarAplicacaoConfig();
        }



        // Cancelar alterações
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Aplicar as configurações padrões
        private void btnConfigPadrao_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja aplicar as configurações padrões? O programa será reiniciado.",
                "Configurações Padrão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (msg == DialogResult.Yes)
            {
                config = SettingsManager.ConfigPadrao();
                AplicarConfigCarregadaUI();
                SettingsManager.SalvarConfig(config);

                Application.Restart();
            }
        }
    }
}
