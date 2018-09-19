namespace EscolaNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.btnresultado = new System.Windows.Forms.Button();
            this.btnMediaTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeColumns = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.NOTA1,
            this.NOTA2,
            this.NOTA3,
            this.MEDIA});
            this.dgvAlunos.Location = new System.Drawing.Point(12, 73);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.Size = new System.Drawing.Size(742, 468);
            this.dgvAlunos.TabIndex = 0;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // NOTA1
            // 
            this.NOTA1.HeaderText = "Nota1";
            this.NOTA1.Name = "NOTA1";
            this.NOTA1.ReadOnly = true;
            // 
            // NOTA2
            // 
            this.NOTA2.HeaderText = "Nota 2";
            this.NOTA2.Name = "NOTA2";
            this.NOTA2.ReadOnly = true;
            // 
            // NOTA3
            // 
            this.NOTA3.HeaderText = "Nota 3";
            this.NOTA3.Name = "NOTA3";
            this.NOTA3.ReadOnly = true;
            // 
            // MEDIA
            // 
            this.MEDIA.HeaderText = "Média";
            this.MEDIA.Name = "MEDIA";
            this.MEDIA.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(295, 27);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(415, 27);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(535, 27);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 3;
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Location = new System.Drawing.Point(654, 24);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(292, 8);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(45, 13);
            this.lblNota1.TabIndex = 7;
            this.lblNota1.Text = "Nota 1 :";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(412, 9);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(45, 13);
            this.lblNota2.TabIndex = 8;
            this.lblNota2.Text = "Nota 2 :";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(532, 8);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(45, 13);
            this.lblNota3.TabIndex = 9;
            this.lblNota3.Text = "Nota 3 :";
            // 
            // btnresultado
            // 
            this.btnresultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresultado.Location = new System.Drawing.Point(12, 552);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(101, 23);
            this.btnresultado.TabIndex = 5;
            this.btnresultado.Text = "Resultado Geral";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // btnMediaTotal
            // 
            this.btnMediaTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMediaTotal.Location = new System.Drawing.Point(654, 552);
            this.btnMediaTotal.Name = "btnMediaTotal";
            this.btnMediaTotal.Size = new System.Drawing.Size(101, 23);
            this.btnMediaTotal.TabIndex = 6;
            this.btnMediaTotal.Text = "Média dos Alunos";
            this.btnMediaTotal.UseVisualStyleBackColor = true;
            this.btnMediaTotal.Click += new System.EventHandler(this.btnMediaTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 587);
            this.Controls.Add(this.btnMediaTotal);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema de Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.Button btnMediaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIA;
    }
}

