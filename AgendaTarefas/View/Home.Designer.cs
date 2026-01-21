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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnCriarTarefa = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.btnEditarTarefa = new System.Windows.Forms.Button();
            this.pbExcluir = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbAjuda = new System.Windows.Forms.PictureBox();
            this.flpTarefas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).BeginInit();
            this.flpTarefas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(478, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "MINHA AGENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Título *";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Location = new System.Drawing.Point(643, 175);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(570, 43);
            this.lbTitulo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // rtDescricao
            // 
            this.rtDescricao.Location = new System.Drawing.Point(643, 308);
            this.rtDescricao.Name = "rtDescricao";
            this.rtDescricao.Size = new System.Drawing.Size(570, 334);
            this.rtDescricao.TabIndex = 5;
            this.rtDescricao.Text = "";
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCriarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarTarefa.Location = new System.Drawing.Point(855, 684);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Size = new System.Drawing.Size(358, 73);
            this.btnCriarTarefa.TabIndex = 6;
            this.btnCriarTarefa.Text = "Criar Tarefa";
            this.btnCriarTarefa.UseVisualStyleBackColor = false;
            this.btnCriarTarefa.Click += new System.EventHandler(this.btnCriarTarefa_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.BackColor = System.Drawing.Color.IndianRed;
            this.btnExcluirTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirTarefa.Location = new System.Drawing.Point(639, 684);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(102, 73);
            this.btnExcluirTarefa.TabIndex = 7;
            this.btnExcluirTarefa.UseVisualStyleBackColor = false;
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.BackColor = System.Drawing.Color.Silver;
            this.btnEditarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarTarefa.Location = new System.Drawing.Point(747, 684);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(102, 73);
            this.btnEditarTarefa.TabIndex = 8;
            this.btnEditarTarefa.UseVisualStyleBackColor = false;
            // 
            // pbExcluir
            // 
            this.pbExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.pbExcluir.Enabled = false;
            this.pbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("pbExcluir.Image")));
            this.pbExcluir.Location = new System.Drawing.Point(664, 702);
            this.pbExcluir.Name = "pbExcluir";
            this.pbExcluir.Size = new System.Drawing.Size(51, 42);
            this.pbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExcluir.TabIndex = 9;
            this.pbExcluir.TabStop = false;
            // 
            // pbEditar
            // 
            this.pbEditar.BackColor = System.Drawing.Color.Silver;
            this.pbEditar.Enabled = false;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(772, 702);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(51, 42);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEditar.TabIndex = 10;
            this.pbEditar.TabStop = false;
            // 
            // pbAjuda
            // 
            this.pbAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("pbAjuda.Image")));
            this.pbAjuda.Location = new System.Drawing.Point(1175, 13);
            this.pbAjuda.Name = "pbAjuda";
            this.pbAjuda.Size = new System.Drawing.Size(38, 35);
            this.pbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAjuda.TabIndex = 11;
            this.pbAjuda.TabStop = false;
            // 
            // flpTarefas
            // 
            this.flpTarefas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTarefas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTarefas.Controls.Add(this.panel1);
            this.flpTarefas.Location = new System.Drawing.Point(13, 124);
            this.flpTarefas.Name = "flpTarefas";
            this.flpTarefas.Size = new System.Drawing.Size(588, 620);
            this.flpTarefas.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 100);
            this.panel1.TabIndex = 0;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1226, 776);
            this.Controls.Add(this.flpTarefas);
            this.Controls.Add(this.pbAjuda);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbExcluir);
            this.Controls.Add(this.btnEditarTarefa);
            this.Controls.Add(this.btnExcluirTarefa);
            this.Controls.Add(this.btnCriarTarefa);
            this.Controls.Add(this.rtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda C# - João Guilherme de Oliveira";
            ((System.ComponentModel.ISupportInitialize)(this.pbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).EndInit();
            this.flpTarefas.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Button btnEditarTarefa;
        private System.Windows.Forms.PictureBox pbExcluir;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbAjuda;
        private System.Windows.Forms.FlowLayoutPanel flpTarefas;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Panel panel1;
    }
}

