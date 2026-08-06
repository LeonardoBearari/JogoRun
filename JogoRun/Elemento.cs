namespace JogoRun
{
    public class Elemento
    {
       //atributos
       public TipoElemento Tipo {  get; set; }
       public int PosicaoX { get; set; }
       public int PosicaoY {  get; set; }
       public int Altura { get; set; }
       public int Largura { get; set; }
       
       public void Movimentar(int x, int y)
        {
            PosicaoX = x; 
            PosicaoY = y;
        }
    }
}
