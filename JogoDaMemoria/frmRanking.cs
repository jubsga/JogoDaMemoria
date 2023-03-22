using JogoDaMemoria.DAO;
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
    public partial class frmRanking : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int left, int top, int right, int bottom, int width, int height
           );
        public frmRanking()
        {
            InitializeComponent();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            btnSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSair.Width, btnSair.Height, 50, 50));

            JogoDAO dao = new JogoDAO();
            var ListaJogos = dao.ListarJogos();

            for (int i = 0; i < ListaJogos.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                switch (i)
                {
                    case 0:
                        lbl_primeiro.Text = $"{ListaJogos[i].Nome ?? ""}";
                        lbl_tempo1.Text = $"{ListaJogos[i].Tempo}s";
                        lbl_movi1.Text = $"{ListaJogos[i].Movimentos} Movimentos";
                        break;
                    case 1:
                        lbl_segundo.Text = $"{ListaJogos[i].Nome ?? ""}";
                        lbl_tempo2.Text = $"{ListaJogos[i].Tempo}s";
                        lbl_movi2.Text = $"{ListaJogos[i].Movimentos} Movimentos";
                        break;
                    case 2:
                        lbl_terceiro.Text = $"{ListaJogos[i].Nome ?? ""}";
                        lbl_tempo3.Text = $"{ListaJogos[i].Tempo}s";
                        lbl_movi3.Text = $"{ListaJogos[i].Movimentos} Movimentos";
                        break;
                    case 3:
                        lbl_quarto.Text = $"{ListaJogos[i].Nome ?? ""}";
                        lbl_tempo4.Text = $"{ListaJogos[i].Tempo}s";
                        lbl_movi4.Text = $"{ListaJogos[i].Movimentos} Movimentos";
                        break;
                    case 4:
                        lbl_quinto.Text = $"{ListaJogos[i].Nome ?? ""}";
                        lbl_tempo5.Text = $"{ListaJogos[i].Tempo}s";
                        lbl_movi5.Text = $"{ListaJogos[i].Movimentos} Movimentos";
                        break;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
