using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Contas
{
    public class ContaCorrente 
    {
        public Titular Titular { get; set; }
        public int Agence { get; set; }
        public string Conta { get; set; }
        public double saldo { get; set; }
        public ContaInvestimento Investimento { get; set; }


        public double verSaldo()
        {
            return saldo;
        } 
        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            else
            {
                Console.WriteLine("Valor indisponível para deposito");
                return false;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor < saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Valor indisponivel para saque");
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
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
    }
}
