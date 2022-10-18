namespace CSharp_ExtensionsMethods
{
    class GerenciamentoEscolar
    {

        public delegate void MenuDelegate();
        static void Main(string[] args)
        {
            //CLASSE GENERICA
            ClasseGenerica<Aluno> intObj = new ClasseGenerica<Aluno>();
            /* intObj.Add(
                new Aluno()
                {
                    Nome = "Isaac Brasil Oliveira 2",
                    Notas = new double[] { 10, 10, 7, 8, 6 },
                    Turma = 'A',
                    EscolaNome = "Colégio Visão"
                });*/


            int optionMenu = 1;

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

            OrganizadorGenerico<Aluno> listAlunoOrdenada = new OrganizadorGenerico<Aluno>();
            OrganizadorGenerico<Professor> listProfOrdenada = new OrganizadorGenerico<Professor>();
            OrganizadorGenerico<Produto> listCantinaOrdenada = new OrganizadorGenerico<Produto>();


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
                    Pessoa p = new Pessoa();
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
                            p.TipoUsuario = "Admin";
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
                                    admin.MostraProfessores(professores);

                                    List<Professor> listaProfessores = admin.CadastraProfessor(professores)!;
                                    professores = listaProfessores;
                                    admin.MostraProfessores(listaProfessores);




                                }
                                else if (optionOperation == 2)
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > CADASTRAR ALUNOS");
                                    System.Console.WriteLine("============================================================");
                                    admin.MostraAlunos(alunos);

                                    List<Aluno> listaAlunos = admin.CadastraAluno(alunos)!;
                                    alunos = listaAlunos;
                                    admin.MostraAlunos(listaAlunos);




                                }
                                else if (optionOperation == 3)
                                {
                                    System.Console.WriteLine("===============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > DELETAR REGISTRO PROFESSORES");
                                    System.Console.WriteLine("===============================================================");
                                    admin.MostraProfessores(professores);
                                    Console.WriteLine("Insira qual índice do professor a ser deletado: ");
                                    int indexProf = Convert.ToInt32(Console.ReadLine());
                                    admin.DeletaProfessores(professores, indexProf);
                                    admin.MostraProfessores(professores);


                                }
                                else if (optionOperation == 4)
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > DELETAR REGISTRO ALUNOS");
                                    System.Console.WriteLine("============================================================");
                                    admin.MostraAlunos(alunos);

                                    Console.WriteLine("Insira qual índice do aluno a ser deletado: ");
                                    int indexAluno = Convert.ToInt32(Console.ReadLine());
                                    admin.DeletaAlunos(alunos, indexAluno);
                                    admin.MostraAlunos(alunos);



                                }
                                else if (optionOperation == 5)
                                {
                                    System.Console.WriteLine("==================================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR PROFESSORES CADASTRADOS");
                                    System.Console.WriteLine("==================================================================");
                                    admin.MostraProfessores(professores);



                                }
                                else if (optionOperation == 6)
                                {
                                    System.Console.WriteLine("==============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR ALUNOS CADASTRADOS");
                                    System.Console.WriteLine("=============================================================");
                                    admin.MostraAlunos(alunos);



                                }
                            }
                        }
                        else if (optionUser == 2)
                        {
                            p.TipoUsuario = "Aluno";
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
                                    Console.WriteLine("Selecione o aluno: ");
                                    admin.MostraAlunos(alunos);

                                    int indexAluno = Convert.ToInt32(Console.ReadLine());

                                    if (indexAluno > 0 && indexAluno <= alunos.Count)

                                    {
                                        Console.WriteLine($"Média de {alunos[(indexAluno - 1)].Nome}: " + aluno.CalculaMedia(alunos, indexAluno));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira um índice válido.");


                                    }

                                }
                                else if (optionOperation == 2) //emite comprovante de matrícula do aluno
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > EMITIR COMPROVANTE DE MATRÍCULA");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno: ");
                                    admin.MostraAlunos(alunos);

                                    int indexAluno = Convert.ToInt32(Console.ReadLine());
                                    if (indexAluno > 0 && indexAluno <= alunos.Count)
                                    {
                                        aluno.ExibeComprovanteDeMatricula(alunos[(indexAluno - 1)]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira um índice válido.");


                                    }


                                }
                                else if (optionOperation == 3) //exibe informações do aluno
                                {
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > EXIBIR INFORMAÇÕES DO ALUNO");
                                    System.Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno: ");
                                    admin.MostraAlunos(alunos);

                                    int indexAluno = Convert.ToInt32(Console.ReadLine());
                                    if (indexAluno > 0 && indexAluno <= alunos.Count)
                                    {
                                        aluno.MostraDadosAluno(alunos[(indexAluno - 1)]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira um índice válido.");


                                    }


                                }
                            }

                        }
                        else if (optionUser == 3)
                        {
                            p.TipoUsuario = "Professor";
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

                                    Console.WriteLine("Lançar notas de qual aluno?");
                                    admin.MostraAlunos(alunos);

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
                                        Console.WriteLine("Insira um índice válido.");


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
                                    admin.MostraProfessores(professores);

                                    int indexProf = Convert.ToInt32(Console.ReadLine());

                                    if (indexProf > 0 && indexProf <= professores.Count)
                                    {
                                        prof.MostraDadosProfessor(professores[(indexProf - 1)]);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira um índice válido.");


                                    }


                                }
                                else if (optionOperation == 4) //exibe informações do professor
                                {
                                    System.Console.WriteLine("==============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > TESTAR DOWNCASTING DE PROFESSOR");
                                    System.Console.WriteLine("==============================================================");


                                    Pessoa p2 = new Pessoa();
                                    Professor newProf = p2 as Professor; // UTILIZANDO DOWNCASTING Pessoa para Professor

                                    Console.WriteLine("Código para teste do Downcasting\r\n");
                                    Console.WriteLine("Professor prof2 = new Professor();\r\nPessoa p3 = prof2;\r\n\r\nif(p3 is Professor){\r\n((Professor)p3).MostraDadosProfessor(professores[0]);\r\n}\r\nelse{\r\nConsole.WriteLine('Operação de downcast inválida');\r\n}");
                                    Console.WriteLine("");
                                    Professor prof2 = new Professor();
                                    Pessoa p3 = prof2;

                                    if (p3 is Professor)
                                    {
                                        ((Professor)p3).MostraDadosProfessor(professores[0]);
                                        Console.WriteLine("\r\nDowncasting realizado com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Operação de downcast inválida");
                                    }
                                    Console.WriteLine("");
                                }
                            }
                        }
                        else if (optionUser == 4) //opcao de escolher usuario
                        {
                            p.TipoUsuario = "Funcionario";
                            System.Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > FUNCIONARIO");
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

                                    func.MostraItensCantina(itensCantina);

                                    List<Produto> listaprodutos = func.CadastraItemCantina(itensCantina)!;
                                    itensCantina = listaprodutos;
                                    func.MostraItensCantina(listaprodutos);

                                }
                                else if (optionOperation == 2)//remove itens da cantina
                                {

                                    func.MostraItensCantina(itensCantina);



                                    Console.WriteLine("Insira qual índice do produto a ser deletado: ");
                                    int indexProduto = Convert.ToInt32(Console.ReadLine());


                                    func.DeletaItemCantina(itensCantina, indexProduto);
                                    func.MostraItensCantina(itensCantina);




                                }
                                else if (optionOperation == 3) // mostra os itens da cantina
                                {
                                    func.MostraItensCantina(itensCantina);

                                }
                                else if (optionOperation == 4) // calcula despesas cantina
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("===== Caixa Cantina: R$ "+ func.CalculaCaixaCantina(itensCantina) + " =====");
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