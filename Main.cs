namespace CSharp_ExtensionsMethods
{
    public class GerenciamentoEscolar
    {

        public delegate void MenuDelegate();
        static void Main(string[] args)
        {

            //---------------- Instâncias de Generics -----------------------

            ClasseGenerica<Aluno> alunoObj = new ClasseGenerica<Aluno>(); //objeto genérico que imprime todos os dados do tipo 'Aluno'
            ClasseGenerica<Professor> profObj = new ClasseGenerica<Professor>(); //objeto genérico que imprime todos os dados do tipo 'Professor'



            //---------------- Instâncias de Objetos-----------------------
            Aluno aluno = new Aluno();
            Sistema sistema = new Sistema();
            Administrador admin = new Administrador();
            Funcionario func = new Funcionario();


            //---------------- Instâncias de Delegates -----------------------
            MenuDelegate menuDelegate = new MenuDelegate(sistema.MenuSistema);
            MenuDelegate menuOperacaoDelegate = new MenuDelegate(sistema.MenuOperaçãoAdmin);
            MenuDelegate menuAlunoDelegate = new MenuDelegate(sistema.MenuOperaçãoAluno);
            MenuDelegate menuProfDelegate = new MenuDelegate(sistema.MenuOperaçãoProf);
            MenuDelegate menuFuncDelegate = new MenuDelegate(sistema.MenuOperaçãoFunc);

            int optionMenu = 1;

            List<Aluno> alunos = new List<Aluno>() {
                            new Aluno()
                            {
                                Nome = "ISAAC BRASIL OLIVEIRA",
                                Sexo = 'M',
                                Notas = new double[] { 10, 10, 7, 8, 6 },
                                Turma = 'A',
                                EscolaNome = "COLÉGIO VISÃO"
                            },
                             new Aluno()
                            {
                                Nome = "GABRIEL LUIZ FREITAS",
                                Sexo = 'M',
                                Notas = new double[]  { 6, 6, 5.3, 10, 9 },
                                Turma = 'B',
                                EscolaNome = "COLÉGIO DELTA"
                             },
                              new Aluno()
                            {
                                Nome = "AMANDA CHRISTINNE SOUSA DOS SANTOS",
                                Sexo = 'F',
                                Notas = new double[]  { 10, 9, 9, 6, 3 },
                                Turma = 'C',
                                EscolaNome = "COLÉGIO WR"
                            }
        };



            List<Professor> professores = new List<Professor>() {
                            new Professor()
                            {
                                Nome = "LUTIANO",
                                Sexo = 'M',
                                Materia = "FÍSICA"
                            },
                             new Professor()
                            {
                                Nome = "ÉDER",
                                Sexo = 'M',
                                Materia = "BIOLOGIA"
                             },
                              new Professor()
                            {
                                Nome = "CHRISTOPHER",
                                Sexo = 'M',
                                Materia = "FILOSOFIA"
                            }
        };
            List<Produto> itensCantina = new List<Produto>() {
                            new Produto()
                            {
                                NomeAlimento = "RUFFLES",
                                ValorAlimento = 5.9,
                                QuantidadeItens = 10

                            },
                             new Produto()
                            {
                                NomeAlimento = "OREO",
                                ValorAlimento = 3.9,
                                QuantidadeItens = 10

                            },
                             new Produto()
                            {
                                NomeAlimento = "ÁGUA",
                                ValorAlimento = 2.5,
                                QuantidadeItens = 10


                            }
        };
            while (optionMenu != 0)
            {
                menuDelegate();

                optionMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();



                if (optionMenu == 1)
                {
                    int optionUser = 1;

                    while (optionUser != 0)//loop do login do sistema
                    {
                        System.Console.WriteLine("============================================================");
                        Console.WriteLine("LOGIN > USUARIOS ");
                        System.Console.WriteLine("============================================================");
                        sistema.MenuUsuário();

                        optionUser = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (optionUser == 1)
                        {
                            System.Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR");
                            System.Console.WriteLine("============================================================");


                            int optionOperation = 1;


                            while (optionOperation != 0)//loop do login do usuario
                            {
                                menuOperacaoDelegate();

                                optionOperation = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                if (optionOperation == 1)
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > CADASTRAR PROFESSORES");
                                    System.Console.WriteLine("============================================================");

                                    Console.WriteLine("\r\nProfessores: \r\n");
                                    profObj.MostraLista(professores);


                                    List<Professor> listaProfessores = admin.CadastraProfessor(professores)!;
                                    professores = listaProfessores;
                                    Console.WriteLine("Professores: \r\n");
                                    profObj.MostraLista(listaProfessores);



                                }
                                else if (optionOperation == 2)
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > CADASTRAR ALUNOS");
                                    System.Console.WriteLine("============================================================");

                                    Console.WriteLine("\r\nAlunos: \r\n");
                                    alunoObj.MostraLista(alunos);
                                    List<Aluno> listaAlunos = admin.CadastraAluno(alunos)!;
                                    alunos = listaAlunos;
                                    Console.WriteLine("Alunos: \r\n");
                                    alunoObj.MostraLista(listaAlunos);

                                }
                                else if (optionOperation == 3)
                                {
                                    System.Console.WriteLine("===============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > REMOVER REGISTRO PROFESSORES");
                                    System.Console.WriteLine("===============================================================");

                                    profObj.MostraLista(professores);

                                    Console.WriteLine("Insira qual índice do professor a ser removido: ");
                                    int indexProf = Convert.ToInt32(Console.ReadLine());

                                    profObj.DeletaPessoa(professores, indexProf);
                                    admin.DeletaRegistroArquivoProf(indexProf);
                                    profObj.MostraLista(professores);

                                }
                                else if (optionOperation == 4)
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > REMOVER REGISTRO ALUNOS");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("\r\nAlunos: \r\n");
                                    alunoObj.MostraLista(alunos);

                                    Console.WriteLine("Insira qual índice do aluno a ser removido: ");
                                    int indexAluno = Convert.ToInt32(Console.ReadLine());
                                    alunoObj.DeletaPessoa(alunos, indexAluno);
                                    admin.DeletaRegistroArquivoAluno(indexAluno);
                                    alunoObj.MostraLista(alunos);

                                }
                                else if (optionOperation == 5)
                                {
                                    System.Console.WriteLine("==================================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR PROFESSORES CADASTRADOS");
                                    System.Console.WriteLine("==================================================================");
                                    Console.WriteLine("\r\nProfessores: \r\n");
                                    profObj.MostraLista(professores);




                                }
                                else if (optionOperation == 6)
                                {
                                    System.Console.WriteLine("==============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR ALUNOS CADASTRADOS");
                                    System.Console.WriteLine("=============================================================");
                                    Console.WriteLine("\r\nAlunos: \r\n");
                                    alunoObj.MostraLista(alunos);



                                }
                            }
                        }
                        else if (optionUser == 2)
                        {
                            System.Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > ALUNO");
                            System.Console.WriteLine("============================================================");



                            int optionOperation;

                            optionOperation = 1;

                            while (optionOperation != 0)
                            {
                                menuAlunoDelegate();

                                optionOperation = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();


                                if (optionOperation == 1) //calcula a média do aluno
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > CALCULAR MÉDIA");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno:\n\r");
                                    alunoObj.MostraLista(alunos);

                                    int indexAluno = Convert.ToInt32(Console.ReadLine());

                                    if (indexAluno > 0 && indexAluno <= alunos.Count)

                                    {
                                        Console.WriteLine($"Média de {alunos[(indexAluno - 1)].Nome}: " + aluno.CalculaMedia(alunos, indexAluno));
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Insira um índice válido!");
                                        Console.ResetColor();

                                    }

                                }
                                else if (optionOperation == 2) //emite comprovante de matrícula do aluno
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > EMITIR COMPROVANTE DE MATRÍCULA");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno:\r\n");
                                    alunoObj.MostraLista(alunos);

                                    int indexAluno = Convert.ToInt32(Console.ReadLine());
                                    if (indexAluno > 0 && indexAluno <= alunos.Count)
                                    {
                                        aluno.ExibeComprovanteDeMatricula(alunos[(indexAluno - 1)]);
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Insira um índice válido!");
                                        Console.ResetColor();


                                    }


                                }
                                else if (optionOperation == 3) //exibe informações do aluno
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > EXIBIR INFORMAÇÕES DO ALUNO");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno: ");
                                    alunoObj.MostraLista(alunos);


                                    int indexAluno = Convert.ToInt32(Console.ReadLine());
                                    if (indexAluno > 0 && indexAluno <= alunos.Count)
                                    {
                                        aluno.MostraDados(alunos[(indexAluno - 1)]);
                                        Console.WriteLine("Média: "+ aluno.CalculaMedia(alunos, indexAluno));

                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Insira um índice válido!");
                                        Console.ResetColor();


                                    }

                                }
                            }

                        }
                        else if (optionUser == 3)
                        {
                            System.Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > PROFESSOR");
                            System.Console.WriteLine("============================================================");

                            Professor prof = new Professor();

                            int optionOperation;
                            optionOperation = 1;

                            while (optionOperation != 0)
                            {
                                menuProfDelegate();

                                optionOperation = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();


                                if (optionOperation == 1)
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > CADASTRAR NOTAS ALUNOS");
                                    System.Console.WriteLine("============================================================");

                                    Console.WriteLine("Lançar notas de qual aluno?\r\n");
                                    alunoObj.MostraLista(alunos);

                                    int indexAluno = Convert.ToInt32(Console.ReadLine());
                                    int numNotas = 5;
                                    if (indexAluno > 0 && indexAluno <= alunos.Count)
                                    {
                                        Console.WriteLine($"Insira as 5 notas de {alunos[(indexAluno - 1)].Nome}: ");
                                        for (int j = 0; j < numNotas; j++)
                                        {
                                            alunos[(indexAluno - 1)].Notas[j] = Convert.ToDouble(Console.ReadLine()); // ver como cadastrar notas alunos


                                        }

                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Insira um índice válido!");
                                        Console.ResetColor();

                                    }

                                    Console.WriteLine("");

                                }
                                else if (optionOperation == 2)
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > CALCULAR TAXA DE APROVAÇÃO");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("Insira o número de alunos da sua turma.");
                                    int numAlunos = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Insira o número de alunos acima da média.");
                                    int alunosAprovados = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("A taxa de aprovação foi de " + prof.CalculaTaxaAprovacao(numAlunos, alunosAprovados) + "%.");

                                }
                                else if (optionOperation == 3) //exibe informações do professor
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > EXIBIR INFORMAÇÕES DO PROFESSOR");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o professor: ");
                                    profObj.MostraLista(professores);


                                    int indexProf = Convert.ToInt32(Console.ReadLine());

                                    if (indexProf > 0 && indexProf <= professores.Count)
                                    {
                                        prof.MostraDados(professores[(indexProf - 1)]);

                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Insira um índice válido!");
                                        Console.ResetColor();


                                    }


                                }
                                else if (optionOperation == 4)
                                {
                                    prof.MostraEstatisticaTurma(alunos);
                                }
                            }
                        }
                        else if (optionUser == 4) //opcao de escolher usuario
                        {
                            System.Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO");
                            System.Console.WriteLine("============================================================");

                            int optionOperation;

                            optionOperation = 1;

                            while (optionOperation != 0)
                            {
                                menuFuncDelegate();

                                optionOperation = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();


                                if (optionOperation == 1)//cadastra itens na cantina
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > CADASTRAR ITENS CANTINA");
                                    System.Console.WriteLine("============================================================");
                                    func.MostraItensCantina(itensCantina);

                                    List<Produto> listaprodutos = func.CadastraItemCantina(itensCantina)!;
                                    itensCantina = listaprodutos;
                                    func.MostraItensCantina(listaprodutos);

                                }
                                else if (optionOperation == 2)//remove itens da cantina
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > REMOVER ITENS CANTINA");
                                    System.Console.WriteLine("============================================================");
                                    func.MostraItensCantina(itensCantina);

                                    Console.WriteLine("Insira qual índice do produto a ser deletado: ");
                                    int indexProduto = Convert.ToInt32(Console.ReadLine());

                                    func.DeletaItemCantina(itensCantina, indexProduto);
                                    func.MostraItensCantina(itensCantina);




                                }
                                else if (optionOperation == 3) // mostra os itens da cantina
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > MOSTRAR ITENS CANTINA");
                                    System.Console.WriteLine("============================================================");
                                    func.MostraItensCantina(itensCantina);

                                }
                                else if (optionOperation == 4) // calcula caixa cantina
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > CALCULAR CAIXA CANTINA");
                                    System.Console.WriteLine("============================================================");

                                    Console.WriteLine("==== Caixa Cantina Mensal: R$ " + func.CalculaCaixaCantina(itensCantina) + " ======================");
                                    Console.WriteLine("Insira quanto a Cantina tem de despesa mensal: ");
                                    double valorDespesa = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("==== Caixa Cantina com Despesas: R$ " + func.CalculaCaixaCantinaComDespesa(itensCantina, valorDespesa) + " =============="); //utilização de método de extensão para calcular desconto obedecendo o O/C principle da SOLID

                                    Console.WriteLine("");
                                }
                            }


                        }
                    }
                }
            }

        }
    }
}