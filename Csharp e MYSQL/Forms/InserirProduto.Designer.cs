
namespace Csharp_e_MYSQL.Forms
{
    partial class InserirProduto
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxCusto = new System.Windows.Forms.TextBox();
            this.txtBoxVenda = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMsgNome = new System.Windows.Forms.Label();
            this.lblMsgCodigo = new System.Windows.Forms.Label();
            this.lblMsgCusto = new System.Windows.Forms.Label();
            this.lblMsgVenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.Location = new System.Drawing.Point(12, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(12, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCusto.Location = new System.Drawing.Point(12, 79);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(51, 20);
            this.lblCusto.TabIndex = 2;
            this.lblCusto.Text = "Custo";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVenda.Location = new System.Drawing.Point(12, 111);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(56, 20);
            this.lblVenda.TabIndex = 3;
            this.lblVenda.Text = "Venda";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNome.Location = new System.Drawing.Point(69, 12);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(217, 26);
            this.txtBoxNome.TabIndex = 4;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxCodigo.Location = new System.Drawing.Point(69, 44);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(217, 26);
            this.txtBoxCodigo.TabIndex = 5;
            // 
            // txtBoxCusto
            // 
            this.txtBoxCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxCusto.Location = new System.Drawing.Point(69, 76);
            this.txtBoxCusto.Name = "txtBoxCusto";
            this.txtBoxCusto.Size = new System.Drawing.Size(100, 26);
            this.txtBoxCusto.TabIndex = 6;
            // 
            // txtBoxVenda
            // 
            this.txtBoxVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxVenda.Location = new System.Drawing.Point(69, 108);
            this.txtBoxVenda.Name = "txtBoxVenda";
            this.txtBoxVenda.Size = new System.Drawing.Size(100, 26);
            this.txtBoxVenda.TabIndex = 7;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirma.Location = new System.Drawing.Point(112, 203);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(84, 42);
            this.btnConfirma.TabIndex = 8;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(202, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblMsgNome
            // 
            this.lblMsgNome.AutoSize = true;
            this.lblMsgNome.ForeColor = System.Drawing.Color.Red;
            this.lblMsgNome.Location = new System.Drawing.Point(292, 20);
            this.lblMsgNome.Name = "lblMsgNome";
            this.lblMsgNome.Size = new System.Drawing.Size(11, 13);
            this.lblMsgNome.TabIndex = 10;
            this.lblMsgNome.Text = "*";
            // 
            // lblMsgCodigo
            // 
            this.lblMsgCodigo.AutoSize = true;
            this.lblMsgCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblMsgCodigo.Location = new System.Drawing.Point(292, 52);
            this.lblMsgCodigo.Name = "lblMsgCodigo";
            this.lblMsgCodigo.Size = new System.Drawing.Size(11, 13);
            this.lblMsgCodigo.TabIndex = 11;
            this.lblMsgCodigo.Text = "*";
            // 
            // lblMsgCusto
            // 
            this.lblMsgCusto.AutoSize = true;
            this.lblMsgCusto.ForeColor = System.Drawing.Color.Red;
            this.lblMsgCusto.Location = new System.Drawing.Point(175, 84);
            this.lblMsgCusto.Name = "lblMsgCusto";
            this.lblMsgCusto.Size = new System.Drawing.Size(11, 13);
            this.lblMsgCusto.TabIndex = 12;
            this.lblMsgCusto.Text = "*";
            // 
            // lblMsgVenda
            // 
            this.lblMsgVenda.AutoSize = true;
            this.lblMsgVenda.ForeColor = System.Drawing.Color.Red;
            this.lblMsgVenda.Location = new System.Drawing.Point(175, 116);
            this.lblMsgVenda.Name = "lblMsgVenda";
            this.lblMsgVenda.Size = new System.Drawing.Size(11, 13);
            this.lblMsgVenda.TabIndex = 13;
            this.lblMsgVenda.Text = "*";
            // 
            // InserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 277);
            this.Controls.Add(this.lblMsgVenda);
            this.Controls.Add(this.lblMsgCusto);
            this.Controls.Add(this.lblMsgCodigo);
            this.Controls.Add(this.lblMsgNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtBoxVenda);
            this.Controls.Add(this.txtBoxCusto);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InserirProduto";
            this.Text = "InserirProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxCusto;
        private System.Windows.Forms.TextBox txtBoxVenda;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMsgNome;
        private System.Windows.Forms.Label lblMsgCodigo;
        private System.Windows.Forms.Label lblMsgCusto;
        private System.Windows.Forms.Label lblMsgVenda;
    }
}