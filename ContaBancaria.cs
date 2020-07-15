using System;
using System.Collections.Generic;
using System.Text;

namespace POO1
{
    class ContaBancaria
    {
        public string Conta;
        public string Agencia;
        public string Nome;
        public string Senha = "senha123";
        public int Saldo;

        public ContaBancaria(int saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(int valor)
        {
            Saldo = Saldo + valor;
        }


        public void Sacar(int valor)
        {
            Saldo = Saldo - valor;
        }

        public int ConsultarSaldo()
        {
            int taxa = 10;
            int valorTaxa = (Saldo * 10) / 100;
            return Saldo - valorTaxa;
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"{Nome}, aqui esta seu saldo(R$) da sua conta {Conta} na agencia {Agencia}: {ConsultarSaldo()}");
        }
    }
}
