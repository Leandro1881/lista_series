using Projeto_2.Classes;
using Projeto_2.Enum;
using System;

namespace Projeto_2
{
    class Program
    {
        static SerieRepositorio sr = new SerieRepositorio();
        static void Main(string[] args)
        {
            string op = ObterOpcao();
            while (op != "x")
            {
                switch (op)
                {
                    case "1":
                        Listar();
                        break;
                    case "2":
                        Inserir();
                        break;
                    case "3":
                        Atualizar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    case "x":
                        break;
                    default:
                        throw new Exception("Olá");

                }
                op = ObterOpcao();
            }
    
        }
        public static string ObterOpcao()
        {
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            string op = Console.ReadLine().ToLower();
            Console.WriteLine();
            return op;
        }
        public static void Listar()
        {
            var lista = sr.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }
            Console.WriteLine("Imprimindo lista:");
            foreach (var serie in lista)
            {
                string a;
                bool s = serie.getExcluir();
                if (s) a = "sim";
                else a = "não";
                Console.WriteLine("ID: {0} - NOME: {1} - EXCLUIDO: {2}", serie.getId(), serie.getTitulo(), a);
                
                
            }
            Console.WriteLine("Terminando lista.");
        }

        public static void Inserir()
        {
            Console.WriteLine("Digite o gênero ");
            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, System.Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine();
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ID");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite a descrição:");
            string descricao = Console.ReadLine();

            Console.WriteLine("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            Serie s = new Serie(Id, (Genero) numero, titulo, descricao, ano);
            sr.Insere(s);
        }
        public static void Atualizar()
        {
            Console.WriteLine("Digite o ID");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o gênero ");
            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, System.Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine();
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite a descrição:");
            string descricao = Console.ReadLine();

            Console.WriteLine("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            Serie s = new Serie(Id, (Genero) numero, titulo, descricao, ano);
            sr.Atualiza(Id, s);

        }
        public static void Excluir()
        {
            Console.WriteLine("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());
            sr.Exclui(id);
        }
        public static void Visualizar()
        {
            Console.WriteLine("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());
            Serie s = sr.RetornaPorId(id);
            Console.WriteLine(s);
        }
        
    }
}
