namespace AgendaTarefas.View.Forms
{
    partial class Configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            this.label1 = new System.Windows.Forms.Label();
            this.cbIniciarWindows = new System.Windows.Forms.CheckBox();
            this.cbHabilitarNoti = new System.Windows.Forms.CheckBox();
            this.cbIniciarMinimizado = new System.Windows.Forms.CheckBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb30Min = new System.Windows.Forms.RadioButton();
            this.rb1H = new System.Windows.Forms.RadioButton();
            this.rb2H = new System.Windows.Forms.RadioButton();
            this.btnConfigPadrao = new System.Windows.Forms.Button();
            this.rb10Min = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geral";
            // 
            // cbIniciarWindows
            // 
            this.cbIniciarWindows.AutoSize = true;
            this.cbIniciarWindows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIniciarWindows.Font = new System.Drawing.Font("Segoe UI", 14.2F);
            this.cbIniciarWindows.Location = new System.Drawing.Point(22, 177);
            this.cbIniciarWindows.Name = "cbIniciarWindows";
            this.cbIniciarWindows.Size = new System.Drawing.Size(312, 36);
            this.cbIniciarWindows.TabIndex = 1;
            this.cbIniciarWindows.Text = "Inicializar com o Windows";
            this.cbIniciarWindows.UseVisualStyleBackColor = true;
            this.cbIniciarWindows.Click += new System.EventHandler(this.cbIniciarWindows_Click);
            // 
            // cbHabilitarNoti
            // 
            this.cbHabilitarNoti.AutoSize = true;
            this.cbHabilitarNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHabilitarNoti.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbHabilitarNoti.Location = new System.Drawing.Point(22, 322);
            this.cbHabilitarNoti.Name = "cbHabilitarNoti";
            this.cbHabilitarNoti.Size = new System.Drawing.Size(263, 36);
            this.cbHabilitarNoti.TabIndex = 2;
            this.cbHabilitarNoti.Text = "Habilitar Notificações";
            this.cbHabilitarNoti.UseVisualStyleBackColor = true;
            this.cbHabilitarNoti.Click += new System.EventHandler(this.cbHabilitarNoti_Click);
            // 
            // cbIniciarMinimizado
            // 
            this.cbIniciarMinimizado.AutoSize = true;
            this.cbIniciarMinimizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIniciarMinimizado.Font = new System.Drawing.Font("Segoe UI", 14.2F);
            this.cbIniciarMinimizado.Location = new System.Drawing.Point(22, 219);
            this.cbIniciarMinimizado.Name = "cbIniciarMinimizado";
            this.cbIniciarMinimizado.Size = new System.Drawing.Size(267, 36);
            this.cbIniciarMinimizado.TabIndex = 3;
            this.cbIniciarMinimizado.Text = "Inicializar Minimizado";
            this.cbIniciarMinimizado.UseVisualStyleBackColor = true;
            this.cbIniciarMinimizado.Click += new System.EventHandler(this.cbIniciarMinimizado_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(437, 609);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(162, 36);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(15, 605);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inicialização";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Notificações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.2F);
            this.label4.Location = new System.Drawing.Point(16, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tempo da Notificação:";
            // 
            // rb30Min
            // 
            this.rb30Min.AutoSize = true;
            this.rb30Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb30Min.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.rb30Min.Location = new System.Drawing.Point(22, 450);
            this.rb30Min.Name = "rb30Min";
            this.rb30Min.Size = new System.Drawing.Size(138, 34);
            this.rb30Min.TabIndex = 9;
            this.rb30Min.TabStop = true;
            this.rb30Min.Text = "30 Minutos";
            this.rb30Min.UseVisualStyleBackColor = true;
            this.rb30Min.Click += new System.EventHandler(this.rb30Min_Click);
            // 
            // rb1H
            // 
            this.rb1H.AutoSize = true;
            this.rb1H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb1H.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.rb1H.Location = new System.Drawing.Point(21, 490);
            this.rb1H.Name = "rb1H";
            this.rb1H.Size = new System.Drawing.Size(96, 34);
            this.rb1H.TabIndex = 10;
            this.rb1H.TabStop = true;
            this.rb1H.Text = "1 Hora";
            this.rb1H.UseVisualStyleBackColor = true;
            this.rb1H.Click += new System.EventHandler(this.rb1H_Click);
            // 
            // rb2H
            // 
            this.rb2H.AutoSize = true;
            this.rb2H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb2H.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.rb2H.Location = new System.Drawing.Point(22, 530);
            this.rb2H.Name = "rb2H";
            this.rb2H.Size = new System.Drawing.Size(105, 34);
            this.rb2H.TabIndex = 11;
            this.rb2H.TabStop = true;
            this.rb2H.Text = "2 Horas";
            this.rb2H.UseVisualStyleBackColor = true;
            this.rb2H.Click += new System.EventHandler(this.rb2H_Click);
            // 
            // btnConfigPadrao
            // 
            this.btnConfigPadrao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigPadrao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigPadrao.Location = new System.Drawing.Point(269, 609);
            this.btnConfigPadrao.Name = "btnConfigPadrao";
            this.btnConfigPadrao.Size = new System.Drawing.Size(162, 36);
            this.btnConfigPadrao.TabIndex = 12;
            this.btnConfigPadrao.Text = "Padrão";
            this.btnConfigPadrao.UseVisualStyleBackColor = true;
            this.btnConfigPadrao.Click += new System.EventHandler(this.btnConfigPadrao_Click);
            // 
            // rb10Min
            // 
            this.rb10Min.AutoSize = true;
            this.rb10Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb10Min.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.rb10Min.Location = new System.Drawing.Point(21, 410);
            this.rb10Min.Name = "rb10Min";
            this.rb10Min.Size = new System.Drawing.Size(138, 34);
            this.rb10Min.TabIndex = 13;
            this.rb10Min.TabStop = true;
            this.rb10Min.Text = "10 Minutos";
            this.rb10Min.UseVisualStyleBackColor = true;
            this.rb10Min.Click += new System.EventHandler(this.rb10Min_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(612, 658);
            this.Controls.Add(this.rb10Min);
            this.Controls.Add(this.btnConfigPadrao);
            this.Controls.Add(this.rb2H);
            this.Controls.Add(this.rb1H);
            this.Controls.Add(this.rb30Min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cbIniciarMinimizado);
            this.Controls.Add(this.cbHabilitarNoti);
            this.Controls.Add(this.cbIniciarWindows);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Configuracoes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbIniciarWindows;
        private System.Windows.Forms.CheckBox cbHabilitarNoti;
        private System.Windows.Forms.CheckBox cbIniciarMinimizado;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb30Min;
        private System.Windows.Forms.RadioButton rb1H;
        private System.Windows.Forms.RadioButton rb2H;
        private System.Windows.Forms.Button btnConfigPadrao;
        private System.Windows.Forms.RadioButton rb10Min;
    }
}