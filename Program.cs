﻿using BibliotecaDejogos.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> listaDeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {

                Console.WriteLine("======BIBLIOTECA DE JOGOS======");

                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cadastro.");
                        }
                        break;

                    case "2":
                        resultado = ListarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Listado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem.");
                        }

                        break;

                    case "3":
                        resultado = EditarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Editado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem.");
                        }

                        break;

                    case "4":
                        resultado = DeletarJogos(listaDeJogos);
                        

                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static bool AdicionarJogo(List<Jogo> listaDejogos)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (titulo == "") return false;
            if (ano < 1950) return false;

            Jogo novoJogo = new Jogo(titulo, ano, "teste", 1);

            listaDejogos.Add(novoJogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos (List<Jogo> listaJogos)
        {
            foreach(Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            return true;
        }

        public static bool EditarJogos(List<Jogo> listaJogos)
        {
            Console.WriteLine("Escolha um jogo para editar: ");
            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }
            
            String opcao_escolha = Console.ReadLine();
            Console.WriteLine("O que você deseja editar no jogo: ");
            Console.WriteLine(opcao_escolha);
            Console.WriteLine("1 - Título ");
            Console.WriteLine("2 - Ano ");
            Console.WriteLine("Opcao: ");

            //bool resultado_editar;
            String opcao_editar = Console.ReadLine();

            /*switch (opcao_editar)
            {
                case "1":
                    resultado_editar = AdicionarJogo(listaDeJogos);
                    if (resultado_editar == true)
                    {
                        Console.WriteLine("Cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Erro no cadastro.");
                    }
                    break;

                case "2":
                    resultado_editar = ListarJogos(listaDeJogos);
                    if (resultado_editar == true)
                    {
                        Console.WriteLine("Listado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Erro na listagem.");
                    }

                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    break;*/

                    return true;
        }
        public static bool DeletarJogos(List<Jogo> listaDejogos)
        {
            Console.WriteLine("Escolha um jogo para deletar: ");
            foreach (Jogo jogo in listaDejogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }
            Console.WriteLine("Opcao: ");
            String opcao_delete = Console.ReadLine();
            //RemoveAt(opcao_delete);



            return true;
        }

    }

}
