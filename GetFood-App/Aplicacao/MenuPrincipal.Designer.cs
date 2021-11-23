
namespace GetFood_App.Aplicacao
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAlimentos = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dtpFabricacao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.dgvMenuAlimentos = new System.Windows.Forms.DataGridView();
            this.btnMenuConsultar = new System.Windows.Forms.Button();
            this.btnMenuAtualizar = new System.Windows.Forms.Button();
            this.btnMenuExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuAlimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnMenuCadastrar
            // 
            this.btnMenuCadastrar.Location = new System.Drawing.Point(62, 237);
            this.btnMenuCadastrar.Name = "btnMenuCadastrar";
            this.btnMenuCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnMenuCadastrar.TabIndex = 1;
            this.btnMenuCadastrar.Text = "Cadastrar";
            this.btnMenuCadastrar.UseVisualStyleBackColor = true;
            this.btnMenuCadastrar.Click += new System.EventHandler(this.btnMenuCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(62, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtAlimentos
            // 
            this.txtAlimentos.Location = new System.Drawing.Point(62, 72);
            this.txtAlimentos.Name = "txtAlimentos";
            this.txtAlimentos.Size = new System.Drawing.Size(200, 20);
            this.txtAlimentos.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(62, 111);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(200, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // dtpFabricacao
            // 
            this.dtpFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFabricacao.Location = new System.Drawing.Point(62, 155);
            this.dtpFabricacao.Name = "dtpFabricacao";
            this.dtpFabricacao.Size = new System.Drawing.Size(200, 20);
            this.dtpFabricacao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "alimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de fabricação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data de vencimento";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(62, 194);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimento.TabIndex = 9;
            // 
            // dgvMenuAlimentos
            // 
            this.dgvMenuAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuAlimentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMenuAlimentos.Location = new System.Drawing.Point(0, 295);
            this.dgvMenuAlimentos.Name = "dgvMenuAlimentos";
            this.dgvMenuAlimentos.Size = new System.Drawing.Size(800, 155);
            this.dgvMenuAlimentos.TabIndex = 10;
            // 
            // btnMenuConsultar
            // 
            this.btnMenuConsultar.Location = new System.Drawing.Point(165, 237);
            this.btnMenuConsultar.Name = "btnMenuConsultar";
            this.btnMenuConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnMenuConsultar.TabIndex = 11;
            this.btnMenuConsultar.Text = "Consultar";
            this.btnMenuConsultar.UseVisualStyleBackColor = true;
            // 
            // btnMenuAtualizar
            // 
            this.btnMenuAtualizar.Location = new System.Drawing.Point(279, 237);
            this.btnMenuAtualizar.Name = "btnMenuAtualizar";
            this.btnMenuAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnMenuAtualizar.TabIndex = 12;
            this.btnMenuAtualizar.Text = "Atualizar";
            this.btnMenuAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnMenuExcluir
            // 
            this.btnMenuExcluir.Location = new System.Drawing.Point(387, 237);
            this.btnMenuExcluir.Name = "btnMenuExcluir";
            this.btnMenuExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnMenuExcluir.TabIndex = 13;
            this.btnMenuExcluir.Text = "Excluir";
            this.btnMenuExcluir.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuExcluir);
            this.Controls.Add(this.btnMenuAtualizar);
            this.Controls.Add(this.btnMenuConsultar);
            this.Controls.Add(this.dgvMenuAlimentos);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFabricacao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtAlimentos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMenuCadastrar);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuAlimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAlimentos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DateTimePicker dtpFabricacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.DataGridView dgvMenuAlimentos;
        private System.Windows.Forms.Button btnMenuConsultar;
        private System.Windows.Forms.Button btnMenuAtualizar;
        private System.Windows.Forms.Button btnMenuExcluir;
    }
}