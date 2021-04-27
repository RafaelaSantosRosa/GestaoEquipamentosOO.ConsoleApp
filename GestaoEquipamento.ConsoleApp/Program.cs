using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamento.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChamados;
            string menuEquipamentos;
            string opcao;
            int idDesejado = 0;

            Console.WriteLine("Gestão de Equipamentos");
            while (true)
            {
                opcao = MenuPrincipal();
                if (opcao.Equals("S")) //s em maiúsculo por causa do toUpper, verificando se o usuário quer sair.
                    break;
                switch (opcao)
                {
                    case "1":
                        while (true)
                        {
                            menuEquipamentos = MenuEquipamentos();
                            if (menuEquipamentos.Equals("S")) break;
                            switch (menuEquipamentos)
                            {
                                case "1": Console.WriteLine("Registro de Equipamentos: ");
                                    Servicos.RegistroEquipamentos(idDesejado);
                                    break;
                                case "2": Console.WriteLine("Visualização Equipamentos: ");
                                    Servicos.VisualizarEquipamentos();
                                    break;
                                case "3": Console.WriteLine("Edição de Equipamento: ");
                                    Servicos.EditaEquipamento();
                                    break;
                                case "4": Console.WriteLine("Exclusão de Equipamento: ");
                                    Servicos.ExcluiEquipamento();
                                    break;

                            }

                        }
                        break;
                    case "2":
                        while (true)
                        {
                            menuChamados = MenuChamados();
                            if (menuChamados.Equals("S")) break;
                            switch (menuChamados)
                            {
                                case "1":
                                    Console.WriteLine("Registro de Chamados: ");
                                    Servicos.RegistroChamados(idDesejado);
                                    break;
                                case "2":
                                    Console.WriteLine("Visualização de Chamados: ");
                                    Servicos.VisualizaChamados();
                                    break;
                                case "3":
                                    Console.WriteLine("Edição de Chamados: ");
                                    Servicos.EditaChamados();
                                    break;
                                case "4":
                                    Console.WriteLine("Exclusão de Chamados: ");
                                    Servicos.ExcluiChamados();
                                    break;
                            }

                        }
                        break;
                }

            } 

        }

        public static String MenuPrincipal()
        {
            Console.WriteLine("\nInventário Disponível");
            Console.WriteLine("1 - Controle de Equipamentos");
            Console.WriteLine("2 - Controle de Chamados");
            Console.WriteLine("S - Sair");
            String str = Console.ReadLine().ToUpper(); //deixar tudo maiúsculo
            return str;
        }

        public static String MenuEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos");
            Console.WriteLine("1 - Registrar Equipamento");
            Console.WriteLine("2 - Visualizar Equipamentos");
            Console.WriteLine("3 - Editar um Equipamento");
            Console.WriteLine("4 - Excluir um Equipamento");
            Console.WriteLine("S - Sair");
            String str = Console.ReadLine().ToUpper();
            return str;
        }

        public static String MenuChamados()
        {
            Console.Clear();
            Console.WriteLine("Controle de Chamados");
            Console.WriteLine("1 - Registrar um Chamados");
            Console.WriteLine("2 - Visualizar Chamados");
            Console.WriteLine("3 - Editar um Chamado");
            Console.WriteLine("4 - Excluir um Chamado");
            Console.WriteLine("S - Sair");
            String str = Console.ReadLine().ToUpper();
            return str;
        }
    }
}
