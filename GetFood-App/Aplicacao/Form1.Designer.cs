
namespace GetFood_App
{
    partial class Form1
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
            this.btnLogSair = new System.Windows.Forms.Button();
            this.btnLogCadastreSe = new System.Windows.Forms.Button();
            this.btnLogEntrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogSair
            // 
            this.btnLogSair.Location = new System.Drawing.Point(266, 240);
            this.btnLogSair.Name = "btnLogSair";
            this.btnLogSair.Size = new System.Drawing.Size(93, 44);
            this.btnLogSair.TabIndex = 0;
            this.btnLogSair.Text = "Sair";
            this.btnLogSair.UseVisualStyleBackColor = true;
            this.btnLogSair.Click += new System.EventHandler(this.btnLogSair_Click);
            // 
            // btnLogCadastreSe
            // 
            this.btnLogCadastreSe.Location = new System.Drawing.Point(382, 240);
            this.btnLogCadastreSe.Name = "btnLogCadastreSe";
            this.btnLogCadastreSe.Size = new System.Drawing.Size(93, 44);
            this.btnLogCadastreSe.TabIndex = 0;
            this.btnLogCadastreSe.Text = "Cadastre-se";
            this.btnLogCadastreSe.UseVisualStyleBackColor = true;
            this.btnLogCadastreSe.Click += new System.EventHandler(this.btnLogCadastreSe_Click);
            // 
            // btnLogEntrar
            // 
            this.btnLogEntrar.Location = new System.Drawing.Point(325, 190);
            this.btnLogEntrar.Name = "btnLogEntrar";
            this.btnLogEntrar.Size = new System.Drawing.Size(93, 44);
            this.btnLogEntrar.TabIndex = 0;
            this.btnLogEntrar.Text = "Entrar";
            this.btnLogEntrar.UseVisualStyleBackColor = true;
            this.btnLogEntrar.Click += new System.EventHandler(this.btnLogEntrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(309, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(309, 122);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(153, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogEntrar);
            this.Controls.Add(this.btnLogCadastreSe);
            this.Controls.Add(this.btnLogSair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogSair;
        private System.Windows.Forms.Button btnLogCadastreSe;
        private System.Windows.Forms.Button btnLogEntrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

