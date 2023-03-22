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
    public partial class frmHome : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int left, int top, int right, int bottom, int width, int height
            );


        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            txtNome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNome.Width, btnJogar.Height, 30, 30));
            btnJogar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnJogar.Width, btnJogar.Height, 50, 50));
            btnRanking.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRanking.Width, btnJogar.Height, 50, 50));
            btnRegras.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegras.Width, btnRegras.Height, 50, 50));
            btnSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSair.Width, btnJogar.Height, 50, 50));
        }

        public void btnJogar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;

            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Por favor, insira seu nome!", "Verificação de Nome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else { 
                frmJogar frmjogar = new frmJogar(Nome);
                frmjogar.ShowDialog();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRanking_Click(object sender, EventArgs e)
        {
            frmRanking frmnranking = new frmRanking();
            frmnranking.ShowDialog();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            frmRegras frmnregras = new frmRegras();
            frmnregras.ShowDialog();
        }
    }
}
