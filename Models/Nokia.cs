namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia: Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria){
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(String Aplicativo){
        Console.WriteLine("verificando a conta Google");
        Console.WriteLine("Baixando pacotes...");
        Console.WriteLine($"Instalação do {Aplicativo} concluída!");
        }
    }
}