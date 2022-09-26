using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Educativo
{
    public class Jogador
    {
        private string nome;
        private int pontuacao;
        private TimeSpan tempo;
        private string dificuldade;
        public string Nome { get => nome; set => nome = value; }
        public int Pontuacao { get => pontuacao; set => pontuacao = value; }
        public TimeSpan Tempo { get => tempo; set => tempo = value; }
        public string Dificuldade { get => dificuldade; set => dificuldade = value; }
    }
    // Classe Jogador Concluída
}
