namespace Blackjack
{
    public partial class frmJogo : Form
    {

        public class Carta
        {
            public string Nome { get; set; }
            public int Valor { get; set; }
            public string Imagem { get; set; }
        }

        public class Baralho
        {
            private List<Carta> cartas;

            public Baralho()
            {
                cartas = new List<Carta>();
                CriarBaralho();
                Embaralhar();
            }

            private void CriarBaralho()
            {
                string[] naipes = { "copas", "espadas", "ouros", "paus" };
                string[] valores = { "as", "2", "3", "4", "5", "6", "7", "8", "9", "10", "valete", "dama", "rei" };
                int[] pontos = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

                for (int i = 0; i < naipes.Length; i++)
                {
                    for (int j = 0; j < valores.Length; j++)
                    {
                        cartas.Add(new Carta
                        {
                            Nome = valores[j] + "_" + naipes[i],
                            Valor = pontos[j],
                            Imagem = "Resources/" + valores[j] + "_" + naipes[i] + ".png"
                        });
                    }
                }
            }

            private void Embaralhar()
            {
                Random rand = new Random();
                cartas = cartas.OrderBy(c => rand.Next()).ToList();
            }

            public Carta PuxarCarta()
            {
                Carta carta = cartas[0];
                cartas.RemoveAt(0);
                return carta;
            }
        }

        private Baralho baralho;
        private List<Carta> cartasJogador;
        private List<Carta> cartasDealer;
        private int pontosJogador;
        private int pontosDealer;
        private bool cartaViradaDealer;

        public frmJogo()
        {
            InitializeComponent();
            IniciarJogo();
        }
        private void IniciarJogo()
        {
            baralho = new Baralho();
            cartasJogador = new List<Carta>();
            cartasDealer = new List<Carta>();
            pontosJogador = 0;
            pontosDealer = 0;
            cartaViradaDealer = true;

            pbCartaJogador1.Image = null;
            pbCartaJogador2.Image = null;
            pbCartaJogador3.Image = null;
            pbCartaJogador4.Image = null;
            pbCartaJogador5.Image = null;
            pbCartaDealer1.Image = null;
            pbCartaDealer2.Image = null;

            lblPontosJogador.Text = "Pontos Jogador: 0";
            lblPontosDealer.Text = "Pontos Dealer: ?";

            DistribuirCartaJogador();
            DistribuirCartaJogador();
            DistribuirCartaDealer();
            DistribuirCartaDealer();
        }

        private void DistribuirCartaJogador()
        {
            var carta = baralho.PuxarCarta();
            cartasJogador.Add(carta);
            pontosJogador = CalcularPontos(cartasJogador);

            if (pbCartaJogador1.Image == null)
            {
                pbCartaJogador1.Image = Image.FromFile(carta.Imagem);
            }
            else if (pbCartaJogador2.Image == null)
            {
                pbCartaJogador2.Image = Image.FromFile(carta.Imagem);
                pbCartaJogador2.BringToFront();
            }
            else if (pbCartaJogador3.Image == null)
            {
                pbCartaJogador3.Image = Image.FromFile(carta.Imagem);
                pbCartaJogador3.BringToFront();
            }
            else if (pbCartaJogador4.Image == null)
            {
                pbCartaJogador4.Image = Image.FromFile(carta.Imagem);
                pbCartaJogador4.BringToFront();
            }
            else
            {
                pbCartaJogador5.Image = Image.FromFile(carta.Imagem);
                pbCartaJogador5.BringToFront();
            }

            lblPontosJogador.Text = "Pontos Jogador: " + pontosJogador;
        }

        private void DistribuirCartaDealer()
        {
            var carta = baralho.PuxarCarta();
            cartasDealer.Add(carta);
            pontosDealer = CalcularPontos(cartasDealer);

            // Se for a primeira carta do dealer, mostramos normalmente
            if (cartasDealer.Count == 1)
            {
                pbCartaDealer1.Image = Image.FromFile(carta.Imagem);
            }
            else if (cartasDealer.Count == 2 && cartaViradaDealer)
            {
                // A segunda carta do dealer come�a virada para baixo
                pbCartaDealer2.Image = Image.FromFile("Resources/carta.png");
            }

            // Atualizamos a pontuação apenas da primeira carta do dealer visivel
            if (!cartaViradaDealer)
            {
                lblPontosDealer.Text = "Pontos Dealer: " + pontosDealer;
            }
            else
            {
                // Apenas mostra o valor da primeira carta, como o jogador não sabe ainda o valor completo
                lblPontosDealer.Text = "Pontos Dealer: ?";
            }
        }

        private int CalcularPontos(List<Carta> cartas)
        {
            int pontos = cartas.Sum(c => c.Valor);
            int ases = cartas.Count(c => c.Valor == 11);

            // Se tiver ás e a pontua��o ultrapassar 21, o ás vale 1
            while (pontos > 21 && ases > 0)
            {
                pontos -= 10;
                ases--;
            }

            return pontos;
        }

        private void btnPedirCarta_Click(object sender, EventArgs e)
        {
            DistribuirCartaJogador();

            if (pontosJogador > 21)
            {
                MessageBox.Show("Você perdeu!");
                IniciarJogo();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            // Revelar a segunda carta do dealer
            cartaViradaDealer = false;
            pbCartaDealer2.Image = Image.FromFile(cartasDealer[1].Imagem);
            lblPontosDealer.Text = "Pontos Dealer: " + pontosDealer;

            // O dealer joga até ter 17 ou mais pontos
            while (pontosDealer < 17)
            {
                DistribuirCartaDealer();
            }

            if (pontosDealer > 21 || pontosJogador > pontosDealer)
            {
                MessageBox.Show("Você venceu!");
            }
            else if (pontosJogador == pontosDealer)
            {
                MessageBox.Show("Empate!");
            }
            else
            {
                MessageBox.Show("Dealer venceu!");
            }

            IniciarJogo();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }
    }
}
