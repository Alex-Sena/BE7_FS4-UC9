// See https://aka.ms/new-console-template for more information

using BE7_FS4_UC9.Classes;

Console.WriteLine(@$"
===============================================================================
|                  Bem vindo ao sistema de cadastro de                        | 
|                      Pessoas Fisicas e Juridicas                            |
===============================================================================
");
/* codigo comentado devido a ter sido criado um método estatico para evitar a repetição do codigo.
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.Write($"Carregando ");

for (var contador = 0; contador < 34; contador++)
{
    Console.Write(". ");
    Thread.Sleep(100);
}
Console.ResetColor();
*/
BarraCarregamento("carregando", 100);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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
            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir                          | 
|_____________________________________________________________________________|
|                                                                             |
|                           1 - Cadastrar Pessoa Fisica                       |
|                           2 - Mostrar Pessoa Fisica                         |
|                                                                             |
|                           0 - Sair                                          |
===============================================================================
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":     
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica que deseja cadastrar");
                        novaPf.name = Console.ReadLine();  

                        /*

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
                        */
                            Console.WriteLine($"Digeite o numero do CPF");                       
                            novaPf.cpf = Console.ReadLine();
                        /*
                            Console.WriteLine($"Digite o rendimento mensal(digite apena numero)");                       
                            novaPf.rendimento = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite logradouro");                        
                            novoEnd.logradouro = Console.ReadLine();

                            Console.WriteLine($"Digite o número");                        
                            novoEnd.numero = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite o complemento (aperte Enter para vazio");                      
                            novoEnd.complemento = Console.ReadLine();

                            Console.WriteLine($"Este endereço é comercial? S ou N");
                            string endCom = Console.ReadLine().ToUpper();

                            // endCom == "S" && endCom "s"    poderia utulizar par maiusculo ou minusculo 
                            if (endCom == "S")
                            {
                                novoEnd.endComercial = true;
                            }
                            else
                            {
                                novoEnd.endComercial = false;
                            }                                              
                            novaPf.endereco = novoEnd;

                            //listaPf.Add(novaPf);

                        */

                            using (StreamWriter sw = new StreamWriter($"{novaPf.name}.txt"))
                            {
                                sw.WriteLine($"{novaPf.name}"); 
                                sw.WriteLine($"{novaPf.cpf}");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                            Console.ResetColor();
                            Thread.Sleep(2000);                                            
                        break;
                    case "2":
                        Console.Clear();

                        /*
                        if (listaPf.Count > 0){
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                    Nome: {cadaPessoa.name}
                                    Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                    Data da Nascimento: {cadaPessoa.dataNascimento}
                                    Taxa de Imposto a se paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");
                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine(); 
                            }                           
                        }
                        else{
                            Console.WriteLine($"Lista vazia!!!");
                            Thread.Sleep(3000);
                        }
                        */

                        using (StreamReader sr = new StreamReader($"Luiz.txt"))
                            {
                                string linha;
                                while ((linha = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine($"{linha}");                                   
                                }
                            }
                        Console.WriteLine($"Aperte 'Enter' para continuar...");
                        Console.ReadLine();

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opção");
                        Thread.Sleep(200);
                        break;
                }

            } while (opcaoPf != "0");
    
            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir                          | 
|_____________________________________________________________________________|
|                                                                             |
|                           1 - Cadastrar Pessoa Juridica                     |
|                           2 - Mostrar Pessoa Juridica                       |
|                                                                             |
|                           0 - Sair                                          |
===============================================================================
");
                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":     
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa Juridica que deseja cadastrar");
                        novaPj.name = Console.ReadLine();

                        /*
                        bool cnpjValido;

                        do
                        {
                            Console.WriteLine($"Digite Cnpj Ex.: 00.000.000/0001-00 ou 00000000000000");
                            string Cnpj = Console.ReadLine();

                            cnpjValido = metodoPj.ValidarCnpj(Cnpj);

                            if (cnpjValido)
                            {
                                novaPj.cnpj = Cnpj;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digita é inválida, por favor digite uma dara válida");
                                Console.ResetColor();
                            }

                        } while (cnpjValido == false);
                        */
                       
                        Console.WriteLine($"Digeite o numero do Razao Social");                       
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o numero do Cnpj");
                        novaPj.cnpj = Console.ReadLine();

                        /*
                        Console.WriteLine($"Digite o rendimento mensal(digite apena numero)");                       
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite logradouro");                        
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");                        
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte Enter para vazio");                      
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        // endCom == "S" && endCom "s"    poderia utulizar par maiusculo ou minusculo 
                        if (endCom == "S")
                        {
                             novoEndPj.endComercial = true;
                        }
                        else
                        {
                             novoEndPj.endComercial = false;
                        }                                              
                        novaPj.endereco = novoEndPj;
                        listaPj.Add(novaPj);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Console.ResetColor();
                        Thread.Sleep(2000);  
                        */
                        using (StreamWriter sw = new StreamWriter($"{novaPj.name}.txt"))
                            {
                                sw.WriteLine($"{novaPj.name}"); 
                                sw.WriteLine($"{novaPj.cnpj}");
                                sw.WriteLine($"{novaPj.razaoSocial}");
                            }

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                            Console.ResetColor();
                            Thread.Sleep(2000);

                        break;
                    case "2":
                        Console.Clear();

                        /*
                        if (listaPj.Count > 0){
                            foreach (PessoaJuridica cadaPessoa in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                    Nome: {cadaPessoa.name}
                                    Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                    Cnpj: {cadaPessoa.ValidarCnpj}
                                    Taxa de Imposto a se paga é: {metodoPj.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");
                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine(); 
                            }                           
                        }
                        else{
                            Console.WriteLine($"Lista vazia!!!");
                            Thread.Sleep(3000);
                        }
                        */
                        using (StreamReader sr = new StreamReader($"Luiz.txt"))
                            {
                                string linha;
                                while ((linha = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine($"{linha}");                                   
                                }
                            }
                        Console.WriteLine($"Aperte 'Enter' para continuar...");
                        Console.ReadLine();

                        metodoPj.Inserir(novaPj); 

                        List<PessoaJuridica> ListaPj = metodoPj.Ler();

                        foreach(PessoaJuridica cadaItem in listaPj)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                            Nome: {novaPj.name}
                            Razao Social: {novaPj.razaoSocial}
                            CNPJ: {novaPj.cnpj}               
                            ");

                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();                    
                        }

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opção");
                        Thread.Sleep(200);
                        break;
                }

            } while (opcaoPj != "0");
           /*  Console.Clear();
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();
            novaPj.name = "NomePj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "Razao Social Pj";
            novaPj.rendimento = 8000.5f;
            novoEndPj.logradouro = "Alameda Barao de Limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "Senai Informatica";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;
            Console.WriteLine(@$"
                Nome: {novaPj.name}
                Razao Social: {novaPj.razaoSocial}
                Cnpj: {novaPj.cnpj}
                CNPJ é valido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "sim" : "não")}
                Taxa de Imposto a se paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
                ");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine(); 
            */
            
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");

            /* codigo comentado devido a ter sido criado um método estatico para evitar a repetição do codigo.
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Finalizando");

            for (var contador = 0; contador < 15; contador++)
            {
                Console.Write(". ");
                Thread.Sleep(100);
            }
            Console.ResetColor();
            */
            BarraCarregamento("Finalizando", 200);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write($"{texto}");

    for (var contador = 0; contador < 20; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}



/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

PessoaFisica metodoPf = new PessoaFisica();

novaPf.name = "Luiz";
novaPf.dataNascimento = "18/02/1983";
novaPf.cpf = "12345678900";
novaPf.rendimento = 600.0f;

novoEnd.logradouro = "Alameda Barao de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai Informatica";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPf.name}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");



novaPf.name = "Lozano";
Console.WriteLine(novaPf.name);
Console.WriteLine("Nome: "+ novaPf.name);
Console.WriteLine($"Nome: (novaPf.name)");

//Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));
//Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));

PessoaJuridica metodoPj = new PessoaJuridica ();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.name = "NomePj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razao Social Pj";
novaPj.rendimento = 8000.5f;
novoEndPj.logradouro = "Alameda Barao de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai Informatica";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.name}
Razao Social: {novaPj.razaoSocial}
Cnpj: {novaPj.cnpj}
CNPJ é valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");
*/
