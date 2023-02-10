using ContaBancaria;
using ContaBancaria.Contas;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {

        //Instanciando investimento:

        ContaInvestimento investimentoDeLucas = new ContaInvestimento();
        investimentoDeLucas.investir(1000, 12);
        Console.WriteLine("O investimento de Lucas em " + investimentoDeLucas.tempo +" meses rendeu : R$ "+investimentoDeLucas.verInvestimento());


        //Instanciado a classe Titular:


        Titular t = new Titular();
        t.nome = "Lucas";
        t.profissao = "Desenvolvedor .NET";
        t.cpf = "121221212";

        // Intanciando a conta do Lucas:


        ContaCorrente contaLucas = new ContaCorrente();
        contaLucas.Investimento = investimentoDeLucas;
        contaLucas.Titular = t;
        contaLucas.Agence = 15;
        contaLucas.Depositar(5700);
        contaLucas.Sacar(600);

        //Instanciando investimento:

        ContaInvestimento investimentoDeMaria = new ContaInvestimento();
        investimentoDeMaria.investir(100, 14);
        Console.WriteLine("O investimento de Maria em " +investimentoDeMaria.tempo+" meses rendeu R$" + investimentoDeMaria.verInvestimento());

        // Instanciando a classe Titular:


        Titular m = new Titular();
        m.nome = "Maria";
        m.profissao = "Desenvolvedora DevOps";
        m.cpf = "0909099090";


        // Instaciando a conta da Maria


        ContaCorrente contaMaria = new ContaCorrente();
        contaMaria.Titular = m;
        contaMaria.Agence = 17;
        contaMaria.Depositar(5000);

        // Realizando a trasnferencia :


        contaLucas.Transferir(1500, contaMaria);

       
        // Exibindo informações sobre as contas: 

            // Informações Lucas :

        Console.WriteLine("Cliente: " + contaLucas.Titular.nome);
        Console.WriteLine("Profissão: " + contaLucas.Titular.profissao);
        Console.WriteLine("Saldo final de " + contaLucas.Titular.nome + " : R$ " + contaLucas.verSaldo());

            // Informações Maria :

        Console.WriteLine("Cliente: " + contaMaria.Titular.nome);
        Console.WriteLine("Profissão: " + contaMaria.Titular.profissao);
        Console.WriteLine("Saldo final de " + contaMaria.Titular.nome + " : R$ " + contaMaria.verSaldo());

    }
}