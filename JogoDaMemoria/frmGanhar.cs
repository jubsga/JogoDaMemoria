using JogoDaMemoria.DAO;
using JogoDaMemoria.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class frmGanhar : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int left, int top, int right, int bottom, int width, int height
           );

        JogoDTO jogo = new JogoDTO();
        string NomeJogador;
        public frmGanhar(string Nome, int Tempo, int Movimentos)
        {
            InitializeComponent();
            NomeJogador = Nome;
            jogo.Nome = Nome;
            jogo.Tempo = Tempo;
            jogo.Movimentos = Movimentos;
            JogoDAO dao = new JogoDAO();
            dao.CadastraJogo(jogo);

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            frmJogar frmjogar = new frmJogar(NomeJogador);
            frmjogar.ShowDialog();
        }

        private void btnRanking_Click_1(object sender, EventArgs e)
        {
            frmRanking frmnranking = new frmRanking();
            frmnranking.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmHome frmnhome = new frmHome();
            frmnhome.ShowDialog();
        }

        private void frmGanhar_Load(object sender, EventArgs e)
        {
            btnJogar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnJogar.Width, btnJogar.Height, 50, 50));
            btnRanking.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRanking.Width, btnRanking.Height, 50, 50));
            btnSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSair.Width, btnSair.Height, 50, 50));
        }
    }
}
