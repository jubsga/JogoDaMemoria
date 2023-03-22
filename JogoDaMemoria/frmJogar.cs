using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace JogoDaMemoria
{
    public partial class frmJogar : Form
    {
        string Nome;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int left, int top, int right, int bottom, int width, int height
            );

        int movimentos, cliques, pares, tag, acertos = 0, tempo = 90;
        Image[] img = new Image[15];
        int[] tags = new int[2];

        List<string> list = new List<string>();
        public frmJogar(string Nome)
        {
            InitializeComponent();
            Start();
            this.Nome = Nome;
        }

        private void Start()
        {
            timer.Start();

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                tag = int.Parse(String.Format("{0}", item.Tag));
                img[tag] = item.Image;
                item.Image = Properties.Resources.verso;
                item.Enabled = true;
            }
            Positions();
        }

        private void Positions()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();

                int[] xP = { 12, 136, 259, 383, 506, 630 };
                int[] yP = { 66, 199, 337, 465, 591 };

                Repete: 
                var x = xP[rdn.Next(0, xP.Length)];
                var y = yP[rdn.Next(0, yP.Length)];

                string verificacao = x.ToString() + y.ToString();

                if (list.Contains(verificacao))
                {
                    goto Repete;
                }
                else
                {
                    item.Location = new Point(x, y);
                    list.Add(verificacao);
                }
            }
        }

        private void ImgClick_Click(object sender, EventArgs e)
        {
            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;

            tag = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tag];
            pic.Refresh();

            if (cliques == 1)
            {
                tags[0] = int.Parse(String.Format("{0}", pic.Tag));
            }
            else if (cliques == 2)
            {
                movimentos++;
                
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));
                parEncontrado = CheckPar();
                Desvirar(parEncontrado);
            }

            // if (parEncontrado == true)
            // {

            // }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempo--;
            lblTempo.Text = "Tempo: " + tempo;
            if (tempo == 0)
            {
                timer.Stop();
                MessageBox.Show("Seu tempo acabou!", "Você perdeu!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // cliques = 0; movimentos = 0; pares = 0; acertos = 0; tempo = 90;
                list.Clear();
                frmPerder frmperder = new frmPerder(Nome);
                frmperder.ShowDialog();
            }

            lblTempo.Text = "Tempo: " + tempo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?", "Verificação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                timer.Stop();
                list.Clear();
                frmHome frmhome = new frmHome();
                frmhome.ShowDialog();
            }
            
        }

        private bool CheckPar()
        {
            lblQtdMovimento.Text = "Quantidade de Movimentos: " + movimentos;

            cliques = 0;
           
            if (tags[0] == tags[1])
            {
                acertos++;
                lblAcertos.Text = "Acertos: " + acertos;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Desvirar(bool check)
        {
            Thread.Sleep(500);
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] || 
                    int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (check == true)
                    {
                        item.Enabled = false;
                        pares++;
                    }
                    else
                    {
                        item.Image = Properties.Resources.verso;
                        item.Refresh(); 
                    }
                }
            }
            Finish();
        }
        private void Finish()
        {
            if (pares == (img.Length * 2))
            {
                int tempoTotal = 90 - tempo;

                timer.Stop();
                MessageBox.Show("Seu tempo foi: " + tempoTotal + " segundos" + Environment.NewLine + 
                    "Sua quantidade de movimentos foi: " + movimentos + Environment.NewLine, "Você ganhou!", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frmGanhar frmganhar = new frmGanhar(Nome, tempoTotal, movimentos);
                frmganhar.ShowDialog();
                /* if (MessageBox.Show("Deseja jogar novamente?", "Verificação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    list.Clear();
                    cliques = 0; movimentos = 0; pares = 0; acertos = 0; tempo = 10;
                    Start();
                    lblAcertos.Text = "Acertos: " + acertos;
                    lblQtdMovimento.Text = "Quantidade de movimentos: " + movimentos;
                }
                else
                {
                    cliques = cliques; movimentos = movimentos; pares = pares; acertos = acertos; tempo = tempo;
                    list.Clear();
                    this.Close();
                } */
            }
        }
        private void frmJogar_Load(object sender, EventArgs e)
        {
            btnVoltar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVoltar.Width, btnVoltar.Height, 30, 30));
            picC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picC.Width, picC.Height, 20, 20));
            picCPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picCPar.Width, picCPar.Height, 20, 20));
            picCS.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picCS.Width, picCS.Height, 20, 20));
            picCSPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picCSPar.Width, picCSPar.Height, 20, 20));
            picJS.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picJS.Width, picJS.Height, 20, 20));
            picJSPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picJSPar.Width, picJSPar.Height, 20, 20));
            picVB.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picVB.Width, picVB.Height, 20, 20));
            picVBPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picVBPar.Width, picVBPar.Height, 20, 20));
            picRuby.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picRuby.Width, picRuby.Height, 20, 20));
            picRubyPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picRubyPar.Width, picRubyPar.Height, 20, 20));
            picJulia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picJulia.Width, picJulia.Height, 20, 20));
            picJuliaPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picJuliaPar.Width, picJuliaPar.Height, 20, 20));
            picPython.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picPython.Width, picPython.Height, 20, 20));
            picPythonPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picPythonPar.Width, picPythonPar.Height, 20, 20));
            picLua.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picLua.Width, picLua.Height, 20, 20));
            picLuaPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picLuaPar.Width, picLuaPar.Height, 20, 20));
            picGO.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picGO.Width, picGO.Height, 20, 20));
            picGOPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picGOPar.Width, picGOPar.Height, 20, 20));
            picReact.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picReact.Width, picReact.Height, 20, 20));
            picReactPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picReactPar.Width, picReactPar.Height, 20, 20));
            picRNative.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picRNative.Width, picRNative.Height, 20, 20));
            picRNative.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picRNative.Width, picRNative.Height, 20, 20));
            picObjective.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picObjective.Width, picObjective.Height, 20, 20));
            picObjectivePar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picObjectivePar.Width, picObjectivePar.Height, 20, 20));
            picPhp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picPhp.Width, picPhp.Height, 20, 20));
            picPhpPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picPhpPar.Width, picPhpPar.Height, 20, 20));
            picSwift.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picSwift.Width, picSwift.Height, 20, 20));
            picSwiftPar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picSwiftPar.Width, picSwiftPar.Height, 20, 20));
        }

    }
}
