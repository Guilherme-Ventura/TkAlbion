using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkAlbion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nickname: ");
            string nickname = Console.ReadLine();

            ColetarDados executa = new ColetarDados();
            InfoJogador infoJogador = executa.BuscarIdJogador(nickname);
            dynamic infoPersonagem = ColetarDados.BuscarPerfil(infoJogador.players[0].Id);

            Console.WriteLine("\nNome: " + infoJogador.players[0].Name + "\nId: " + infoJogador.players[0].Id);
            Console.WriteLine("\n-----------LifetimeStatistics----------" + "\nPvE");
            Console.WriteLine("\nTotal: " + infoPersonagem.LifetimeStatistics.PvE.Total + "\nRoyal: " + infoPersonagem.LifetimeStatistics.PvE.Royal + "\nOutlands: " + infoPersonagem.LifetimeStatistics.PvE.Outlands + 
                "\nAvalon: " + infoPersonagem.LifetimeStatistics.PvE.Avalon + "\nHellgate: " + infoPersonagem.LifetimeStatistics.PvE.Hellgate + "\nCorruptedDungeon: " + infoPersonagem.LifetimeStatistics.PvE.CorruptedDungeon);
            Console.WriteLine("\n-----------Gathering----------");
            Console.WriteLine("\nFiber" + "\nTotal: " + infoPersonagem.LifetimeStatistics.Gathering.Fiber.Total + "\nRoyal: " + infoPersonagem.LifetimeStatistics.Gathering.Fiber.Royal+ "\noutlands: " + infoPersonagem.LifetimeStatistics.Gathering.Ore.Outlands + "\nAvalon: " + infoPersonagem.LifetimeStatistics.Gathering.Ore.Avalon);
            Console.WriteLine("\nHide" + "\nTotal: " + infoPersonagem.LifetimeStatistics.Gathering.Hide.Total + "\nRoyal: " + infoPersonagem.LifetimeStatistics.Gathering.Hide.Royal + "\noutlands: " + infoPersonagem.LifetimeStatistics.Gathering.Hide.Outlands + "\nAvalon: " + infoPersonagem.LifetimeStatistics.Gathering.Hide.Avalon);
            Console.WriteLine("\nOuro" + "\nTotal: " + infoPersonagem.LifetimeStatistics.Gathering.Ore.Total + "\nRoyal: " + infoPersonagem.LifetimeStatistics.Gathering.Ore.Royal+ "\noutlands: " + infoPersonagem.LifetimeStatistics.Gathering.Ore.Outlands + "\nAvalon: " + infoPersonagem.LifetimeStatistics.Gathering.Ore.Avalon);
            Console.WriteLine("\nRock" + "\nTotal: " + infoPersonagem.LifetimeStatistics.Gathering.Rock.Total + "\nRoyal: " + infoPersonagem.LifetimeStatistics.Gathering.Rock.Royal + "\noutlands: " + infoPersonagem.LifetimeStatistics.Gathering.Rock.Outlands + "\nAvalon: " + infoPersonagem.LifetimeStatistics.Gathering.Rock.Avalon);
            Console.WriteLine("\nWood" + "\nTotal: " + infoPersonagem.LifetimeStatistics.Gathering.Wood.Total + "\nRoyal: " + infoPersonagem.LifetimeStatistics.Gathering.Wood.Royal + "\noutlands: " + infoPersonagem.LifetimeStatistics.Gathering.Wood.Outlands + "\nAvalon: " + infoPersonagem.LifetimeStatistics.Gathering.Wood.Avalon);
            Console.WriteLine("\nAll" + "\nTotal: " + infoPersonagem.LifetimeStatistics.Gathering.All.Total + "\nRoyal: " + infoPersonagem.LifetimeStatistics.Gathering.All.Royal + "\noutlands: " + infoPersonagem.LifetimeStatistics.Gathering.All.Outlands + "\nAvalon: " + infoPersonagem.LifetimeStatistics.Gathering.All.Avalon);
            //Console.WriteLine(infoJogador.players[0].Id + " - " + infoJogador.players[0].Name);
            //imprimeDadosJogador(infoPersonagem);


            Console.ReadKey();
        }


        //static void imprimeDadosJogador(dynamic infoPersonagem, int identacao = 0)
        //{
        //    foreach (var dado in infoPersonagem)
        //    {
        //        var tipo = dado.Value?.GetType();

        //        string textoImprimir = "";
        //        for (int i = 0; i < identacao; i++)
        //        {
        //            textoImprimir += "  ";
        //        }

        //        if (tipo != null && tipo.Name == "ExpandoObject")
        //        {
        //            textoImprimir += $"{dado.Key.ToString()}:";
        //            Console.WriteLine(textoImprimir);
        //            imprimeDadosJogador(dado.Value, identacao + 1);
        //        }
        //        else
        //        {

        //            if (tipo == null)
        //                textoImprimir += $"{dado.Key.ToString()}: ";
        //            else
        //                textoImprimir += $"{dado.Key.ToString()}: {dado.Value.ToString()}";

        //            Console.WriteLine(textoImprimir);
        //        }
        //    }
        //}
    }
}
