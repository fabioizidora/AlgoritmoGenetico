using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicArrow.AG;

namespace AG.WinForms
{
    public partial class frmTesteAG : Form
    {
        public frmTesteAG()
        {
            InitializeComponent();

            #region MyRegion
            //int marginTop = 20;

            //for (int l = 0; l < 6; l++)
            //{    
            //    int marginleft = 20;

            //    for (int c = 0; c < 6; c++)
            //    {
            //        Label lbl = new Label();
            //        lbl.Size = new Size(60, 60);
            //        lbl.BorderStyle = BorderStyle.FixedSingle;
            //        lbl.Location = new Point(marginleft, marginTop);
                                        
            //        this.Controls.Add(lbl);

            //        //lbl.Update();

            //        marginleft += 60;
            //    }

            //    marginTop += 60;
            //}

            ////this.Update();
            #endregion
 
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            DateTime dtInicio = DateTime.Now;
            lblInicio.Text = dtInicio.ToString("dd/MM/yyyy HH:mm:ss.fffffff");

            ///Definir solução.
            AlgoritmoGeneticoString.Solucao = txtFrase.Text;//"ola mundo, eu sou o portuga 0";
            int TamPop = int.Parse(txtPopulacao.Text);
            int NumeroMaximoGeracoes = int.Parse(txtMaximoGeracoes.Text);
            bool Elitismo = chkElitismo.Checked;

            ///Definir caracteres possiveis.
            AlgoritmoGeneticoString.Caracteres = " !,.:;?áÁãÃâÂõÕôÔóÓéêÉÊíQWERTYUIOPASDFGHJKLÇZXCVBNMqwertyuiopasdfghjklçzxcvbnm1234567890";
            AlgoritmoGeneticoString.TaxaDeCrossover = 0.6;
            AlgoritmoGeneticoString.TaxaDeMutacao = 0.3;

            listBox1.Items.Clear();

            int NumGenes = AlgoritmoGeneticoString.Solucao.Length;

            PopulacaoString populacao = new PopulacaoString(NumGenes, TamPop);

            bool temSolucao = false;
            int Geracao = 0;

            listBox1.Items.Add("Iniciando Aptidao da solucao: " + AlgoritmoGeneticoString.Solucao.Length);

            while (!temSolucao && Geracao < NumeroMaximoGeracoes)
            {
                Geracao++;

                ///Criar nova populacao.
                populacao = AlgoritmoGeneticoString.NovaGeracao(populacao, Elitismo);

                listBox1.Items.Add("Geração " + Geracao + " | Aptidão: " + populacao.Individuos[0].Aptidao + " | Melhor: " + populacao.Individuos[0].Genes);

                ///Validar se uma solução foi encontrada.
                temSolucao = populacao.TemSolucao(AlgoritmoGeneticoString.Solucao);
            }

            if (Geracao == NumeroMaximoGeracoes)
            {
                listBox1.Items.Add("Número Maximo de Gerações | " + populacao.Individuos[0].Genes + " " + populacao.Individuos[0].Aptidao);
            }

            if (temSolucao)
            {
                listBox1.Items.Add("Encontrado resultado na geração " + Geracao + " | "
                                  + populacao.Individuos[0].Genes + " (Aptidão: " + populacao.Individuos[0].Aptidao + ")");
            }

            DateTime dtFim = DateTime.Now;
            lblFim.Text = dtFim.ToString("dd/MM/yyyy HH:mm:ss.fffffff");

            lblTempoTotalSegundo.Text = (dtFim - dtInicio).TotalSeconds.ToString("0.000000000000000");
        }
    }
}
