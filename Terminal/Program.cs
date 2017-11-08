using System;
using Dados;
using Util;
using NetOffice.ExcelApi;

namespace Terminal {
    class Program {
        static void Main (string[] args) {

            string opcao = "";

            //Menu principal 
            do {
                Console.WriteLine ("Digite a opção");
                Console.WriteLine ("1 - Cadastrar Conta");
                Console.WriteLine ("2 - Sacar");
                Console.WriteLine ("3 - Depositar");
                Console.WriteLine ("9 - Sair");

                opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        {
                            ContaPessoaJuridica contajur = new ContaPessoaJuridica ();
                            contajur.CadastrarConta ();
                            break;
                        }
                }
            } while (opcao != "9");
        }
    }
}