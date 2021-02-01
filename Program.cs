﻿using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Transferência");

            // obtem a opção selecionada pelo usuário
            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new service.ContaCorrenteService().OperacaoDeposito();
                    break;

                case '2':
                    new service.ContaCorrenteService().OperacaoSaque();
                    break;

                case '3':
                    new service.ContaCorrenteService().OperacaoTransferencia();
                    break;
            }
        }
    }
}
