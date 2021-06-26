using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            } 

            URL = url;
            int indiceInterrogação = url.IndexOf('?');

            _argumentos = url.Substring(indiceInterrogação + 1);
        }
        // moedaOrigem=real&moedaDestino=dolar
        public string GetValor (string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int eComercial = resultado.IndexOf('&');

            if (eComercial == -1)
                return resultado;

            return resultado.Remove(eComercial);
        }
      
        
    }
}
