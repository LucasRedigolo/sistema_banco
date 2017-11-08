using System;
using Util;

namespace Dados {
    public class ContaPessoaJuridica : Conta {
        public Empresa empresa { get; set; }
        /// <summary>
        /// Efetua saque na conta pessoa física mais 50 centavos
        /// </summary>
        /// <param name="Valor">parametro do tipo double com o valor do saque</param>
        /// <returns>Retorna o saldo</returns>
        public override double Sacar (double Valor) {
            this.Saldo -= (Valor + 0.50);
            return this.Saldo;
        }
        /// <summary>
        /// Efetua o cadastro de uma conta de PJ
        /// </summary>
        public void CadastrarConta () {
            Console.WriteLine ("Digite a Razao Social");
            string razaosocial = Console.ReadLine ();

            Console.WriteLine ("Digite a data de abertura");
            string dataabertura = Console.ReadLine ();

            Validacao validacao = new Validacao ();
            bool cnpjvalido = false;

            do {
                Console.WriteLine ("Digite seu cnpj");
                string cnpj = Console.ReadLine ();
                cnpjvalido = validacao.ValidarCNPJ (cnpj);

                if (cnpjvalido != true) {
                    Console.WriteLine ("Cnpj inválido");
                }
            } while (cnpjvalido != true);

            System.Console.WriteLine ("Digite o Numero da Conta: ");
            string numeroConta = Console.ReadLine ();

            System.Console.WriteLine ("Digite o número da agencia:");
            string numeroAgencia = Console.ReadLine ();

            System.Console.WriteLine ("Digite o Saldo:");
            double saldo = Convert.ToDouble (Console.ReadLine ());
        }
    }
}