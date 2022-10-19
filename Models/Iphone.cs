namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        public Iphone (string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria){
        }

        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(String Aplicativo){
            Console.WriteLine("Concetcando ao iTunes...");
            Console.WriteLine("verificando a conta");
            Console.WriteLine("Pagamento aprovado");
            Console.WriteLine("Baixando pacotes da AppStore");
            Console.WriteLine("Verificando segurança...");
            Console.WriteLine($"O aplicativo {Aplicativo} foi instalado com sucesso!!!");
        }
    }
}