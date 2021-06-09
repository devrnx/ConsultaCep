using RestSharp;

namespace ConsultarCep.Modelo {

    public class RestModel {

        public string GerarToken(string cep) {

            var client = new RestClient($"https://viacep.com.br/ws/{cep}/json/");
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful) {
                return response.Content;
            }
            
            else {
                return response.ErrorMessage;
            }
        }

    }
}
