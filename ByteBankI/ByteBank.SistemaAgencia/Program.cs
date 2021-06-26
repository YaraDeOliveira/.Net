using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Yara, me ligue no 93785-8758";
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);

            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            Console.ReadLine();




            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValor = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorOrigem = extratorDeValor.GetValor("moedaOrigem");
            Console.WriteLine("Moeda Origem: " + valorOrigem);
            
            string valorDestino = extratorDeValor.GetValor("moedaDestino");
            Console.WriteLine("Moeda Destino: " + valorDestino);

            Console.WriteLine("Valor:" + extratorDeValor.GetValor("valor"));
            Console.ReadLine();

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            //Console.WriteLine(url);
            //int indiceInterrogacao = url.IndexOf('?');
            //Console.WriteLine($"Indice ? = " + indiceInterrogacao);
            //string argumentos = url.Substring(indiceInterrogacao+1);
            //Console.WriteLine(argumentos);



            //DateTime dataFimPagamento = new DateTime(2022, 06, 22 );

            //DateTime datacorrente = DateTime.Now;

            //TimeSpan diferenca = dataFimPagamento - datacorrente;

            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(datacorrente);
            //Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca));
           
        }
    }
}
