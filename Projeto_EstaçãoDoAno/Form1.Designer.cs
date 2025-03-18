namespace Projeto_EstaçãoDoAno
{
    partial class Frm_Estacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estacoes));
            this.Grp_Estacoes = new System.Windows.Forms.GroupBox();
            this.Rad_Inverno = new System.Windows.Forms.RadioButton();
            this.Rad_Outono = new System.Windows.Forms.RadioButton();
            this.Rad_Verao = new System.Windows.Forms.RadioButton();
            this.Rad_Primavera = new System.Windows.Forms.RadioButton();
            this.Pic_Image = new System.Windows.Forms.PictureBox();
            this.Txt_resultado = new System.Windows.Forms.TextBox();
            this.Grp_Estacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_Estacoes
            // 
            this.Grp_Estacoes.Controls.Add(this.Rad_Inverno);
            this.Grp_Estacoes.Controls.Add(this.Rad_Outono);
            this.Grp_Estacoes.Controls.Add(this.Rad_Verao);
            this.Grp_Estacoes.Controls.Add(this.Rad_Primavera);
            this.Grp_Estacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Estacoes.Location = new System.Drawing.Point(42, 101);
            this.Grp_Estacoes.Name = "Grp_Estacoes";
            this.Grp_Estacoes.Size = new System.Drawing.Size(220, 265);
            this.Grp_Estacoes.TabIndex = 0;
            this.Grp_Estacoes.TabStop = false;
            this.Grp_Estacoes.Text = "Estações";
            this.Grp_Estacoes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Rad_Inverno
            // 
            this.Rad_Inverno.AutoSize = true;
            this.Rad_Inverno.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Inverno.Location = new System.Drawing.Point(24, 226);
            this.Rad_Inverno.Name = "Rad_Inverno";
            this.Rad_Inverno.Size = new System.Drawing.Size(113, 35);
            this.Rad_Inverno.TabIndex = 4;
            this.Rad_Inverno.Text = "Inverno";
            this.Rad_Inverno.UseVisualStyleBackColor = true;
            this.Rad_Inverno.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Rad_Outono
            // 
            this.Rad_Outono.AutoSize = true;
            this.Rad_Outono.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Outono.Location = new System.Drawing.Point(24, 172);
            this.Rad_Outono.Name = "Rad_Outono";
            this.Rad_Outono.Size = new System.Drawing.Size(112, 35);
            this.Rad_Outono.TabIndex = 3;
            this.Rad_Outono.Text = "Outono";
            this.Rad_Outono.UseVisualStyleBackColor = true;
            this.Rad_Outono.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Rad_Verao
            // 
            this.Rad_Verao.AutoSize = true;
            this.Rad_Verao.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Verao.Location = new System.Drawing.Point(25, 115);
            this.Rad_Verao.Name = "Rad_Verao";
            this.Rad_Verao.Size = new System.Drawing.Size(94, 35);
            this.Rad_Verao.TabIndex = 2;
            this.Rad_Verao.Text = "Verão";
            this.Rad_Verao.UseVisualStyleBackColor = true;
            this.Rad_Verao.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Rad_Primavera
            // 
            this.Rad_Primavera.AutoSize = true;
            this.Rad_Primavera.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Primavera.Location = new System.Drawing.Point(25, 58);
            this.Rad_Primavera.Name = "Rad_Primavera";
            this.Rad_Primavera.Size = new System.Drawing.Size(139, 35);
            this.Rad_Primavera.TabIndex = 1;
            this.Rad_Primavera.Text = "Primavera";
            this.Rad_Primavera.UseVisualStyleBackColor = true;
            this.Rad_Primavera.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Pic_Image
            // 
            this.Pic_Image.Location = new System.Drawing.Point(281, 77);
            this.Pic_Image.Name = "Pic_Image";
            this.Pic_Image.Size = new System.Drawing.Size(457, 289);
            this.Pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Image.TabIndex = 2;
            this.Pic_Image.TabStop = false;
            // 
            // Txt_resultado
            // 
            this.Txt_resultado.Enabled = false;
            this.Txt_resultado.Location = new System.Drawing.Point(42, 77);
            this.Txt_resultado.Name = "Txt_resultado";
            this.Txt_resultado.Size = new System.Drawing.Size(220, 20);
            this.Txt_resultado.TabIndex = 5;
            this.Txt_resultado.TextChanged += new System.EventHandler(this.Txt_resultado_TextChanged);
            // 
            // Frm_Estacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_resultado);
            this.Controls.Add(this.Pic_Image);
            this.Controls.Add(this.Grp_Estacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Estacoes";
            this.Text = "Estações do Ano";
            this.Grp_Estacoes.ResumeLayout(false);
            this.Grp_Estacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Estacoes;
        private System.Windows.Forms.RadioButton Rad_Inverno;
        private System.Windows.Forms.RadioButton Rad_Outono;
        private System.Windows.Forms.RadioButton Rad_Verao;
        private System.Windows.Forms.RadioButton Rad_Primavera;
        private System.Windows.Forms.PictureBox Pic_Image;
        private System.Windows.Forms.TextBox Txt_resultado;
    }
}

