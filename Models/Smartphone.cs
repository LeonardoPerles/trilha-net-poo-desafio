namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        
        public abstract void InstalarAplicativo(string nomeApp);

        protected Smartphone(string numero)
        {          
            Numero = numero;
        }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {            
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Dados()
        {
            Console.WriteLine($"{Numero}, {Modelo}, {IMEI}, {Memoria}");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

    }
}