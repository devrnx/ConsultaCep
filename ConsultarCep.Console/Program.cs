using ConsultarCep.Controle;

namespace ConsultarCep.Console {
    class Program {
        static void Main(string[] args) {
            ControlCep controller = new ControlCep();
            System.Console.WriteLine("INFORME O CEP (XXXX-XXX): ");
            string cep = System.Console.ReadLine();
            controller.GerarRest(cep);
            System.Console.ReadLine();     
        }
    }
}
