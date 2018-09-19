using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método que limpa os dados
        /// </summary>
        void limpadados()
        {
            txtNome.Text = string.Empty;
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
           
        }
        /// <summary>
        /// Botão que inseri as notas do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                //Cálculo da média
                decimal nota1 = Convert.ToDecimal(txtNota1.Text);
                decimal nota2 = Convert.ToDecimal(txtNota2.Text);
                decimal nota3 = Convert.ToDecimal(txtNota3.Text);
                decimal media = (nota1 + nota2 + nota3) / 3;
                media = decimal.Round(media, 2);// Irá mostrar a média com 2 nºs apenas, arredondando

                //Adicionando no DataGriedView 

                dgvAlunos.Rows.Add();//Adicionamos a linha do dvgAlunos
                                     //dgvAlunos.Rows[posicao].Cells["Nome da Coluna"].Value = valor;
                                     //posicao=> última a ser inserida pois sempre começa do zero,ex: 1ª linha = valor 0 => nº de linhas -1 = posição
                                     //Nome da Coluna=> igual ao NAME da edição das colunas obs:media é a variável estipulada aqui

                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOME"].Value = txtNome.Text;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTA1"].Value = txtNota1.Text;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTA2"].Value = txtNota2.Text;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTA3"].Value = txtNota3.Text;
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Value = media;

                //Colorindo as colunas
                if (media < 60)
                {
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.BackColor = Color.Red;
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.SelectionBackColor = Color.Red;
                }
                else
                {
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.BackColor = Color.Green;
                    dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.SelectionBackColor = Color.Green;
                }
                // Chamar método que limpa dados
                limpadados();
            }
        }
        /// <summary>
        /// Método que valida uma nota preenchida
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private bool validaNumero(string numero)
        {
            //tenta converter em decimal 
            try
            {
                Convert.ToDecimal(numero);
                return false;
            }
            //caso não consiga exibe msg p/ usuário
            catch (Exception)
            {
                MessageBox.Show("Digite uma nota válida!");
                return true;
            }
        }
        /// <summary>
        /// Método que valida dados
        /// </summary>
        /// <returns></returns>
        private bool validaDados()
        {
            //verifica validade do nome
            if (txtNome.Text.Replace(" ","")==string.Empty)//replace =>espaço vazio " "  por(,)   ""
            {
                MessageBox.Show("Digite um nome válido");
                txtNome.Focus();//volta com o cursor para o nome
                return false;
            }
            //verifica validade da nota
           else if (validaNumero(txtNota1.Text.Replace(",",".")))
            {
                MessageBox.Show("Digite uma nota válida !");
                txtNota1.Focus();
                return false;
            }
            else if (validaNumero(txtNota2.Text.Replace(",", ".")))
            {
                MessageBox.Show("Digite uma nota válida !");
                txtNota2.Focus();
                return false;
            }
            else if (validaNumero(txtNota3.Text.Replace(",", ".")))
            {
                MessageBox.Show("Digite uma nota válida !");
                txtNota3.Focus();
                return false;
            }
            else if(Convert.ToDecimal(txtNota1.Text.Replace("," , "."))>100|| Convert.ToDecimal(txtNota1.Text.Replace(",", ".")) <0)
            {
                MessageBox.Show("Digite uma nota válida !");
                txtNota1.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtNota2.Text.Replace(",", ".")) > 100 || Convert.ToDecimal(txtNota2.Text.Replace(",", ".")) < 0)
            {
                MessageBox.Show("Digite uma nota válida !");
                txtNota2.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtNota3.Text.Replace(",", ".")) > 100 || Convert.ToDecimal(txtNota3.Text.Replace(",", ".")) < 0)
            {
                MessageBox.Show("Digite uma nota válida !");
                txtNota3.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Botão que mostra o resultado geral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnresultado_Click(object sender, EventArgs e)
        {
            int qtdAprovados = 0;
            int qtdReprovados = 0;

            for (int i = 0; i < dgvAlunos.Rows.Count; i++)// verificará em cada linha se foi aprovado ou reprovado
            {
                if (Convert.ToDecimal(dgvAlunos.Rows[i].Cells["MEDIA"].Value)<60)//percorre o grid
                {
                    qtdReprovados++;
                }
                else
                {
                    qtdAprovados++;
                }
            }
            MessageBox.Show(qtdReprovados + " Aluno(s) reprovado(s)\n  " + qtdAprovados + " Aluno(s) Aprovado(s) ");
        }
        /// <summary>
        /// Evento que mostra a média geral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMediaTotal_Click(object sender, EventArgs e)
        {
            decimal mediaGeral = 0;
            if (dgvAlunos.Rows.Count>0)   //passar pelas linhas do grid obs: tendo pelo menos um aluno ou msg
            {  
                for (int i = 0; i < dgvAlunos.Rows.Count; i++)
            {
                mediaGeral += Convert.ToDecimal(dgvAlunos.Rows[i].Cells["MEDIA"].Value);
            }
            //mediaGeral = mediaGeral / dgvAlunos.Rows.Count;
            MessageBox.Show(" A média geral dos alunos é  :   " + decimal.Round(mediaGeral / dgvAlunos.Rows.Count,2));
            }
            else
            {
                MessageBox.Show("Não há alunos inseridos ");
            }
            
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)//selecionei as 3 cxs e criei o evento p/tds
        {
            if (!char.IsNumber(e.KeyChar)&& !char.IsPunctuation(e.KeyChar))//dif. de nº e de pontuação cancela a ação
            {
                //Cancela ação
                e.Handled = true;//handled=manipulado
            }
        }
    }
}
