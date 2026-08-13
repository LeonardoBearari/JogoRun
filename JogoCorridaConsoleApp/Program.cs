using JogoRun;
using System.Data;
class Program
{
    static void Main()
    {
        Jogo jogo = new Jogo();
        jogo.Faixa1Inicio = 1;
        jogo.Faixa1Fim = 11;
        jogo.Faixa2Inicio = 13;
        jogo.Faixa2Fim = 22;
        jogo.YMaximo = 11;
        jogo.IniciaJogo();
        jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);
        jogo.Velocidade = 10;
        var tempoUltimaMocimentaca = DateTime.Now;

        
        for (; ; )
        {
            DesenhaCenario();
            DesenhaElemento(jogo.Carro.PosicaoY, jogo.Carro.PosicaoX, '8');

            

            foreach (var ob in jogo.Obstaculos)
            {
                if (ob.PosicaoY >= 0)
                {
                    DesenhaElemento(ob.PosicaoY, ob.PosicaoX, '0');
                }
            }
            if((DateTime.Now - tempoUltimaMocimentaca).Milliseconds > jogo.Velocidade)
            {
                tempoUltimaMocimentaca = DateTime.Now;
                jogo.MovimentaObstaculos();
            }

            if (Console.KeyAvailable)
            {
                var tecla = Console.ReadKey();
                Console.WriteLine(tecla.Key.ToString());
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    jogo.Carro.PosicaoX = jogo.PosicionaObjeto(1);

                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    jogo.Carro.PosicaoX = jogo.PosicionaObjeto(2);

                }

            }
            if (jogo.ChecarColisao())
            {
                GameOver();
                TocarSom();
                break;
            }
            Thread.Sleep(100);
        }
    }

    public static void GameOver()
    {
        Console.Clear();
        Console.WriteLine("GAME OVER");

    }
    public static void DesenhaElemento(int linha, int coluna, char simbolo)
    {
        var xOriginal = Console.CursorLeft;
        var yOriginal = Console.CursorTop;
        Console.SetCursorPosition(coluna, linha);
        Console.Write(simbolo.ToString());
        Console.SetCursorPosition(xOriginal, yOriginal);
    }

    public static void DesenhaCenario()
    {
        Console.Clear();
        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("|          |          |");
        Console.WriteLine("+----------+----------+");

    }
    static void TocarSom()
    {
        Console.Beep();
    }

}


