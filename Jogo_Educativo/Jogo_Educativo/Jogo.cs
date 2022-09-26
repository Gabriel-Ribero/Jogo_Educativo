using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Educativo
{
    public partial class Jogo : Form
    {
        #region "Atributos"

        private List<Jogador> listaJogador;
        private int count;
        private int pontos;
        private int h = 0, m = 0, s = 0;

        #endregion


        #region "Propriedades"

        public List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        #endregion


        public Jogo()
        {
            ListaJogador = new List<Jogador>(); 
            InitializeComponent();
        }


        #region "Eventos"

        private void Jogo_Load(object sender, EventArgs e)
        {
            CarregaJogador();
            Controler(false);
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            count = 1;
            pontos = 0;
            h = 0; m = 0; s = 0;
            timer1.Start();
            Controler(true);
            if (rbFacil.Checked)
            {
                ConfigFacil();
            }
            else
            {
                ConfigDificil();
            }
        }

        private void btnEnviarResposta_Click(object sender, EventArgs e)
        {
            if (rbFacil.Checked)
            {
                switch (count)
                {
                    case 1:
                        if (rb1.Checked)
                            pontos += 1;
                        break;
                    case 2:
                        if (rb3.Checked)
                            pontos += 1;
                        break;
                    case 3:
                        if (rb2.Checked)
                            pontos += 1;
                        break;
                    case 4:
                        if (rb2.Checked)
                            pontos += 1;
                        break;
                    case 5:
                        if (rb4.Checked)
                            pontos += 1;
                        if (rbFacil.Checked) ListaJogador[cbJogador.SelectedIndex].Dificuldade = "Fácil"; else ListaJogador[cbJogador.SelectedIndex].Dificuldade = "Difícil";
                        ListaJogador[cbJogador.SelectedIndex].Pontuacao = pontos;
                        ListaJogador[cbJogador.SelectedIndex].Tempo = new TimeSpan(h, m, s);
                        timer1.Stop();
                        lbltime.Text = "00:00:00";
                        MessageBox.Show("Jogo encerrado. Consulte sua pontuação no menu de pontuação.", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controler(false);
                        break;
                }
                count += 1;
                ConfigFacil();
            }
            else
            {
                switch (count)
                {
                    case 1:
                        if (rb1.Checked)
                            pontos += 1;
                        break;
                    case 2:
                        if (rb1.Checked)
                            pontos += 1;
                        break;
                    case 3:
                        if (rb4.Checked)
                            pontos += 1;
                        break;
                    case 4:
                        if (rb3.Checked)
                            pontos += 1;
                        break;
                    case 5:
                        if (rb1.Checked)
                        {
                            pontos += 1;
                        }
                        if (rbFacil.Checked) ListaJogador[cbJogador.SelectedIndex].Dificuldade = "Fácil"; else ListaJogador[cbJogador.SelectedIndex].Dificuldade = "Difícil";
                        ListaJogador[cbJogador.SelectedIndex].Pontuacao = pontos;
                        ListaJogador[cbJogador.SelectedIndex].Tempo = new TimeSpan(h, m, s);
                        timer1.Stop();
                        lbltime.Text = "00:00:00";
                        MessageBox.Show("Jogo encerrado. Consulte sua pontuação no menu de pontuação.", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controler(false);
                        break;
                }
                count += 1;
                ConfigDificil();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                m++;
                s = 0;
            }else if (m == 60)
            {
                h++;
                m = 0;
            }
            lbltime.Text = $"{h}:{m}:{s}";
        }

        #endregion


        #region "Loads / Configs"

        private void CarregaJogador()
        {
            cbJogador.ValueMember = null;
            cbJogador.DisplayMember = "Nome";
            cbJogador.DataSource = ListaJogador;
        }


        private void ConfigFacil()
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            switch (count)
            {
                case 1:
                    pbImagens.Image = Properties.Resources.Imagem_1;
                    rb1.Text = "47";
                    rb2.Text = "32";
                    rb3.Text = "35";
                    rb4.Text = "43";
                    break;
                case 2:
                    pbImagens.Image = Properties.Resources.Imagem_2;
                    rb1.Text = "53";
                    rb2.Text = "49";
                    rb3.Text = "66";
                    rb4.Text = "60";
                    break;
                case 3:
                    pbImagens.Image = Properties.Resources.Imagem_3;
                    rb1.Text = "19";
                    rb2.Text = "15";
                    rb3.Text = "10";
                    rb4.Text = "16";
                    break;
                case 4:
                    pbImagens.Image = Properties.Resources.Imagem_4;
                    rb1.Text = "40";
                    rb2.Text = "30";
                    rb3.Text = "31";
                    rb4.Text = "18";
                    break;
                case 5:
                    pbImagens.Image = Properties.Resources.Imagem_5;
                    rb1.Text = "50";
                    rb2.Text = "48";
                    rb3.Text = "37";
                    rb4.Text = "45";
                    break;
            }
        }

        private void ConfigDificil()
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            switch (count)
            {
                case 1:
                    pbImagens.Image = Properties.Resources.Imagem_6;
                    rb1.Text = "80";
                    rb2.Text = "72";
                    rb3.Text = "84";
                    rb4.Text = "76";
                    break;
                case 2:
                    pbImagens.Image = Properties.Resources.Imagem_7;
                    rb1.Text = "3";
                    rb2.Text = "4";
                    rb3.Text = "5";
                    rb4.Text = "2";
                    break;
                case 3:
                    pbImagens.Image = Properties.Resources.Imagem_8;
                    rb1.Text = "55";
                    rb2.Text = "42";
                    rb3.Text = "40";
                    rb4.Text = "50";
                    break;
                case 4:
                    pbImagens.Image = Properties.Resources.Imagem_9;
                    rb1.Text = "62";
                    rb2.Text = "84";
                    rb3.Text = "64";
                    rb4.Text = "73";
                    break;
                case 5:
                    pbImagens.Image = Properties.Resources.Imagem_10;
                    rb1.Text = "64";
                    rb2.Text = "59";
                    rb3.Text = "60";
                    rb4.Text = "79";
                    break;
            }
        }

        #endregion


        private void Controler(bool visivel)
        {
            if (visivel)
            {
                pbImagens.Visible = true;
                lblExplicacao.Visible = true;
                rb1.Visible = true;
                rb2.Visible = true;
                rb3.Visible = true;
                rb4.Visible = true;
                btnEnviarResposta.Visible = true;
                lbltime.Visible = true;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
            else if (!visivel)
            {
                pbImagens.Visible = false;
                lblExplicacao.Visible = false;
                rb1.Visible = false;
                rb2.Visible = false;
                rb3.Visible = false;
                rb4.Visible = false;
                btnEnviarResposta.Visible = false;
                lbltime.Visible = false;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

    }
}
