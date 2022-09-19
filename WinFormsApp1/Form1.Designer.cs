namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buscarJogo = new System.Windows.Forms.Button();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.cbShooter = new System.Windows.Forms.CheckBox();
            this.cbMmorpg = new System.Windows.Forms.CheckBox();
            this.cbStrategy = new System.Windows.Forms.CheckBox();
            this.cbMoba = new System.Windows.Forms.CheckBox();
            this.cbCorrida = new System.Windows.Forms.CheckBox();
            this.cbEsportes = new System.Windows.Forms.CheckBox();
            this.cbSocial = new System.Windows.Forms.CheckBox();
            this.cbSandbox = new System.Windows.Forms.CheckBox();
            this.cbMundoAberto = new System.Windows.Forms.CheckBox();
            this.cbSobrevivencia = new System.Windows.Forms.CheckBox();
            this.cbPVP = new System.Windows.Forms.CheckBox();
            this.cbPixelado = new System.Windows.Forms.CheckBox();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarJogo
            // 
            this.buscarJogo.Location = new System.Drawing.Point(57, 176);
            this.buscarJogo.Name = "buscarJogo";
            this.buscarJogo.Size = new System.Drawing.Size(660, 29);
            this.buscarJogo.TabIndex = 0;
            this.buscarJogo.Text = "Buscar Jogo";
            this.buscarJogo.UseVisualStyleBackColor = true;
            this.buscarJogo.Click += new System.EventHandler(this.buscarJogo_Click);
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.cbPixelado);
            this.gbGenero.Controls.Add(this.cbPVP);
            this.gbGenero.Controls.Add(this.cbSobrevivencia);
            this.gbGenero.Controls.Add(this.cbMundoAberto);
            this.gbGenero.Controls.Add(this.cbSandbox);
            this.gbGenero.Controls.Add(this.cbSocial);
            this.gbGenero.Controls.Add(this.cbEsportes);
            this.gbGenero.Controls.Add(this.cbCorrida);
            this.gbGenero.Controls.Add(this.cbMoba);
            this.gbGenero.Controls.Add(this.cbStrategy);
            this.gbGenero.Controls.Add(this.cbShooter);
            this.gbGenero.Controls.Add(this.cbMmorpg);
            this.gbGenero.Location = new System.Drawing.Point(62, 38);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(655, 125);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Gênero";
            this.gbGenero.Enter += new System.EventHandler(this.gbGenero_Enter);
            // 
            // cbShooter
            // 
            this.cbShooter.AutoSize = true;
            this.cbShooter.Location = new System.Drawing.Point(6, 42);
            this.cbShooter.Name = "cbShooter";
            this.cbShooter.Size = new System.Drawing.Size(83, 24);
            this.cbShooter.TabIndex = 1;
            this.cbShooter.Text = "Shooter";
            this.cbShooter.UseVisualStyleBackColor = true;
            // 
            // cbMmorpg
            // 
            this.cbMmorpg.AutoSize = true;
            this.cbMmorpg.Checked = true;
            this.cbMmorpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMmorpg.Location = new System.Drawing.Point(6, 23);
            this.cbMmorpg.Name = "cbMmorpg";
            this.cbMmorpg.Size = new System.Drawing.Size(95, 24);
            this.cbMmorpg.TabIndex = 0;
            this.cbMmorpg.Text = "MMORPG";
            this.cbMmorpg.UseVisualStyleBackColor = true;
            // 
            // cbStrategy
            // 
            this.cbStrategy.AutoSize = true;
            this.cbStrategy.Location = new System.Drawing.Point(6, 62);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(97, 24);
            this.cbStrategy.TabIndex = 2;
            this.cbStrategy.Text = "Estrategia";
            this.cbStrategy.UseVisualStyleBackColor = true;
            // 
            // cbMoba
            // 
            this.cbMoba.AutoSize = true;
            this.cbMoba.Location = new System.Drawing.Point(5, 84);
            this.cbMoba.Name = "cbMoba";
            this.cbMoba.Size = new System.Drawing.Size(70, 24);
            this.cbMoba.TabIndex = 3;
            this.cbMoba.Text = "Moba";
            this.cbMoba.UseVisualStyleBackColor = true;
            // 
            // cbCorrida
            // 
            this.cbCorrida.AutoSize = true;
            this.cbCorrida.Location = new System.Drawing.Point(108, 24);
            this.cbCorrida.Name = "cbCorrida";
            this.cbCorrida.Size = new System.Drawing.Size(80, 24);
            this.cbCorrida.TabIndex = 4;
            this.cbCorrida.Text = "Corrida";
            this.cbCorrida.UseVisualStyleBackColor = true;
            // 
            // cbEsportes
            // 
            this.cbEsportes.AutoSize = true;
            this.cbEsportes.Location = new System.Drawing.Point(108, 47);
            this.cbEsportes.Name = "cbEsportes";
            this.cbEsportes.Size = new System.Drawing.Size(87, 24);
            this.cbEsportes.TabIndex = 5;
            this.cbEsportes.Text = "Esportes";
            this.cbEsportes.UseVisualStyleBackColor = true;
            // 
            // cbSocial
            // 
            this.cbSocial.AutoSize = true;
            this.cbSocial.Location = new System.Drawing.Point(107, 68);
            this.cbSocial.Name = "cbSocial";
            this.cbSocial.Size = new System.Drawing.Size(71, 24);
            this.cbSocial.TabIndex = 6;
            this.cbSocial.Text = "Social";
            this.cbSocial.UseVisualStyleBackColor = true;
            // 
            // cbSandbox
            // 
            this.cbSandbox.AutoSize = true;
            this.cbSandbox.Location = new System.Drawing.Point(106, 88);
            this.cbSandbox.Name = "cbSandbox";
            this.cbSandbox.Size = new System.Drawing.Size(89, 24);
            this.cbSandbox.TabIndex = 7;
            this.cbSandbox.Text = "Sandbox";
            this.cbSandbox.UseVisualStyleBackColor = true;
            // 
            // cbMundoAberto
            // 
            this.cbMundoAberto.AutoSize = true;
            this.cbMundoAberto.Location = new System.Drawing.Point(196, 24);
            this.cbMundoAberto.Name = "cbMundoAberto";
            this.cbMundoAberto.Size = new System.Drawing.Size(128, 24);
            this.cbMundoAberto.TabIndex = 8;
            this.cbMundoAberto.Text = "Mundo Aberto";
            this.cbMundoAberto.UseVisualStyleBackColor = true;
            // 
            // cbSobrevivencia
            // 
            this.cbSobrevivencia.AutoSize = true;
            this.cbSobrevivencia.Location = new System.Drawing.Point(195, 48);
            this.cbSobrevivencia.Name = "cbSobrevivencia";
            this.cbSobrevivencia.Size = new System.Drawing.Size(123, 24);
            this.cbSobrevivencia.TabIndex = 9;
            this.cbSobrevivencia.Text = "Sobrevivência";
            this.cbSobrevivencia.UseVisualStyleBackColor = true;
            // 
            // cbPVP
            // 
            this.cbPVP.AutoSize = true;
            this.cbPVP.Location = new System.Drawing.Point(197, 70);
            this.cbPVP.Name = "cbPVP";
            this.cbPVP.Size = new System.Drawing.Size(56, 24);
            this.cbPVP.TabIndex = 10;
            this.cbPVP.Text = "PVP";
            this.cbPVP.UseVisualStyleBackColor = true;
            // 
            // cbPixelado
            // 
            this.cbPixelado.AutoSize = true;
            this.cbPixelado.Location = new System.Drawing.Point(195, 92);
            this.cbPixelado.Name = "cbPixelado";
            this.cbPixelado.Size = new System.Drawing.Size(88, 24);
            this.cbPixelado.TabIndex = 11;
            this.cbPixelado.Text = "Pixelado";
            this.cbPixelado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.buscarJogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buscarJogo;
        private GroupBox gbGenero;
        private CheckBox cbShooter;
        private CheckBox cbMmorpg;
        private CheckBox cbPixelado;
        private CheckBox cbPVP;
        private CheckBox cbSobrevivencia;
        private CheckBox cbMundoAberto;
        private CheckBox cbSandbox;
        private CheckBox cbSocial;
        private CheckBox cbEsportes;
        private CheckBox cbCorrida;
        private CheckBox cbMoba;
        private CheckBox cbStrategy;
    }
}