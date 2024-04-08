using System;
using Series;


class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoEscolhida = ObterOpcaoUsuario();

            while(opcaoEscolhida.ToUpper() != "x")
            {
                switch(opcaoEscolhida)
                {
                    case "1":
                    ListarSeries();
                    break;
                case "2":
                    //InserirSeries();
                    break;
                case "3":
                   // AtualizarSeries();
                    break;
                case "4":
                    //ExcluirSeries();
                    break;
                case "5":
                    //VisualizarSeries();
                    break;
                case "C":
                    Console.Clear();
                    break;


                default:
                    throw new ArgumentException();

                }
                
                    opcaoEscolhida = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado");
            Console.ReadLine();

           
        }


        private static void ListarSeries()
        {
            Console.WriteLine("Listar Series");

            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie encontrada");
                return;
            }
            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}" ,serie.retornaId(), serie.retornaTitulo());
            }
            {
                
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Sistema de Series");
            Console.WriteLine("informe a opcao desejada:");

            Console.WriteLine("1- Listar series");
            Console.WriteLine("2- Inserir nova series");
            Console.WriteLine("3- Atualizar series");
            Console.WriteLine("4- Excluir series");
            Console.WriteLine("5- Visualizar series");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("C- Sair");
            Console.WriteLine();

            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoEscolhida;

            
            
        }
    }