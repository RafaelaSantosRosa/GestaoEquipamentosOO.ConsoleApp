using System;
using System.Collections.Generic;

namespace GestaoEquipamento.ConsoleApp
{
    class Servicos
    {
        //EQUIPAMENTOS:
        public static List<string> listaEquipamentos = new List<string>();
        public static List<string> listaChamados = new List<string>();
        public static int aux = 0;

        public static int idDesejado;
        public static void RegistroEquipamentos(int idDesejado)
        {
            Console.Clear();

            string nome = "";
            bool nomeInvalido = false;
            do
            {
                Console.Write("Digite o nome do equipamento: ");
                nome = Console.ReadLine();
                if (nome.Length < 6)
                {
                    nomeInvalido = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome inválido. No mínimo 6 caracteres");
                    Console.ResetColor(); ;
                }
                else
                {
                    nomeInvalido = false;
                }

            } while (nomeInvalido);

            Equipamentos equipamento = new Equipamentos();

            Console.Write("Digite o preço do equipamento: ");
            equipamento.Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número do equipamento: ");
            equipamento.NumeroSerie = Console.ReadLine();

            bool datainvalida = false;
            do
            {

                try
                {
                    Console.Write("Digite a data de fabricação do equipamento: ");
                    equipamento.Data = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Data inválida!");
                    datainvalida = true;
                    Console.ResetColor();
                }
            } while (datainvalida);

            Console.Write("Digite o fabricante do equipamento: ");
            equipamento.Fabricante = Console.ReadLine();

            Console.Clear();

            equipamento.Id = aux++;

            listaEquipamentos.Add("\n Id Equipamento: " + equipamento.Id + "\n Preço: " + equipamento.Preco + "\n Número de Série: " + equipamento.NumeroSerie + "\n Data: " + equipamento.Data + "\n Fabricante: " + equipamento.Fabricante);
        }
        public static void VisualizarEquipamentos()
        {
            Console.Clear();
            foreach (var item in listaEquipamentos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void EditaEquipamento()
        {
            Console.Clear();
            VisualizarEquipamentos();
            Console.WriteLine();

            Console.WriteLine("Digite o id do equipamento que deseja editar: ");
            int idDesejado = Convert.ToInt32(Console.ReadLine());


            RegistroEquipamentos(idDesejado);
        }

        public static void ExcluiEquipamento()
        {
            Console.Clear();
            VisualizarEquipamentos();

            Console.WriteLine("Digite o id do equipamento que deseja excluir");
            idDesejado = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< listaEquipamentos.Count; i++)
            {
                if (i == idDesejado)
                {
                    listaEquipamentos.RemoveAt(idDesejado);
                }
            
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento excluído com sucesso!");
            Console.ResetColor();
            Console.ReadLine();
        }

        //CHAMADOS:
        public static void RegistroChamados(int idDesejado)
        {
            int aux = 0;
            Chamados chamado = new Chamados();

            Console.Clear();
            VisualizarEquipamentos();
            Console.WriteLine("Digite o id do equipamento que deseja efetuar chamado");
            idDesejado = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o titulo do chamado: ");
            chamado.Titulo = Console.ReadLine();

            Console.Write("Digite a descricao do chamado: ");
            chamado.Descricao = Console.ReadLine();

            bool datainvalida = false;
            do
            {
                try
                {
                    Console.Write("Digite a data de abertura do chamado: ");
                    chamado.DataAbertura = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Data inválida!");
                    datainvalida = true;
                    Console.ResetColor();
                }
            } while (datainvalida);

            aux++;
            chamado.Id = aux;

            TimeSpan diasEmAberto = DateTime.Now - chamado.DataAbertura;

            listaChamados.Add("\n id: " + chamado.Id + "\n título: " + chamado.Titulo + "\n descrição do chamado: " + chamado.Descricao + "\n dias em aberto: " + diasEmAberto.ToString("dd"));
        }

        public static void VisualizaChamados()
        {
            Console.Clear();
            foreach (var item in listaChamados)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void EditaChamados()
        {
            Console.Clear();

            VisualizaChamados();

            Console.WriteLine("Digite o id do chamado que deseja editar: ");
            idDesejado = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            RegistroChamados(idDesejado);
        }

        public static void ExcluiChamados()
        {
            Console.Clear();
            VisualizarEquipamentos();

            Console.WriteLine("Digite o id do chamado que deseja excluir");
            idDesejado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < listaChamados.Count; i++)
            {
                if (i == idDesejado)
                {
                    listaChamados.RemoveAt(idDesejado);
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chamado excluído com sucesso!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
