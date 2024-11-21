
using System;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            this.CPF = cpf;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        // Protected internal funciona como nivel de acessibilidade
        // apenas no projeto (loja principal) e pela classe que herda da classe pai (funcionarios)
        protected internal abstract double getBonificacao();
    }
}
