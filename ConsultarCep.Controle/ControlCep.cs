using ConsultarCep.DTO;
using ConsultarCep.Modelo;
using Newtonsoft.Json;
using System;

namespace ConsultarCep.Controle {
    public class ControlCep {
        RestModel rest = new RestModel();

        public void GerarRest(string cep) {
            string responseContentGet = rest.GerarToken(cep);

            ReturnCep dados = JsonConvert.DeserializeObject<ReturnCep>(responseContentGet);

            if (dados != null) {
                Console.WriteLine($"\nLogradouro: {dados.logradouro}\nBairro: {dados.bairro}\nLocalidade: {dados.localidade}\nUF: {dados.uf}\nDDD: {dados.ddd}");
            }
            else {
                Console.WriteLine("\nDATA INVÁLIDA");
            }

        }

    }
}
