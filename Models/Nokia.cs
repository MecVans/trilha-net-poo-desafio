namespace DesafioPOO.Models
{
    // FEITO!
    public class Nokia : Smartphone
    {
        // public Nokia() //Permitir que o usuário não precise informar os dados.
        // {

        // }
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // FEITO!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Nokia.");
        }
    }
}