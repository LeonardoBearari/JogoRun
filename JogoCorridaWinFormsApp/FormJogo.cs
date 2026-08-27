using JogoRun;
using System.Media;

namespace JogoCorridaWinFormsApp

{
    public partial class FormJogo : Form
    {
        Jogo jogo;
        DateTime tempoUltimaMocimentaca = DateTime.Now;
        List<PictureBox> pictureBoxes = [];

        public FormJogo(string Nivel)
        {
            InitializeComponent();
            TocarSomCorrida();
            jogo = new Jogo
            {
                Faixa1Inicio = 2,
                Faixa1Fim = 198,
                Faixa2Inicio = 202,
                Faixa2Fim = 398
            };
            jogo.YMaximo = 550;
            jogo.IniciaJogo();
            jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
            if (Nivel == "Fácil")
            {
                jogo.Velocidade = 100;
            }
            else if(Nivel == "Médio"){
                jogo.Velocidade= 50;
            }
            else
            {
                jogo.Velocidade = 25;
            }

            foreach (var ob in jogo.Obstaculos)
            {
                var picOb = new PictureBox();
                picOb.BackColor = Color.Transparent;
                picOb.BackgroundImage = Properties.Resources.obstaculo;
                picOb.BackgroundImageLayout = ImageLayout.Stretch;
                //picOb.Image = Properties.Resources.obstaculo;
                pictureBoxes.Add(picOb);
                this.Controls.Add(picOb);
            }
            TimerJogo.Enabled = true;
        }

        private void TimerJogo_Tick(object sender, EventArgs e)
                {
            picCarro.Location = (new Point(jogo.Carro.PosicaoX, jogo.Carro.PosicaoY));
            var i = 0;

            foreach (var ob in jogo.Obstaculos)
            {
                if (ob.PosicaoY >= 0)
                {
                    pictureBoxes[i].Location = new Point(ob.PosicaoX, ob.PosicaoY);
                }
                i++;
            }
            if ((DateTime.Now - tempoUltimaMocimentaca).Milliseconds > jogo.Velocidade)
            {
                tempoUltimaMocimentaca = DateTime.Now;
                jogo.MovimentaObstaculos();
            }
            if (jogo.ChecarColisao())
            {
                GameOver();
            }
            Application.DoEvents();
        }

        private void GameOver()
        {
            TimerJogo.Enabled= false;
            TocarSomBatida();
            Close();
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
            Thread.Sleep(1000);
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
