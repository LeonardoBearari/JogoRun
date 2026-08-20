using JogoRun;

namespace JogoCorridaWinFormsApp

{
    public partial class FormJogo : Form
    {
        Jogo jogo;
        DateTime tempoUltimaMocimentaca = DateTime.Now;
        List<PictureBox> pictureBoxes = [];

        public FormJogo()
        {
            InitializeComponent();
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
            jogo.Velocidade = 20;

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


                Application.Exit();
            }
            Thread.Sleep(100);
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
