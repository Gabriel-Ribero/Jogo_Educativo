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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            ListaJogador = new List<Jogador>();
            InitializeComponent();
        }
        private List<Jogador> listaJogador;

        public List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }


        #region "Eventos"

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ListaJogador.Select(x => x.Nome).Contains(txtJogador.Text))
            {
                Jogador Obj = new Jogador();
                Obj.Nome = txtJogador.Text;
                ListaJogador.Add(Obj);
                if (MessageBox.Show("Deseja cadastrar outro Jogador?", "Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtJogador.Text = "";
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Nome de jogador não disponível!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


    }
}
