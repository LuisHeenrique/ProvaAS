namespace EmpresaNamespace
{
    public class FuncionarioMeioPeriodo : Funcionario, IBonus
    {
        private double SalarioPorHora;
        private int NumeroDeHoras;

        public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int numeroDeHoras)
            : base(nome, matricula)
        {
            SalarioPorHora = salarioPorHora;
            NumeroDeHoras = numeroDeHoras;
        }

        public override double CalcularSalario()
        {
            return SalarioPorHora * NumeroDeHoras;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário: R$ {CalcularSalario()}");
        }

        public double CalcularBonus()
        {
            return CalcularSalario() * 0.05;
        }
    }
}
