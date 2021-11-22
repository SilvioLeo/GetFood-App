
namespace GetFood_App.Aplicacao
{
    partial class Cadastro
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCadConfSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(241, 182);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.Location = new System.Drawing.Point(241, 78);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCadEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha";
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(241, 104);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCadSenha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirmar senha";
            // 
            // textCadConfSenha
            // 
            this.textCadConfSenha.Location = new System.Drawing.Point(241, 143);
            this.textCadConfSenha.Name = "textCadConfSenha";
            this.textCadConfSenha.Size = new System.Drawing.Size(100, 20);
            this.textCadConfSenha.TabIndex = 2;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCadConfSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCadEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCadConfSenha;
    }
}