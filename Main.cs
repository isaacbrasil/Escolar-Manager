class GerenciamentoEscolar
{
    static void Main(string[] args)
    {

        int optionMenu = 1;

        while (optionMenu != 0)
        {
            Pessoa p1 = new Pessoa();
            p1.MenuSistema();

            optionMenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();



            if (optionMenu == 1) //opcao de login do sistema
            {
                Pessoa p = new Pessoa();
                int optionUser = 1;

                while (optionUser != 0)//loop do login do sistema
                {
                    System.Console.WriteLine("============================================================");
                    Console.WriteLine("LOGIN > USUARIOS ");
                    System.Console.WriteLine("============================================================");
                    p.MenuUsuário();

                    optionUser = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (optionUser == 1) //opcao de escolher usuario
                    {
                        p.TipoUsuario = "Admin";
                        System.Console.WriteLine("============================================================");
                        Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR");
                        System.Console.WriteLine("============================================================");

                        Administrador admin = new Administrador();

                        int optionOperation = 1;

                        
                        while (optionOperation != 0)//loop do login do usuario
                        {
                            admin.MenuOperação();

                            optionOperation = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            if (optionOperation == 1)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > CADASTRAR PROFESSORES");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);
                                admin.CadastraProfessor();


                            }
                            else if (optionOperation == 2)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > CADASTRAR ALUNOS");
                                System.Console.WriteLine("============================================================");
                                admin.CadastraAluno();

                            }
                            else if (optionOperation == 3)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ADMINISTRADOR > OPÇÃO 3");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);

                            }
                        }
                    }
                    else if (optionUser == 2) //opcao de escolher usuario
                    {
                        p.TipoUsuario = "Aluno";
                        System.Console.WriteLine("============================================================");
                        Console.WriteLine("LOGIN > USUARIOS > ALUNO");
                        System.Console.WriteLine("============================================================");

                        Aluno aluno = new Aluno();
                        Aluno a = new Aluno("Isaac", new int[] { 0, 2, 3, 4, 5 }, 'A', "Colégio Visão");

                        int optionOperation;

                        optionOperation = 1;

                        while (optionOperation != 0)
                        {
                            aluno.MenuOperação();
                            optionOperation = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();


                            if (optionOperation == 1)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ALUNO > OPÇÃO 1");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);

                            }
                            else if (optionOperation == 2)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > ALUNO > OPÇÃO 2");
                                System.Console.WriteLine("============================================================");
                                aluno.ExibeComprovanteDeMatricula(a);


                            }
                        }

                    }
                    else if (optionUser == 3) //opcao de escolher usuario
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
                            prof.MenuOperação();
                            optionOperation = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();


                            if (optionOperation == 1)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > OPÇÃO 1");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);

                            }
                            else if (optionOperation == 2)
                            {
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("LOGIN > USUARIOS > PROFESSOR > OPÇÃO 2");
                                System.Console.WriteLine("============================================================");
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);

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
                            func.MenuOperação();
                            optionOperation = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();


                            if (optionOperation == 1)
                            {
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);
                            }
                            else if (optionOperation == 2)
                            {
                                Console.WriteLine("Opção " + optionOperation + " do usuário " + p.TipoUsuario);
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