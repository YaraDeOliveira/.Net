using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    class ContaCorrente

    {
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidos { get; private set; }
        public static double TaxaOperacao { get; set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int NumeroAgencia { get; }
       
        public int NumeroConta { get; }
      
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        

        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0) 
            {
                throw new ArgumentException("A agencia deve ser maior que 0! ", nameof(numeroAgencia));
                
            }

            if  (numeroConta <= 0)
            {
                throw new ArgumentException("O numero deve ser maior que 0! ", nameof(numeroConta));
                
            }


            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

            
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque ", nameof(valor));
            }
           
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                SaldoInsuficienteException ex = new SaldoInsuficienteException();
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para a transferência ", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }

            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
                    
            }
            
            contaDestino.Depositar(valor);
            
        }
    }
}
