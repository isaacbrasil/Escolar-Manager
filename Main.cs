namespace CSharp_ExtensionsMethods
{
    public class GerenciamentoEscolar
    {

        //---------------- ENUMS de opções -----------------------
        enum OptionMenu
        {
            log = 1,
            exit = 0,
        }

        enum OptionUser
        {
            admin = 1,
            aluno = 2,
            professor = 3,
            funcionario = 4,
            back = 0,

        }
        enum OptionAdmin
        {
            cadastraProf = 1,
            cadastraAluno = 2,
            removeProf = 3,
            removeAluno = 4,
            mostraProf = 5,
            mostraAluno = 6,
            exit = 0,
        }
        enum OptionAluno
        {
            calculaMedia = 1,
            exibeComprovante = 2,
            mostraInfo = 3,
            exit = 0,
        }
        enum OptionProf
        {
            cadastraNota = 1,
            taxaAprovacao = 2,
            mostraInfo = 3,
            mostraEstatisticaTurma = 4,
            exit = 0,
        }
        enum OptionFunc
        {
            cadastraCantina = 1,
            deletaCantina = 2,
            mostraInfo = 3,
            calculaCaixa = 4,
            exit = 0,
        }

        public delegate void MenuDelegate();
        static void Main()
        {

            //---------------- Instâncias de Generics -----------------------

            ClasseGenerica<Aluno> alunoObj = new(); //objeto genérico que imprime todos os dados do tipo 'Aluno'
            ClasseGenerica<Professor> profObj = new(); //objeto genérico que imprime todos os dados do tipo 'Professor'


            //---------------- Instâncias de Objetos-----------------------
            Aluno aluno = new();
            Sistema sistema = new();
            Administrador admin = new();
            Funcionario func = new();


            //---------------- Instâncias de Delegates -----------------------
            MenuDelegate menuDelegate = new(sistema.MenuSistema);
            MenuDelegate menuUsuarioDelegate = new(sistema.MenuUsuário);
            MenuDelegate menuOperacaoDelegate = new(sistema.MenuOperaçãoAdmin);
            MenuDelegate menuAlunoDelegate = new(sistema.MenuOperaçãoAluno);
            MenuDelegate menuProfDelegate = new(sistema.MenuOperaçãoProf);
            MenuDelegate menuFuncDelegate = new(sistema.MenuOperaçãoFunc);


            List<Aluno> alunos = new() {
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
            List<Professor> professores = new() {
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
            List<Produto> itensCantina = new() {
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

            string nomeAlimento = "coca-cola";
            string nomeAlimentoFormatted = nomeAlimento.ToUpper();
            double valorAlimento = 2.5;
            int quantidadeItens = 32;

            object itemNomeObj = nomeAlimentoFormatted; // boxing
            object itemValObj = valorAlimento; // boxing
            object itemQtdeObj = quantidadeItens; // boxing

            Produto produtoBoxUnboxing = new((string)itemNomeObj, (double)itemValObj, (int)itemQtdeObj); //unboxing
            itensCantina.Add(produtoBoxUnboxing); //adiciono o novo produto na lista da cantina

            int optionMenu = 1;

            while (optionMenu != (int)OptionMenu.exit)
            {
                Console.Clear();
                menuDelegate();
                if (int.TryParse(Console.ReadLine(), out optionMenu) && optionMenu == (int)OptionMenu.log)
                {

                    int optionUser = 1;

                    while (optionUser != (int)OptionUser.back)
                    {
                        Console.Clear();
                        Console.WriteLine("============================================================");
                        Console.WriteLine("LOGIN > USUARIOS ");
                        Console.WriteLine("============================================================");

                        menuUsuarioDelegate();

                        if (int.TryParse(Console.ReadLine(), out optionUser) && optionUser == (int)OptionUser.admin)
                        {
                            Console.Clear();

                            Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR");
                            Console.WriteLine("============================================================");

                            int optionOperation = 1;

                            while (optionOperation != (int)OptionAdmin.exit)
                            {

                                menuOperacaoDelegate();

                                if (int.TryParse(Console.ReadLine(), out optionOperation) && optionOperation == (int)OptionAdmin.cadastraProf)
                                {
                                    Console.Clear();
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > CADASTRAR PROFESSORES");
                                    Console.WriteLine("============================================================");

                                    Console.WriteLine("\r\nProfessores: \r\n");
                                    profObj.MostraLista(professores);

                                    List<Professor> listaProfessores = Administrador.CadastraProfessor(professores)!;
                                    professores = listaProfessores;
                                    Console.WriteLine("Professores: \r\n");
                                    profObj.MostraLista(listaProfessores);

                                }
                                else if (optionOperation == (int)OptionAdmin.cadastraAluno)
                                {
                                    Console.Clear();

                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > CADASTRAR ALUNOS");
                                    Console.WriteLine("============================================================");

                                    Console.WriteLine("\r\nAlunos: \r\n");
                                    alunoObj.MostraLista(alunos);
                                    List<Aluno> listaAlunos = Administrador.CadastraAluno(alunos)!;
                                    alunos = listaAlunos;
                                    Console.WriteLine("Alunos: \r\n");
                                    alunoObj.MostraLista(listaAlunos);

                                }
                                else if (optionOperation == (int)OptionAdmin.removeProf)
                                {
                                    Console.Clear();

                                    Console.WriteLine("===============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > REMOVER REGISTRO PROFESSORES");
                                    Console.WriteLine("===============================================================");

                                    profObj.MostraLista(professores);

                                    Console.WriteLine("Insira qual índice do professor a ser removido: ");

                                    if (int.TryParse(Console.ReadLine(), out int indexProf))
                                    {
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\r\nInsira um índice válido.\r\n");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        profObj.DeletaPessoa(professores, indexProf);
                                        Administrador.DeletaRegistroArquivoProf(professores, indexProf);
                                        profObj.MostraLista(professores);
                                    }

                                }
                                else if (optionOperation == (int)OptionAdmin.removeAluno)
                                {
                                    Console.Clear();

                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > REMOVER REGISTRO ALUNOS");
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("\r\nAlunos: \r\n");
                                    alunoObj.MostraLista(alunos);

                                    Console.WriteLine("Insira qual índice do aluno a ser removido: ");

                                    if (int.TryParse(Console.ReadLine(), out int indexAluno))
                                    {
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("\r\nInsira um índice válido.\r\n");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        alunoObj.DeletaPessoa(alunos, indexAluno);
                                        Administrador.DeletaRegistroArquivoAluno(alunos, indexAluno);
                                        alunoObj.MostraLista(alunos);
                                    }

                                }
                                else if (optionOperation == (int)OptionAdmin.mostraProf)
                                {
                                    Console.Clear();

                                    Console.WriteLine("==================================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR PROFESSORES CADASTRADOS");
                                    Console.WriteLine("==================================================================");
                                    Console.WriteLine("\r\nProfessores: \r\n");
                                    profObj.MostraLista(professores);

                                }
                                else if (optionOperation == (int)OptionAdmin.mostraAluno)
                                {
                                    Console.Clear();

                                    Console.WriteLine("==============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > MOSTRAR ALUNOS CADASTRADOS");
                                    Console.WriteLine("=============================================================");
                                    Console.WriteLine("\r\nAlunos: \r\n");
                                    alunoObj.MostraLista(alunos);

                                }
                            }
                        }
                        else if (optionUser == (int)OptionUser.aluno)
                        {
                            Console.Clear();

                            Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > ALUNO");
                            Console.WriteLine("============================================================");


                            int optionOperation = 1;

                            while (optionOperation != (int)OptionAluno.exit)
                            {

                                menuAlunoDelegate();

                                if (int.TryParse(Console.ReadLine(), out optionOperation) && optionOperation == (int)OptionAluno.calculaMedia) //calcula a média do aluno
                                {
                                    Console.Clear();

                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > CALCULAR MÉDIA");
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno:\n\r");
                                    alunoObj.MostraLista(alunos);


                                    if (int.TryParse(Console.ReadLine(), out int indexAluno) && indexAluno > 0 && indexAluno <= alunos.Count)

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
                                else if (optionOperation == (int)OptionAluno.exibeComprovante) //emite comprovante de matrícula do aluno
                                {
                                    Console.Clear();
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > EMITIR COMPROVANTE DE MATRÍCULA");
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno:\r\n");
                                    alunoObj.MostraLista(alunos);

                                    if (int.TryParse(Console.ReadLine(), out int indexAluno) && indexAluno > 0 && indexAluno <= alunos.Count)
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
                                else if (optionOperation == (int)OptionAluno.mostraInfo)
                                {
                                    Console.Clear();
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > ALUNO > EXIBIR INFORMAÇÕES DO ALUNO");
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o aluno: ");
                                    alunoObj.MostraLista(alunos);


                                    if (int.TryParse(Console.ReadLine(), out int indexAluno) && indexAluno > 0 && indexAluno <= alunos.Count)
                                    {
                                        aluno.MostraDados(alunos[(indexAluno - 1)]);
                                        Console.WriteLine("Média: " + aluno.CalculaMedia(alunos, indexAluno));

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
                        else if (optionUser == (int)OptionUser.professor)
                        {
                            Console.Clear();

                            Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > PROFESSOR");
                            Console.WriteLine("============================================================");

                            Professor prof = new();

                            int optionOperation;
                            optionOperation = 1;


                            while (optionOperation != (int)OptionProf.exit)
                            {

                                menuProfDelegate();

                                if (int.TryParse(Console.ReadLine(), out optionOperation) && optionOperation == (int)OptionProf.cadastraNota)
                                {

                                    Console.Clear();
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > CADASTRAR NOTAS ALUNOS");
                                    Console.WriteLine("============================================================");

                                    Console.WriteLine("Lançar notas de qual aluno?\r\n");
                                    alunoObj.MostraLista(alunos);

                                    int numNotas = 5;
                                    if (int.TryParse(Console.ReadLine(), out int indexAluno) && indexAluno > 0 && indexAluno <= alunos.Count)
                                    {
                                        Console.WriteLine($"Insira as 5 notas de {alunos[(indexAluno - 1)].Nome}: ");

                                        for (int j = 0; j < numNotas; j++)
                                        {
                                            if (double.TryParse(Console.ReadLine(), out double notaAluno))
                                            {
                                                alunos[(indexAluno - 1)].Notas[j] = notaAluno;
                                            }
                                            else
                                            {
                                                Console.BackgroundColor = ConsoleColor.Yellow;
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("Insira apenas valores numéricos.");
                                                Console.ResetColor();
                                                break;
                                            }

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
                                else if (optionOperation == (int)OptionProf.taxaAprovacao)
                                {
                                    Console.Clear();
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > CALCULAR TAXA DE APROVAÇÃO");
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("Insira o número de alunos da sua turma.");
                                    if (int.TryParse(Console.ReadLine(), out int numAlunos) && numAlunos > 0)
                                    {
                                        Console.WriteLine("Insira o número de alunos acima da média.");
                                        if (int.TryParse(Console.ReadLine(), out int alunosAprovados) && alunosAprovados > 0)
                                        {

                                            Console.WriteLine("A taxa de aprovação foi de " + Professor.CalculaTaxaAprovacao(numAlunos, alunosAprovados) + "%.");

                                        }
                                        else
                                        {
                                            Console.BackgroundColor = ConsoleColor.Yellow;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("Insira apenas valores numéricos.");
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Insira apenas valores numéricos.");
                                        Console.ResetColor();

                                    }
                                }
                                else if (optionOperation == (int)OptionProf.mostraInfo) //exibe informações do professor
                                {
                                    Console.Clear();
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > EXIBIR INFORMAÇÕES DO PROFESSOR");
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("Selecione o professor: ");
                                    profObj.MostraLista(professores);



                                    if (int.TryParse(Console.ReadLine(), out int indexProf) && indexProf > 0 && indexProf <= professores.Count)
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
                                else if (optionOperation == (int)OptionProf.mostraEstatisticaTurma)
                                {
                                    Console.Clear();
                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > ESTATÍSTICAS DA TURMA: ");
                                    Console.WriteLine("============================================================");
                                    Professor.MostraEstatisticaTurma(alunos);
                                }
                            }
                        }
                        else if (optionUser == (int)OptionUser.funcionario)
                        {
                            Console.Clear();

                            Console.WriteLine("============================================================");
                            Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO");
                            Console.WriteLine("============================================================");

                            int optionOperation;

                            optionOperation = 1;

                            while (optionOperation != (int)OptionFunc.exit)
                            {

                                menuFuncDelegate();

                                if (int.TryParse(Console.ReadLine(), out optionOperation) && optionOperation == (int)OptionFunc.cadastraCantina)//cadastra itens na cantina
                                {
                                    Console.Clear();

                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > CADASTRAR ITENS CANTINA");
                                    Console.WriteLine("============================================================");
                                    Funcionario.MostraItensCantina(itensCantina);

                                    List<Produto> listaprodutos = Funcionario.CadastraItemCantina(itensCantina)!;
                                    itensCantina = listaprodutos;
                                    Funcionario.MostraItensCantina(listaprodutos);

                                }
                                else if (optionOperation == (int)OptionFunc.deletaCantina)//remove itens da cantina
                                {
                                    Console.Clear();

                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > REMOVER ITENS CANTINA");
                                    Console.WriteLine("============================================================");
                                    Funcionario.MostraItensCantina(itensCantina);
                                    Funcionario.DeletaItemCantina(itensCantina);
                                    Funcionario.MostraItensCantina(itensCantina);




                                }
                                else if (optionOperation == (int)OptionFunc.mostraInfo) // mostra os itens da cantina
                                {
                                    Console.Clear();

                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > MOSTRAR ITENS CANTINA");
                                    Console.WriteLine("============================================================");
                                    Funcionario.MostraItensCantina(itensCantina);

                                }
                                else if (optionOperation == (int)OptionFunc.calculaCaixa) // calcula caixa cantina
                                {
                                    Console.Clear();

                                    Console.WriteLine("============================================================");
                                    Console.WriteLine("LOGIN > USUARIOS > FUNCIONÁRIO > CALCULAR CAIXA CANTINA");
                                    Console.WriteLine("============================================================");

                                    Console.WriteLine("==== Caixa Cantina Mensal: R$ " + Funcionario.CalculaCaixaCantina(itensCantina) + " =====================================\n\r");
                                    Console.WriteLine("Insira quanto a Cantina tem de despesa mensal: ");

                                    if (double.TryParse(Console.ReadLine(), out double valorDespesa))
                                    {

                                        Console.WriteLine("\n\r==== Caixa Cantina Mensal com Despesas aplicadas: R$ " + func.CalculaCaixaCantinaComDespesa(itensCantina, valorDespesa) + " =============="); //utilização de método de extensão para calcular desconto obedecendo o O/C principle da SOLID

                                    }
                                    else
                                    {


                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("Insira apenas valores numéricos.");
                                        Console.ResetColor();

                                    }

                                    Console.WriteLine("");
                                }
                            }
                        }
                    }
                }
            }
            Console.Clear();
        }
    }
}