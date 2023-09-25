using PROVA___3bim.classes;
public class Program
{
	static void Main(string[] args)
	{
        List <Funcionario> listaFun = new List<Funcionario> ();
        List <Medico> listaMed = new List<Medico> ();
        List <Administrativo> listaAdm = new List<Administrativo> ();

        int opcao = 1;

		while(opcao!=0)
		{

            Console.WriteLine("\nDigite a opção desejada: ");
            Console.WriteLine("0 - Fechar o programa");
            Console.WriteLine("1 - Cadastrar um Funcionário");
            Console.WriteLine("2 - Cadastrar um Médico");
            Console.WriteLine("3 - Cadastrar um Funcionário administrativo");
            Console.Write("Opção escolhida: ");
            opcao = Convert.ToInt32(Console.ReadLine());

           
            if(opcao == 1)
            {
                Funcionario a = new Funcionario();
                Console.Write("\nDigite o nome do funcionário: ");
                a.Nome = Console.ReadLine();
                Console.Write("Digite o CPF do funcionário: ");
                a.Cpf = Console.ReadLine();
                Console.Write("Digite a matrícula do funcionário: ");
                a.Matricula = Console.ReadLine();
                Console.Write("Digite a data de nascimento do funcionário: ");
                a.DataNasc = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Digite o sexo do funcionário: ");
                a.Sexo = Console.ReadLine();
                Console.Write("Digite o salário do funcionário: ");
                a.Salario = Convert.ToDouble(Console.ReadLine());

                listaFun.Add(a);

            }
            else if(opcao == 2)
            {
                Medico m = new Medico();
                Console.Write("\nDigite o nome do médico: ");
                m.Nome = Console.ReadLine();
                Console.Write("Digite o CPF do médico: ");
                m.Cpf = Console.ReadLine();
                Console.Write("Digite a matrícula do médico: ");
                m.Matricula = Console.ReadLine();
                Console.Write("Digite a data de nascimento do médico: ");
                m.DataNasc = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Digite o sexo do médico: ");
                m.Sexo = Console.ReadLine();
                Console.Write("Digite o salário do médico: ");
                m.Salario = Convert.ToDouble(Console.ReadLine());
;               Console.Write("Digite o CRM do médico: ");
                m.Crm = Console.ReadLine();
                Console.Write("Digite o valor da hora extra do médico: ");
                m.ValorHoraExtra = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a especialidade do médico: ");
                m.Especialidade = Console.ReadLine();

                m.CalculoSalarioMed();

                listaMed.Add(m);

            }
            else if(opcao == 3) 
            {
                Administrativo adm = new Administrativo();
                Console.Write("\nDigite o nome do funcionário administrativo: ");
                adm.Nome = Console.ReadLine();
                Console.Write("Digite o CPF do funcionário administrativo: ");
                adm.Cpf = Console.ReadLine();
                Console.Write("Digite a matrícula do funcionário administrativo: ");
                adm.Matricula = Console.ReadLine();
                Console.Write("Digite a data de nascimento do funcionário administrativo: ");
                adm.DataNasc = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Digite o sexo do funcionário administrativo: ");
                adm.Sexo = Console.ReadLine();
                Console.Write("Digite o salário do funcionário administrativo: ");
                adm.Salario = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a função do funcionário administrativo: ");
                adm.Funcao = Console.ReadLine();

                adm.CalculoSalarioAdm();

                listaAdm.Add(adm);

            }
            else if(opcao == 0)
            {
                Console.WriteLine("\nObrigada por usar meu programa! XD");      
            }
            else
            {
                Console.WriteLine("\nOpção inválida!");
            }
        }

        Console.WriteLine("\nLista de Funcionários: ");
        foreach (Funcionario fun in listaFun)
        {
            Console.WriteLine(fun);
        }

        Console.WriteLine("\nLista de Médicos: ");
        foreach (Medico med in listaMed)
        {
            Console.WriteLine(med);
        }

        Console.WriteLine("\nLista de Funcionários Administrativos: ");
        foreach (Administrativo adm in listaAdm)
        {
            Console.WriteLine(adm);
        }
        
    }
}
