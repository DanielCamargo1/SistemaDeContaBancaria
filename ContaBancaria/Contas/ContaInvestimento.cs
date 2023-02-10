using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Contas
{
//**APENAS UMA SIMULAÇÃO DE INVESTIMENTO** O  calculo esta sendo baseado em Juros Simples, em um rentabilidade de 4,18% ao mês;
    public class ContaInvestimento : ContaCorrente
    {
        public ContaCorrente contaCorrente { get; set; }
        public double tempo { get; set; }
        public double resultadoInvestimeto { get; set; }

        public double verInvestimento()
        {
            return resultadoInvestimeto;
        }
        public bool investir(double valor, int meses)
        {
            if(meses >= 1)
            {
                if(valor > 5)
                {
                    this.saldo -= valor;
                    double operacao = valor * 0.418 * meses;
                    this.resultadoInvestimeto = operacao;
                    this.tempo = meses;
                    this.saldo += operacao;
                    return true;
                }
                else
                {
                    Console.WriteLine("Apenas liberamos investimentos acima de R$ 5.00");
                    return false; 
                }
            }
            else
            {
                Console.WriteLine("Inpossível realizar investimentos durante esse tempo!");
                return false;
            }
        }
    }
}