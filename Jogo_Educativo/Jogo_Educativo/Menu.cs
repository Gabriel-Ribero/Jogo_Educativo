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
    public partial class Menu : Form
    {
        #region "Atributos"

        List<Jogador> listaJogador = new List<Jogador>();

        #endregion


        #region "Propriedades"

        public List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        #endregion


        public Menu()
        {
            ListaJogador = new List<Jogador>();
            InitializeComponent();
        }


        #region "Eventos"

        private void jogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro frm = new Cadastro();
            frm.ListaJogador = ListaJogador;
            frm.ShowDialog();
            ListaJogador = frm.ListaJogador;
            frm.Dispose();
        }

        private void iniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogo frm = new Jogo();
            frm.ListaJogador = ListaJogador;
            frm.ShowDialog();
            ListaJogador = frm.ListaJogador;
            frm.Dispose();
        }

        private void pontuaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pontuacao frm = new Pontuacao();
            frm.ListaJogador = ListaJogador;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


    }
}
