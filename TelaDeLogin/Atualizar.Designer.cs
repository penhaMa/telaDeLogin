namespace TelaDeLogin
{
    partial class Atualizar
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
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uf = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 34);
            this.label6.TabIndex = 28;
            this.label6.Text = "Atualizar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 41;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uf
            // 
            this.uf.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uf.Location = new System.Drawing.Point(116, 252);
            this.uf.Mask = "aa";
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(37, 35);
            this.uf.TabIndex = 40;
            this.uf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.uf_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(116, 169);
            this.telefone.Mask = "(99) 99999-9999";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(162, 35);
            this.telefone.TabIndex = 38;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(117, 87);
            this.cpf.Mask = "99999999999";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(161, 35);
            this.cpf.TabIndex = 37;
            this.cpf.ValidatingType = typeof(int);
            this.cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "UF";
            // 
            // cidade
            // 
            this.cidade.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(116, 210);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(179, 35);
            this.cidade.TabIndex = 35;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Telefone";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(117, 128);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(178, 35);
            this.nome.TabIndex = 32;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "CPF";
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.MaximumSize = new System.Drawing.Size(338, 409);
            this.MinimumSize = new System.Drawing.Size(338, 409);
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.Atualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox uf;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}