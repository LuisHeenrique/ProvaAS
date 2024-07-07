namespace EmpresaNamespace
{
    public class Empresa
    {
        // Torne a lista 'Funcionarios' pública
        public List<Funcionario> Funcionarios { get; set; }

        public Empresa()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void RemoverFuncionario(int matricula)
        {
            var funcionario = Funcionarios.FirstOrDefault(f => f.Matricula == matricula);
            if (funcionario != null)
            {
                Funcionarios.Remove(funcionario);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void ExibirFuncionarios()
        {
            foreach (var funcionario in Funcionarios)
            {
                funcionario.ExibirInformacoes();
            }
        }
    }
}
