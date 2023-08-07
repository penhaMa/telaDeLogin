namespace TelaDeLogin
{
    partial class Cadastrar
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
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(111, 173);
            this.telefone.Mask = "(99) 99000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(162, 35);
            this.telefone.TabIndex = 26;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(112, 91);
            this.cpf.Mask = "99999999999";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(161, 35);
            this.cpf.TabIndex = 25;
            this.cpf.ValidatingType = typeof(int);
            this.cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "UF";
            // 
            // cidade
            // 
            this.cidade.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(111, 214);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(179, 35);
            this.cidade.TabIndex = 22;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefone";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(112, 132);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(178, 35);
            this.nome.TabIndex = 19;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 34);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cadastrar";
            // 
            // uf
            // 
            this.uf.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uf.Location = new System.Drawing.Point(111, 256);
            this.uf.Mask = "aa";
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(37, 35);
            this.uf.TabIndex = 28;
            this.uf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.uf_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "INSERIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(338, 409);
            this.MinimumSize = new System.Drawing.Size(338, 409);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox uf;
        private System.Windows.Forms.Button button1;
    }
}