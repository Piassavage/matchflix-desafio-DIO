using System;
using MatchFlix.Classes;
using MatchFlix.Enums;

namespace MatchFlix
{
    class Program
    {

        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static AnimacaoRepositorio repositorioAnimacao = new AnimacaoRepositorio();

        static void Main(string[] args)
        {   
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                case "1":
                    Console.WriteLine("\nSéries\n");
                    ListarSeries();
                    Console.WriteLine("\nFilmes\n");
                    ListarFilmes();
                    Console.WriteLine("\nAnimações\n");
                    ListarAnimacoes();
                    break;
                case "2":
                    Console.WriteLine("\nDigite o tipo de vídeo que você quer adicionar: ");
                    Console.WriteLine(" 1 - Série\n" +
                                      " 2 - Filme\n"+
                                      " 3 - Animação\n"+
                                      " C - Limpar a Tela\n"+
                                      " X - Voltar para o início\n");
                    
                    string opcaoAdd = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    
                    switch (opcaoAdd)
                    {
                        case "1":
                        InserirSerie();
                        break;
                        
                        case "2":
                        InserirFilme();
                        break;
                        
                        case "3":
                        InserirAnimacao();
                        break;
                        
                        case "C":
                        Console.Clear();
                        break;
                        
                        case "X":
                        break;

                        default:
                         throw new ArgumentOutOfRangeException("O caractere informado não possui opção!");
                    }
                    break;
                    case "3":
                    Console.WriteLine("\nDigite o tipo de vídeo que você quer atualizar: ");
                    Console.WriteLine(" 1 - Série\n" +
                                      " 2 - Filme\n"+
                                      " 3 - Animação\n"+
                                      " C - Limpar a Tela\n"+
                                      " X - Voltar para o início\n");
                    
                    string opcaoAtt = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    
                    switch (opcaoAtt)
                    {
                        case "1":
                        AtualizarSerie();
                        break;
                        
                        case "2":
                        AtualizarFilme();
                        break;
                        
                        case "3":
                        AtualizarAnimacao();
                        break;
                        
                        case "C":
                        Console.Clear();
                        break;
                        
                        case "X":
                        break;

                        default:
                         throw new ArgumentOutOfRangeException("O caractere informado não possui opção!");
                    }
                    break;
                    
                    case "4":
                    Console.WriteLine("\nDigite o tipo de vídeo que você quer excluir: ");
                    Console.WriteLine(" 1 - Série\n" +
                                      " 2 - Filme\n"+
                                      " 3 - Animação\n"+
                                      " C - Limpar a Tela\n"+
                                      " X - Voltar para o início\n");
                    
                    string opcaoExc = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    
                    switch (opcaoExc)
                    {
                        case "1":
                        ExcluirSerie();
                        break;
                        
                        case "2":
                        ExcluirFilme();
                        break;
                        
                        case "3":
                        ExcluirAnimacao();
                        break;
                        
                        case "C":
                        Console.Clear();
                        break;
                        
                        case "X":
                        break;

                        default:
                         throw new ArgumentOutOfRangeException("O caractere informado não possui opção!");
                    }
                    break;

                    case "5":
                    Console.WriteLine("\nDigite o tipo de vídeo que você quer visualizar: ");
                    Console.WriteLine(" 1 - Série\n" +
                                      " 2 - Filme\n"+
                                      " 3 - Animação\n"+
                                      " C - Limpar a Tela\n"+
                                      " X - Voltar para o início\n");
                    
                    string opcaoVis = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    
                    switch (opcaoVis)
                    {
                        case "1":
                        VisualizarSerie();
                        break;
                        
                        case "2":
                        VisualizarFilme();
                        break;
                        
                        case "3":
                        VisualizarAnimacao();
                        break;
                        
                        case "C":
                        Console.Clear();
                        break;
                        
                        case "X":
                        break;

                        default:
                         throw new ArgumentOutOfRangeException("O caractere informado não possui opção!");
                    }
                    break;

                    case "C":
                    Console.Clear();
                    break;

                    default :
                        throw new ArgumentOutOfRangeException("O caractere informado não possui opção!");

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
            
            Console.WriteLine("Obrigado por optar pela MatchFlix, até a Próxima!");
            Console.ReadLine();
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova Série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("\nDigite o gênero dentre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Criação da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse da Série: ");
            string entradaSinopse = Console.ReadLine();

            Video novaSerie = new Video(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);
            
            repositorioSerie.Insere(novaSerie);
        }

        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo Filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("\nDigite o gênero dentre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Criação do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse do Filme: ");
            string entradaSinopse = Console.ReadLine();

            Video novoFilme = new Video(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);
            
            repositorioFilme.Insere(novoFilme);
        }

        private static void InserirAnimacao()
        {
            Console.WriteLine("Inserir nova Animação");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("\nDigite o gênero dentre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Animação: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Criação da Animação: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse da Animação: ");
            string entradaSinopse = Console.ReadLine();

            Video novaAnimacao = new Video(id: repositorioAnimacao.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);
            
            repositorioAnimacao.Insere(novaAnimacao);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("\nDigite o gênero dentre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Criação da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse da Série: ");
            string entradaSinopse = Console.ReadLine();

            Video atualizaSerie = new Video(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);
            
            repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void AtualizarFilme()
        {
            Console.Write("Digite o id do Filme:");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("\nDigite o gênero dentre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Criação da Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse da Filme: ");
            string entradaSinopse = Console.ReadLine();

            Video atualizaFilme = new Video(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);
            
            repositorioFilme.Atualiza(indiceFilme, atualizaFilme);
        }

        private static void AtualizarAnimacao()
        {
            Console.Write("Digite o id da Animação: ");
            int indiceAnimacao = int.Parse(Console.ReadLine());
            
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("\nDigite o gênero dentre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Animacao: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Criação da Animacao: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse da Animacao: ");
            string entradaSinopse = Console.ReadLine();

            Video atualizaAnimacao = new Video(id: indiceAnimacao,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);
            
            repositorioAnimacao.Atualiza(indiceAnimacao, atualizaAnimacao);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceSerie);
        }

        private static void ExcluirFilme()
        {
            Console.Write("Digite o Id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            repositorioFilme.Exclui(indiceFilme);
        }

        private static void ExcluirAnimacao()
        {
            Console.Write("Digite o Id da Animação: ");
            int indiceAnimacao = int.Parse(Console.ReadLine());

            repositorioAnimacao.Exclui(indiceAnimacao);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void VisualizarFilme()
        {
            Console.Write("Digite o Id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioFilme.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);
        }

        private static void VisualizarAnimacao()
        {
            Console.Write("Digite o Id da Animação: ");
            int indiceAnimacao = int.Parse(Console.ReadLine());

            var animacao = repositorioAnimacao.RetornaPorId(indiceAnimacao);

            Console.WriteLine(animacao);
        }

        private static void ListarSeries()
        {
            
            var listaSerie = repositorioSerie.Lista();

            if (listaSerie.Count == 0)
            {
                Console.WriteLine("Nenhuma Série foi Cadastrada.");
                return;
            }

            foreach (var serie in listaSerie)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1}  {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void ListarFilmes()
        {
            var listaFilme = repositorioFilme.Lista();

            if (listaFilme.Count == 0)
            {
                Console.WriteLine("Nenhum Filme foi Cadastrado.");
                return;
            }

            foreach (var filme in listaFilme)
            {
            var excluido = filme.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1}  {2}", filme.retornaId(), filme.retornaTitulo(),  (excluido ? "*Excluído*" : ""));
            }
        }

        private static void ListarAnimacoes()
        {
            var listaAnimacao = repositorioAnimacao.Lista();

            if (listaAnimacao.Count == 0)
            {
                Console.WriteLine("Nenhuma Animação foi Cadastrada.");
                return;
            }

            foreach (var animacao in listaAnimacao)
            {
                var excluido = animacao.retornaExcluido();
                
                Console.WriteLine("#ID {0}: - {1}  {2}", animacao.retornaId(), animacao.retornaTitulo(),  (excluido ? "*Excluído*" : ""));
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\nSeja bem vindo à MatchFlix! \n"+
                                "\nInforme a opção desejada: ");

            Console.WriteLine(" 1 - Listar Vídeos \n"+
                              " 2 - Inserir Novo Vídeo \n"+
                              " 3 - Atualizar Vídeo\n" +
                              " 4 - Excluir Vídeo \n" +
                              " 5 - Visualizar Vídeo \n" +
                              " C - Limpar Tela\n"+
                              " X - Sair\n");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}