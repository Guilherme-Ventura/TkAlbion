using RestSharp;
using Newtonsoft.Json;
using System;

namespace TkAlbion
{
    internal class ColetarDados
    {
        public InfoJogador BuscarIdJogador(string nomeJogador)
        {
            var client = new RestClient("https://gameinfo.albiononline.com/api/gameinfo/search?q=" + nomeJogador);
            
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            
            InfoJogador infoBase = JsonConvert.DeserializeObject<InfoJogador>(response.Content);

            return infoBase;
        }

        public static dynamic BuscarPerfil(string idJogador)
        {
            var client = new RestClient("https://gameinfo.albiononline.com/api/gameinfo/players/" + idJogador);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            DadosPersonagem saida =  JsonConvert.DeserializeObject<DadosPersonagem>(response.Content);

            return saida;
        }

    }
}
