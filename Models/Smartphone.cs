namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // FEITO!
        private string modelo;
        private string imei;
        private int memoria;

        public Smartphone()
        {

        }
        public Smartphone(string numero, string modeloDoCelular, string imeiDoCelular, int memoriaDoCelular)
        {
            Numero = numero;
            // FEITO!
            modelo = modeloDoCelular;
            imei = imeiDoCelular;
            memoria = memoriaDoCelular;
        }
        public void ExibirNumero()
        {
            Console.WriteLine("O número do seu celular é: " + Numero);
        }
        public void ExibirModelo()
        {
            Console.WriteLine("O modelo do seu celular é: " + modelo);
        }
        public void ExibirIMEI()
        {
            Console.WriteLine("O IMEI do seu celular é: " + imei);
        }
        public void ExibirMemoriaDocelular()
        {
            Console.WriteLine("A memoria do seu celular é de: " + memoria.ToString("# GB"));
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
      

        public abstract void InstalarAplicativo(string nomeApp);
    }
}