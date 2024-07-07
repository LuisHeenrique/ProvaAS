namespace EmpresaNamespace
{
    public class FuncionarioTempoIntegral : Funcionario, IBonus
    {
        private double SalarioMensal;

        public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal)
            : base(nome, matricula)
        {
            SalarioMensal = salarioMensal;
        }

        public override double CalcularSalario()
        {
            return SalarioMensal;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário: R$ {CalcularSalario()}");
        }

        public double CalcularBonus()
        {
            return SalarioMensal * 0.10;
        }
    }
}
