using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;


namespace Desafio2.service
{
    public class ContaCorrenteService
    {
        public void OperacaoSaque()
        {
         
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escreva o seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o valor que vai sacar: " + "\n");

            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new model.ContaCorrente()
            {
                Agencia = 1234,
                Titular = "Nelismy",
                Numero = 54321,
                Saldo = 1000
            };

            var saque = Sacar(valor, conta.Saldo);

     
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "O seu saque foi realizado com sucesso!" + "\n" + $"Valor do saque: {valor}" + "\n");
            Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {saque}");
            Console.ReadKey();
          
          
        }

        private double Sacar(double Valor, double Saldo)
        {
             if (Saldo < Valor)
            {
                Console.WriteLine($"Não foi possivel concluir a transação. Seu saldo: {Saldo} é inferior ao valor solicitado {Valor}.");
            }
            else
            {
                Saldo -= Valor;
                return Saldo;
            }
            return Saldo;
        }
        
       public void OperacaoDeposito()
        {
            
            Console.WriteLine("Escreva o seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o valor que vai depositar: " + "\n");

            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new model.ContaCorrente()
            {
                Agencia = 1234,
                Titular = "Nelismy",
                Numero = 54321,
                Saldo = 1000
            };

            var deposito = Depositar(valor, conta.Saldo);

            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "seu depósito foi realizado com sucesso!" + "\n" + $"Valor do depósito: {valor}" + "\n");
            Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {deposito}");
            Console.ReadKey();
        }

         private double Depositar(double Valor,double Saldo)
        {
            Saldo += Valor;
            return Saldo;
        }

         public void OperacaoTransferencia()
        {
            Console.WriteLine("Escreva o seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o valor que vai transferir: " + "\n");

            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new model.ContaCorrente()
            {
               Agencia = 1234,
                Titular = "Nelismy",
                Numero = 54321,
                Saldo = 1000
            };

            var contaDestino = new model.ContaCorrente()
            {
                Agencia = 9876,
                Titular = "Gloria",
                Numero = 87432,
                Saldo = 6000
            };

            var transferencia = Transferir(valor, conta.Saldo, contaDestino);

            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "a transferência foi realizada com éxito!" + "\n");
        }
        private bool Transferir(double valor, double saldo, model.ContaCorrente contaDestino)
         {
            if (saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {saldo} é inferior ao valor que vai transferir. {saldo}");
                Console.ReadKey();
            }

            saldo -= valor;
            Depositar(valor, saldo);
            Console.WriteLine($"Transferência realizada com sucesso! Seu saldo é de: {saldo}");
            Console.WriteLine();
            Console.WriteLine("Dados da conta destino");
            Console.WriteLine($"Nome: {contaDestino.Titular}" + "\n" + $"Agencia: {contaDestino.Agencia}" + "\n" + $"Numero: {contaDestino.Numero}" + "\n" + $"Valor transferido: {valor}");
            Console.ReadKey();
            return true;
        }
    }
}