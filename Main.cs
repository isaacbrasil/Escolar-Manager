class GerenciamentoEscolar
{
    static void Main(string[] args)
    {

        int optionMenu = 1;
        List<Aluno> alunos = new List<Aluno>() {
                            new Aluno()
                            {
                                Nome = "Isaac",
                                Notas = new double[] { 0, 2, 3, 4, 5 }, //2,8
                                Turma = 'A',
                                EscolaNome = "Colégio Visão"
                            },
                             new Aluno()
                            {
                                Nome = "Gabriel",
                                Notas = new double[] { 1, 10, 7, 6, 6 },//6
                                Turma = 'B',
                                EscolaNome = "Colégio Delta"
                             },
                              new Aluno()
                            {
                                Nome = "Lucas",
                                Notas = new double[] { 10, 7, 8, 6, 6 },//7,4
                                Turma = 'C',
                                EscolaNome = "Colégio WR"
                            }
        };
        List<Professor> professores = new List<Professor>() {
                            new Professor()
                            {
                                Nome = "Lutiano",
                            },
                             new Professor()
                            {
                                Nome = "Éder",
                             },
                              new Professor()
                            {
                                Nome = "Christopher",
                            }
        };
        List<Produto> itensCantina = new List<Produto>() {
                            new Produto()
                            {
                                NomeAlimento = "Ruffles",
                                ValorAlimento = 5.9

                            },
                             new Produto()
                            {
                                NomeAlimento = "Oreo",
                                ValorAlimento = 3.9

                            }
        };
        while (optionMenu != 0)
        {
            Sistema sistema = new Sistema();
            sistema.MenuSistema();
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

                        Administrador admin = new Administrador();

                        int optionOperation = 1;


                        while (optionOperation != 0)//loop do login do usuario
                        {
                            sistema.MenuOperaçãoAdmin();


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
                                professores.RemoveAt((indexProf - 1));
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
                                alunos.RemoveAt((indexAluno - 1));
                                admin.MostraAlunos(alunos);

                            }
                            else if (optionOperation == 5)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR PROFESSORES CADASTRADOS");
                                System.Console.WriteLine("============================================================");
                                admin.MostraProfessores(professores);

                            }
                            else if (optionOperation == 6)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR ALUNOS CADASTRADOS");
                                System.Console.WriteLine("============================================================");
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

                        Aluno aluno = new Aluno();


                        int optionOperation;

                        optionOperation = 1;

                        while (optionOperation != 0)
                        {
                            sistema.MenuOperaçãoAluno();
                            optionOperation = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();


                            if (optionOperation == 1) //calcula a média do aluno
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ALUNO > CALCULAR MÉDIA");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Selecione o aluno: ");
                                aluno.MostraAlunos(alunos);
                                int indexAluno = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"Média de {alunos[(indexAluno - 1)].Nome}: " + aluno.CalculaMedia(alunos, indexAluno)); //CLEAN CODE: Reutilizar código já escrito: isso inclui o uso de bibliotecas, ou códigos escritos por mim ou terceiros


                            }
                            else if (optionOperation == 2) //emite comprovante de matrícula do aluno
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ALUNO > EMITIR COMPROVANTE DE MATRÍCULA");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Selecione o aluno: ");
                                aluno.MostraAlunos(alunos);
                                int indexAluno = Convert.ToInt32(Console.ReadLine());
                                aluno.ExibeComprovanteDeMatricula(alunos[(indexAluno - 1)]);


                            }
                            else if (optionOperation == 3) //exibe informações do aluno
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ALUNO > EXIBIR INFORMAÇÕES DO ALUNO");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Selecione o aluno: ");
                                aluno.MostraAlunos(alunos);
                                int indexAluno = Convert.ToInt32(Console.ReadLine());
                                aluno.MostraDadosAluno(alunos[(indexAluno - 1)]);


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
                        Administrador admin = new Administrador();

                        int optionOperation;
                        optionOperation = 1;

                        while (optionOperation != 0)
                        {
                            sistema.MenuOperaçãoProf();
                            optionOperation = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();


                            if (optionOperation == 1)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > CADASTRAR NOTAS ALUNOS");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);

                                Console.WriteLine("Lançar notas de qual aluno?");
                                admin.MostraAlunos(alunos);
                                int indexAluno = Convert.ToInt32(Console.ReadLine());


                                Console.WriteLine($"Insira as 5 notas de {alunos[(indexAluno - 1)].Nome}: ");
                                for (int j = 0; j < 5; j++)
                                {
                                    alunos[(indexAluno - 1)].Notas[j] = Convert.ToDouble(Console.ReadLine()); // ver como cadastrar notas alunos
                                }




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
                            else if (optionOperation == 3)
                            {
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);

                            }
                        }
                    }
                    else if (optionUser == 4) //opcao de escolher usuario
                    {
                        p.TipoUsuario = "Funcionario";
                        System.Console.WriteLine("============================================================");
                        Console.WriteLine("LOGIN > USUARIOS > FUNCIONARIO");
                        System.Console.WriteLine("============================================================");

                        Funcionario func = new Funcionario();

                        int optionOperation;


                        optionOperation = 1;

                        while (optionOperation != 0)
                        {
                            sistema.MenuOperaçãoFunc();
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
                                itensCantina.RemoveAt((indexProduto - 1));
                                func.MostraItensCantina(itensCantina);


                            }
                            else if (optionOperation == 3)
                            {
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);
                            }
                        }


                    }
                }
            }
        }

    }
}