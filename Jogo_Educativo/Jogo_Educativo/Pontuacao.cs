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
    public partial class Pontuacao : Form
    {
        #region "Atributo"

        private List<Jogador> listaJogador;

        #endregion


        #region "Propriedade"

        public List<Jogador> ListaJogador { get => listaJogador; set => listaJogador = value; }

        #endregion


        public Pontuacao()
        {
            InitializeComponent();
        }


        #region "Eventos"

        private void Pontuacao_Load(object sender, EventArgs e)
        {
            CarregaFiltro();
        }

        private void cbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                ListaJogador = ListaJogador.OrderByDescending(x => x.Pontuacao).ToList();
                gridPontuacao.DataSource = ListaJogador;
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                ListaJogador = ListaJogador.OrderBy(x => x.Tempo).ToList();
                gridPontuacao.DataSource = ListaJogador;
            }
        }

        private void gridPontuacao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.CellStyle.BackColor = Color.Black;
                e.CellStyle.ForeColor = Color.White;
            }
            if (e.ColumnIndex == 1)
            {
                e.CellStyle.BackColor = Color.Black;
                e.CellStyle.ForeColor = Color.White;
            }
            if (e.ColumnIndex == 2)
            {
                e.CellStyle.BackColor = Color.Black;
                e.CellStyle.ForeColor = Color.White;
            }
            if (e.ColumnIndex == 3)
            {
                e.CellStyle.BackColor = Color.Black;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        #endregion


        #region "Loads"

        private void CarregaFiltro()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "Pontuação");
            dic.Add("2", "Tempo");
            cbFiltro.ValueMember = "Key";
            cbFiltro.DisplayMember = "Value";
            cbFiltro.DataSource = dic.ToList();
        }

        #endregion

    }
}
