namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _Modelo;
        private string _IMEI;
        private int _Memoria;

    public void Ficha(){
            Console.WriteLine($"Numero: {Numero}\nModelo: {_Modelo}\nImei: {_IMEI}\nMemória: {_Memoria}");
        }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _Modelo = modelo;
            _IMEI = imei;
            _Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
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