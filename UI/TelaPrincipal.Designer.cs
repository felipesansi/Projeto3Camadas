namespace Projeto3Camadas
{
    partial class TelaPrincipal
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
            this.btn_Fornecedor = new System.Windows.Forms.Button();
            this.pnl_Tela = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Fornecedor
            // 
            this.btn_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fornecedor.Location = new System.Drawing.Point(24, 12);
            this.btn_Fornecedor.Name = "btn_Fornecedor";
            this.btn_Fornecedor.Size = new System.Drawing.Size(153, 42);
            this.btn_Fornecedor.TabIndex = 0;
            this.btn_Fornecedor.Text = "Fornecedor";
            this.btn_Fornecedor.UseVisualStyleBackColor = true;
            this.btn_Fornecedor.Click += new System.EventHandler(this.btn_Fornecedor_Click);
            // 
            // pnl_Tela
            // 
            this.pnl_Tela.Location = new System.Drawing.Point(24, 60);
            this.pnl_Tela.Name = "pnl_Tela";
            this.pnl_Tela.Size = new System.Drawing.Size(755, 489);
            this.pnl_Tela.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.pnl_Tela);
            this.Controls.Add(this.btn_Fornecedor);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fornecedor;
        private System.Windows.Forms.Panel pnl_Tela;
    }
}

