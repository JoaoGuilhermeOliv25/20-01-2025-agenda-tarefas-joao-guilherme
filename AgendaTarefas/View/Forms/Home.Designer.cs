namespace AgendaTarefas
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnCriarTarefa = new System.Windows.Forms.Button();
            this.flpTarefas = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnTodasT = new System.Windows.Forms.Button();
            this.btnNFinalizadas = new System.Windows.Forms.Button();
            this.btnFinalizadas = new System.Windows.Forms.Button();
            this.pbSettings1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(527, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "MINHA AGENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Título *";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Location = new System.Drawing.Point(679, 175);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(570, 43);
            this.lbTitulo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // rtDescricao
            // 
            this.rtDescricao.Location = new System.Drawing.Point(679, 298);
            this.rtDescricao.Name = "rtDescricao";
            this.rtDescricao.Size = new System.Drawing.Size(570, 184);
            this.rtDescricao.TabIndex = 5;
            this.rtDescricao.Text = "";
            this.rtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtDescricao_KeyPress);
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCriarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarTarefa.Location = new System.Drawing.Point(679, 647);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Size = new System.Drawing.Size(570, 73);
            this.btnCriarTarefa.TabIndex = 6;
            this.btnCriarTarefa.Text = "Criar Tarefa";
            this.btnCriarTarefa.UseVisualStyleBackColor = false;
            this.btnCriarTarefa.Click += new System.EventHandler(this.btnCriarTarefa_Click);
            // 
            // flpTarefas
            // 
            this.flpTarefas.AutoScroll = true;
            this.flpTarefas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTarefas.BackColor = System.Drawing.SystemColors.Control;
            this.flpTarefas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTarefas.Location = new System.Drawing.Point(13, 124);
            this.flpTarefas.Name = "flpTarefas";
            this.flpTarefas.Size = new System.Drawing.Size(638, 596);
            this.flpTarefas.TabIndex = 12;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // btnTodasT
            // 
            this.btnTodasT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodasT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodasT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTodasT.Location = new System.Drawing.Point(13, 91);
            this.btnTodasT.Name = "btnTodasT";
            this.btnTodasT.Size = new System.Drawing.Size(128, 35);
            this.btnTodasT.TabIndex = 13;
            this.btnTodasT.Text = "Todas";
            this.btnTodasT.UseVisualStyleBackColor = true;
            this.btnTodasT.Click += new System.EventHandler(this.btnTodasT_Click);
            // 
            // btnNFinalizadas
            // 
            this.btnNFinalizadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNFinalizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNFinalizadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNFinalizadas.Location = new System.Drawing.Point(138, 91);
            this.btnNFinalizadas.Name = "btnNFinalizadas";
            this.btnNFinalizadas.Size = new System.Drawing.Size(203, 35);
            this.btnNFinalizadas.TabIndex = 14;
            this.btnNFinalizadas.Text = "Não Finalizadas";
            this.btnNFinalizadas.UseVisualStyleBackColor = true;
            this.btnNFinalizadas.Click += new System.EventHandler(this.btnNFinalizadas_Click);
            // 
            // btnFinalizadas
            // 
            this.btnFinalizadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFinalizadas.Location = new System.Drawing.Point(338, 91);
            this.btnFinalizadas.Name = "btnFinalizadas";
            this.btnFinalizadas.Size = new System.Drawing.Size(171, 35);
            this.btnFinalizadas.TabIndex = 15;
            this.btnFinalizadas.Text = "Finalizadas";
            this.btnFinalizadas.UseVisualStyleBackColor = true;
            this.btnFinalizadas.Click += new System.EventHandler(this.btnFinalizadas_Click);
            // 
            // pbSettings1
            // 
            this.pbSettings1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings1.Image = ((System.Drawing.Image)(resources.GetObject("pbSettings1.Image")));
            this.pbSettings1.Location = new System.Drawing.Point(1216, 13);
            this.pbSettings1.Name = "pbSettings1";
            this.pbSettings1.Size = new System.Drawing.Size(33, 33);
            this.pbSettings1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettings1.TabIndex = 16;
            this.pbSettings1.TabStop = false;
            this.pbSettings1.Click += new System.EventHandler(this.pbSettings1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 787);
            this.Controls.Add(this.pbSettings1);
            this.Controls.Add(this.btnFinalizadas);
            this.Controls.Add(this.btnNFinalizadas);
            this.Controls.Add(this.btnTodasT);
            this.Controls.Add(this.flpTarefas);
            this.Controls.Add(this.btnCriarTarefa);
            this.Controls.Add(this.rtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Tarefas - 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtDescricao;
        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.FlowLayoutPanel flpTarefas;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnTodasT;
        private System.Windows.Forms.Button btnNFinalizadas;
        private System.Windows.Forms.Button btnFinalizadas;
        private System.Windows.Forms.PictureBox pbSettings1;
    }
}

