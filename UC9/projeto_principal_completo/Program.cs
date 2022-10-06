using BE7_FS4_UC9.Classes;

using BE7_FS4_UC9.Classes;

Console.Clear();

Console.WriteLine(@$"
===============================================================================
|                  Bem vindo ao sistema de cadastro de                        | 
|                      Pessoas Fisicas e Juridicas                            |
===============================================================================
");

BarraCarregamento("carregando", 100);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir                          | 
|_____________________________________________________________________________|
|                                                                             |
|                           1 - Pessoa Fisica                                 |
|                           2 - Pessoa Juridica                               |
|                                                                             |
|                           0 - Sair                                          |
===============================================================================
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //menu da pessoa fisica
            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir                          | 
|_____________________________________________________________________________|
|                                                                             |
|                        1 - Cadastrar Pessoa Fisica                          |
|                        2 - Mostrar Pessoa Fisica                            |
|                                                                             |
|                        0 - Retornar ao menu anterior                        |
===============================================================================
");
                opcaoPf = Console.ReadLine();

                PessoaFisica metodoPf = new PessoaFisica();
                PessoaFisica novaPf = new PessoaFisica();
                Endereco novoEndPf = new Endereco();

                switch (opcaoPf)
                {
                    case "1":
                        //case de cadastrar pessoa fisica
                        Console.Clear();

                        Console.WriteLine($"Digite o nome da pessoa Fisica que deseja cadastrar");
                        novaPf.name = Console.ReadLine();

                        Console.WriteLine($"Digite o Cpf");
                        novaPf.cpf = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex.: DD/MM/AAAA");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                            if (dataValida)
                            {
                                novaPf.dataNascimento = dataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digita é inválida, por favor digite uma dara válida");
                                Console.ResetColor();
                            }

                        } while (dataValida == false);

                        Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");                       
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite logradouro");                        
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");                        
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte Enter para vazio");                      
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                             novoEndPf.endComercial = true;
                        }
                        else
                        {
                             novoEndPf.endComercial = false;
                        } 
                        novaPf.endereco = novoEndPf;
                        metodoPf.Inserir(novaPf);                  
                        break;
                    case "2":
                        //case de mostar pessoa fisica
                        List<PessoaFisica> listaPf = metodoPf.Ler();

                        foreach(PessoaFisica cadaItem in listaPf)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                                Nome: {cadaItem.name}
                                CNPJ: {cadaItem.cpf} 
                                Razao Social: {cadaItem.dataNascimento}
                                Rendimento: {cadaItem.rendimento}
                                Imposto: {metodoPf.PagarImposto(cadaItem.rendimento).ToString("c")}
                                Logradouro: {cadaItem.endereco.logradouro}
                                Número: {cadaItem.endereco.numero} 
                                Complemento: {cadaItem.endereco.complemento}
                                Endereço Comercial?:{((cadaItem.endereco.endComercial)?"Sim":"Não")}                  
                            ");

                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();                    
                        }                                        
                        break;
                    case "0":
                        //essa opção retorna par o menu anterior, não vamos inserir nada aqui.
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPf != "0");


            break;
        case "2":
            //menu da pessoa juridica
            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir                          | 
|_____________________________________________________________________________|
|                                                                             |
|                       1 - Cadastrar Pessoa Juridica                         |
|                       2 - Mostrar Pessoa Juridica                           |
|                                                                             |
|                       0 - Retornar ao menu anterior                         |
========/=======================================================================
");
                opcaoPj = Console.ReadLine();

                PessoaJuridica metodoPj = new PessoaJuridica();
                PessoaJuridica novaPj = new PessoaJuridica();
                Endereco novoEndPj = new Endereco();

                switch (opcaoPj)
                {
                    case "1":
                    //casede cadastrar possoa juridica
                        Console.Clear();

                        Console.WriteLine($"Digite o nome da pessoa Juridica que deseja cadastrar");
                        novaPj.name = Console.ReadLine();

                        bool cnpjvalido;
                        do
                        {
                            Console.WriteLine($"Digite o CNPJ Ex.: 00.000.000/0001.00 ou 00000000000000");
                            string cnpj = Console.ReadLine();

                            cnpjvalido = metodoPj.ValidarCnpj(cnpj);
                            if (cnpjvalido)
                            {
                                metodoPj.cnpj = cnpj; 
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Cnpj inválido, por favor digite un cnpj valido.");
                                Console.ResetColor();
                                
                            }                         
                        } while (cnpjvalido == false);

                        Console.WriteLine($"Digite a razao social");
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal(digite apenas números)");                       
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite logradouro");                        
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");                        
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte Enter para vazio");                      
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                             novoEndPj.endComercial = true;
                        }
                        else
                        {
                             novoEndPj.endComercial = false;
                        } 
                        novaPj.endereco = novoEndPj;
                        metodoPj.Inserir(novaPj);                               
                        break;
                    case "2":
                        //case de mostrar pessoa juridica
                        List<PessoaJuridica> listaPj = metodoPj.Ler();

                        foreach(PessoaJuridica cadaItem in listaPj)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                                Nome: {cadaItem.name}
                                CNPJ: {cadaItem.cnpj} 
                                Razao Social: {cadaItem.razaoSocial}
                                Rendimento: {cadaItem.rendimento}
                                Imposto: {metodoPj.PagarImposto(cadaItem.rendimento).ToString("c")}
                                Logradouro: {cadaItem.endereco.logradouro}
                                Número: {cadaItem.endereco.numero} 
                                Complemento: {cadaItem.endereco.complemento}
                                Endereço Comercial?:{((cadaItem.endereco.endComercial)?"Sim":"Não")}                  
                            ");

                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();                    
                        }                        
                        break;
                    case "0":
                        //essa opção retorna par o menu anterior, não vamos inserir nada aqui.
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPj != "0");
            break;
        case "0":
            BarraCarregamento("Finalizando", 100);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção.");
            Thread.Sleep(2000);
            break;
    }

} while (opcao != "0");



static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write($"{texto}");

    for (var contador = 0; contador < 34; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}