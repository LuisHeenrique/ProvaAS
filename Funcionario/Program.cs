namespace EmpresaNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menu Principal:\n");
                Console.WriteLine("1. Adicionar Funcionário(a) de Tempo Integral");
                Console.WriteLine("2. Adicionar Funcionário(a) de Meio Período");
                Console.WriteLine("3. Remover Funcionário(a)");
                Console.WriteLine("4. Exibir Informações de Todos os Funcionários");
                Console.WriteLine("5. Adicionar Projeto(s) a um Funcionário(a)");
                Console.WriteLine("6. Sair \n ");
                Console.Write("Escolha uma opção acima:");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarFuncionarioTempoIntegral(empresa);
                        break;
                    case "2":
                        AdicionarFuncionarioMeioPeriodo(empresa);
                        break;
                    case "3":
                        RemoverFuncionario(empresa);
                        break;
                    case "4":
                        empresa.ExibirFuncionarios();
                        break;
                    case "5":
                        AdicionarProjetos(empresa);
                        break;
                    case "6":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Salário Mensal: ");
            double salario = double.Parse(Console.ReadLine());

            var funcionario = new FuncionarioTempoIntegral(nome, matricula, salario);
            empresa.AdicionarFuncionario(funcionario);
        }

        static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Salário por Hora: ");
            double salarioPorHora = double.Parse(Console.ReadLine());
            Console.Write("Número de Horas Trabalhadas: ");
            int numeroDeHoras = int.Parse(Console.ReadLine());

            var funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, numeroDeHoras);
            empresa.AdicionarFuncionario(funcionario);
        }

        static void RemoverFuncionario(Empresa empresa)
        {
            Console.Write("Matrícula do Funcionário a ser removido: ");
            int matricula = int.Parse(Console.ReadLine());
            empresa.RemoverFuncionario(matricula);
        }

        static void AdicionarProjetos(Empresa empresa)
        {
            Console.Write("Matrícula do Funcionário: ");
            int matricula = int.Parse(Console.ReadLine());

            var funcionario = empresa.Funcionarios.FirstOrDefault(f => f.Matricula == matricula);
            if (funcionario != null)
            {
                Console.Write("Quantos projetos deseja adicionar? ");
                int qtdProjetos = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtdProjetos; i++)
                {
                    Console.Write($"Nome do Projeto {i + 1}: ");
                    string projeto = Console.ReadLine();
                    funcionario.AdicionarProjeto(projeto);
                }
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }
}
