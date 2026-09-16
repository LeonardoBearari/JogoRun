namespace JogoRun
{
    public class Elemento
    {
        public TipoElemento Tipo { get; set; }
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public bool Contabilizado { get; set; }
        public int Variante { get; set; }

        public void Movimentar(int x, int y)
        {
            PosicaoX = x;
            PosicaoY = y;
        }
    }
}
