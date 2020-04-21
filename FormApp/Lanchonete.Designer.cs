namespace FormApp
{
    partial class Lanchonete
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtQuantidadeClientes = new System.Windows.Forms.TextBox();
            this.lblQuantidadeClientes = new System.Windows.Forms.Label();
            this.txtNumeroEmpregados = new System.Windows.Forms.TextBox();
            this.lblNumeroEmpregados = new System.Windows.Forms.Label();
            this.txtReceita = new System.Windows.Forms.TextBox();
            this.lblReceita = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvLanchonete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanchonete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(15, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 84);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(261, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 68);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "* Descrição:";
            // 
            // txtQuantidadeClientes
            // 
            this.txtQuantidadeClientes.Location = new System.Drawing.Point(15, 136);
            this.txtQuantidadeClientes.Name = "txtQuantidadeClientes";
            this.txtQuantidadeClientes.Size = new System.Drawing.Size(140, 20);
            this.txtQuantidadeClientes.TabIndex = 5;
            // 
            // lblQuantidadeClientes
            // 
            this.lblQuantidadeClientes.AutoSize = true;
            this.lblQuantidadeClientes.Location = new System.Drawing.Point(12, 120);
            this.lblQuantidadeClientes.Name = "lblQuantidadeClientes";
            this.lblQuantidadeClientes.Size = new System.Drawing.Size(127, 13);
            this.lblQuantidadeClientes.TabIndex = 4;
            this.lblQuantidadeClientes.Text = "* Quantidade de Clientes:";
            // 
            // txtNumeroEmpregados
            // 
            this.txtNumeroEmpregados.Location = new System.Drawing.Point(15, 188);
            this.txtNumeroEmpregados.Name = "txtNumeroEmpregados";
            this.txtNumeroEmpregados.Size = new System.Drawing.Size(140, 20);
            this.txtNumeroEmpregados.TabIndex = 7;
            // 
            // lblNumeroEmpregados
            // 
            this.lblNumeroEmpregados.AutoSize = true;
            this.lblNumeroEmpregados.Location = new System.Drawing.Point(12, 172);
            this.lblNumeroEmpregados.Name = "lblNumeroEmpregados";
            this.lblNumeroEmpregados.Size = new System.Drawing.Size(131, 13);
            this.lblNumeroEmpregados.TabIndex = 6;
            this.lblNumeroEmpregados.Text = "* Número de Empregados:";
            // 
            // txtReceita
            // 
            this.txtReceita.Location = new System.Drawing.Point(15, 236);
            this.txtReceita.Name = "txtReceita";
            this.txtReceita.Size = new System.Drawing.Size(140, 20);
            this.txtReceita.TabIndex = 9;
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Location = new System.Drawing.Point(12, 220);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(54, 13);
            this.lblReceita.TabIndex = 8;
            this.lblReceita.Text = "* Receita:";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(15, 288);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(140, 20);
            this.txtDespesa.TabIndex = 11;
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(12, 272);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(59, 13);
            this.lblDespesa.TabIndex = 10;
            this.lblDespesa.Text = "* Despesa:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 327);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvLanchonete
            // 
            this.dgvLanchonete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanchonete.Location = new System.Drawing.Point(307, 12);
            this.dgvLanchonete.Name = "dgvLanchonete";
            this.dgvLanchonete.Size = new System.Drawing.Size(317, 338);
            this.dgvLanchonete.TabIndex = 13;
            // 
            // Lanchonete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 362);
            this.Controls.Add(this.dgvLanchonete);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.txtReceita);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.txtNumeroEmpregados);
            this.Controls.Add(this.lblNumeroEmpregados);
            this.Controls.Add(this.txtQuantidadeClientes);
            this.Controls.Add(this.lblQuantidadeClientes);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "Lanchonete";
            this.Text = "Lanchonete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanchonete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtQuantidadeClientes;
        private System.Windows.Forms.Label lblQuantidadeClientes;
        private System.Windows.Forms.TextBox txtNumeroEmpregados;
        private System.Windows.Forms.Label lblNumeroEmpregados;
        private System.Windows.Forms.TextBox txtReceita;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvLanchonete;
    }
}

