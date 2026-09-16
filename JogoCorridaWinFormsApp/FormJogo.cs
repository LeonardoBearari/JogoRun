using JogoRun;
using System.Media;

namespace JogoCorridaWinFormsApp
{
    public partial class FormJogo : Form
    {
        Jogo jogo;
        DateTime tempoUltimaMocimentaca = DateTime.Now;
        List<PictureBox> pictureBoxes = [];
        List<PictureBox> pictureBoxesMoedas = [];

        public FormJogo(string Nivel)
        {
            DoubleBuffered = true;
            InitializeComponent();
            TocarSomCorrida();
            jogo = new Jogo
            {
                Faixa1Inicio = 2,
                Faixa1Fim = 396,
                Faixa2Inicio = 404,
                Faixa2Fim = 857
            };
            jogo.YMaximo = 880;
            jogo.IniciaJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);

            if (Nivel == "Fácil")
            {
                jogo.Velocidade = 100;
            }
            else if (Nivel == "Médio")
            {
                jogo.Velocidade = 50;
            }
            else
            {
                jogo.Velocidade = 25;
            }

            foreach (var ob in jogo.Obstaculos)
            {
                var picOb = new PictureBox();
                picOb.BackColor = Color.Transparent;
                picOb.Size = new Size(94, 91);
                picOb.BackgroundImageLayout = ImageLayout.Stretch;
                picOb.BackgroundImage = ob.Variante switch
                {
                    1 => Properties.Resources.galinha,
                    2 => Properties.Resources.bomba,
                    _ => Properties.Resources.obstaculo
                };
                pictureBoxes.Add(picOb);
                this.Controls.Add(picOb);
            }

            foreach (var moeda in jogo.Moedas)
            {
                var picMoeda = new PictureBox();
                picMoeda.BackColor = Color.Transparent;
                picMoeda.Size = new Size(50, 50);
                picMoeda.BackgroundImageLayout = ImageLayout.Stretch;
                picMoeda.BackgroundImage = Properties.Resources.moeda;
                pictureBoxesMoedas.Add(picMoeda);
                this.Controls.Add(picMoeda);
            }

            lblPontuacao.BringToFront();
            TimerJogo.Enabled = true;
        }

        private void TimerJogo_Tick(object sender, EventArgs e)
        {
            picCarro.Location = new Point(jogo.Carro.PosicaoX, jogo.Carro.PosicaoY);

            var i = 0;
            foreach (var ob in jogo.Obstaculos)
            {
                pictureBoxes[i].Location = new Point(ob.PosicaoX, ob.PosicaoY);
                pictureBoxes[i].Visible = ob.PosicaoY >= 0;
                i++;
            }

            i = 0;
            foreach (var moeda in jogo.Moedas)
            {
                pictureBoxesMoedas[i].Location = new Point(moeda.PosicaoX, moeda.PosicaoY);
                pictureBoxesMoedas[i].Visible = moeda.PosicaoY >= 0 && !moeda.Contabilizado;
                i++;
            }

            if ((DateTime.Now - tempoUltimaMocimentaca).TotalMilliseconds > jogo.Velocidade)
            {
                tempoUltimaMocimentaca = DateTime.Now;
                jogo.MovimentaObstaculos();
                jogo.MovimentaMoedas();
                jogo.PontuarObstaculosSuperados();
                jogo.PontuarPorTempo();
            }

            jogo.ChecarColisaoMoeda();

            lblPontuacao.Text = $"Pontos: {jogo.Pontuacao}";

            if (jogo.ChecarColisao())
            {
                GameOver();
            }

            Application.DoEvents();
        }

        private void GameOver()
        {
            TimerJogo.Enabled = false;
            picCarro.BackgroundImage = CriaExplosaoPlaceholder();
            TocarSomBatida();

            var timerFechar = new System.Windows.Forms.Timer();
            timerFechar.Interval = 800;
            timerFechar.Tick += (s, e) =>
            {
                timerFechar.Stop();
                Close();
            };
            timerFechar.Start();
        }

        private Image CriaExplosaoPlaceholder()
        {
            var bmp = new Bitmap(82, 201);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.FillEllipse(Brushes.OrangeRed, 5, 60, 72, 72);
                g.FillEllipse(Brushes.Yellow, 20, 75, 42, 42);
            }
            return bmp;
        }

        private void TocarSomCorrida()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "D:\\LeonardoBS\\POE\\fundo.wav";
            sp.PlayLooping();
        }

        private void TocarSomBatida()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "D:\\LeonardoBS\\POE\\explode1_5uz7VYc.wav";
            sp.Play();
        }

        private void FormJogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            }
            if (e.KeyCode == Keys.Right)
            {
                jogo.Carro.PosicaoX = jogo.PosicionaObjeto(2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}