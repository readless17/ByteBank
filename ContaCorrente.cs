using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        private string _conta;
        private int _numero_agencia;
        private double saldo;

        public Cliente Titular { get; set; }

        public string Nome_agencia { get; set; }

        public static int TotalDeContasCriadas { get; set; }

         public string Conta
        { 
            get
            {
                return _conta;
            }
            set
            {
                if (value != null)
                {
                    _conta = value;
                }
                else
                {
                    return;
                }
            }
        }

        public int Numero_agencia 
        { 
            get
            {
                return _numero_agencia;
            } 
            set
            {
                if(value > 0)
                {
                    _numero_agencia = value;
                }
            }
        }
                
        public bool Sacar(double valor)
        {
            if (valor < 0)
            {
                return false;
            }

            if (saldo > valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor < 0)
            {
                return false;
            }

            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value > 0)
                {
                    saldo += value;
                }
                else
                {
                    return;
                }
            }
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }
    }
}
