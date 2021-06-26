using System;
using System.Collections.Generic;

namespace poi
{
    public class Item
    {
        public string Name;
        public int Id;
        public int Price;
        public string Efeito;
    }

    public class Player
    {
        public string nome;
        public int xp;
        public int gold;
        public List<Item> Itens = new List<Item>();
    }

    public class LP2_Trabalho
    {
        static List<Player> Jogadores = new List<Player>();

        public static void Main(string[] args)
        {
            bool MostrarMenu = true;
            while (MostrarMenu)
            {
                MostrarMenu = MenuPrincipal();
            }
        }

        private static void CriarJogador()
        {
            Console.Clear();
            Console.Write("Escreva um nome para o seu aventureiro: ");
            var NomeJogador = Console.ReadLine();
            NomeJogador = NomeJogador.ToLower();

            Console.Write("Coloque o nivel de experiência que você possui: ");
            var Exp = Console.ReadLine();

            Random GetEXP = new Random();
            var ouro = GetEXP.Next(50, 350);

            Jogadores.Add(new Player { nome = NomeJogador, xp = Convert.ToInt32(Exp), gold = ouro });
            Console.Clear();
            Console.WriteLine("Jogador criado com sucesso");
            Console.WriteLine("");
            Console.WriteLine("Adicionamos " + ouro + " de ouro na sua conta");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.Read();
        }

        private static void VisualizarJogadores()
        {
            Console.Clear();

            for (int i = 0; i < Jogadores.Count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Jogador:");
                Console.WriteLine("Nome : " + Jogadores[i].nome);
                Console.WriteLine("Exp : " + Jogadores[i].xp);
                Console.WriteLine("Ouro : " + Jogadores[i].gold);
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private static void ChecarInv()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador para ver o iventário:");
            var NomeJogador = Console.ReadLine();
            NomeJogador = NomeJogador.ToLower();
            foreach (Player p in Jogadores)
            {
                if (p.nome == NomeJogador)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Itens:");
                    Console.WriteLine("");
                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Item: " + p.Itens[i].Name);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.Read();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado... Retornando ao menu principal");
                    Console.Read();
                }
            }
        }

        public static void ItensdaLoja

            (
                Item Lança_Fiel,
                Item Escudo_de_Protenia,
                Item Lmapiao_Ajudante,
                Item Capuz_da_Invisibilidade
            )
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador que irá acessar a loja: ");
            var NomeJogador = Console.ReadLine();
            NomeJogador = NomeJogador.ToLower();

            foreach (Player p in Jogadores)
            {
                if (p.nome == NomeJogador)
                {
                    Console.WriteLine("- Insira o ID do item que você espera comprar:");
                    Console.WriteLine("");
                    Console.WriteLine(Lança_Fiel.Id + " - " + Lança_Fiel.Name + " " + Lança_Fiel.Efeito);
                    Console.WriteLine("");
                    Console.WriteLine(Escudo_de_Protenia.Id + " - " + Escudo_de_Protenia.Name + " " + Escudo_de_Protenia.Efeito);
                    Console.WriteLine("");
                    Console.WriteLine(Lmapiao_Ajudante.Id + " - " + Lmapiao_Ajudante.Name + " " + Lmapiao_Ajudante.Efeito);
                    Console.WriteLine("");
                    Console.WriteLine(Capuz_da_Invisibilidade.Id + " - " + Capuz_da_Invisibilidade.Name + " " + Capuz_da_Invisibilidade.Efeito);
                    Console.WriteLine("");

                    var itenconsult = Console.ReadLine();

                    if (itenconsult == Lança_Fiel.Id.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Lança_Fiel.Name + " por " + Lança_Fiel.Price + "de ouro?");
                        Console.WriteLine("(S)/(N)");
                        Console.WriteLine("");
                        Console.WriteLine("Seu ouro:" + p.gold);

                        var resp = Console.ReadLine();

                        if (resp == "s")
                        {
                            if (p.gold >= Lança_Fiel.Price)
                            {
                                p.gold = p.gold - Lança_Fiel.Price;
                                p.Itens.Add(Lança_Fiel);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }
                    }

                    else if (itenconsult == Escudo_de_Protenia.Id.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Escudo_de_Protenia.Name + " por " + Escudo_de_Protenia.Price + "de ouro?");
                        Console.WriteLine("(S)/(N)");
                        Console.WriteLine("");
                        Console.WriteLine("Seu ouro:" + p.gold);
                        var resp = Console.ReadLine();
                        if (resp == "s")
                        {
                            if (p.gold >= Escudo_de_Protenia.Price)
                            {
                                p.gold = p.gold - Escudo_de_Protenia.Price;
                                p.Itens.Add(Escudo_de_Protenia);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }
                    }

                    else if (itenconsult == Lmapiao_Ajudante.Id.ToString())
                    {

                        Console.WriteLine("Você gostaria de comprar " + Lmapiao_Ajudante.Name + " por " + Lmapiao_Ajudante.Price + "de ouro?");
                        Console.WriteLine("(S)/(N)");
                        Console.WriteLine("");
                        Console.WriteLine("Seu ouro:" + p.gold);
                        var resp = Console.ReadLine();
                        resp = resp.ToLower();
                        if (resp == "s")
                        {
                            if (p.gold >= Lmapiao_Ajudante.Price)
                            {
                                p.gold = p.gold - Lmapiao_Ajudante.Price;
                                p.Itens.Add(Lmapiao_Ajudante);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }
                    }

                    else if (itenconsult == Capuz_da_Invisibilidade.Id.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Capuz_da_Invisibilidade.Name + " por " + Capuz_da_Invisibilidade.Price + "de ouro?");
                        Console.WriteLine("(S)/(N)");
                        Console.WriteLine("");
                        Console.WriteLine("Seu ouro:" + p.gold);
                        var resp = Console.ReadLine();
                        resp = resp.ToLower();
                        if (resp == "s")
                        {
                            if (p.gold >= Capuz_da_Invisibilidade.Price)
                            {
                                p.gold = p.gold - Capuz_da_Invisibilidade.Price;
                                p.Itens.Add(Capuz_da_Invisibilidade);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao seu iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Ouro insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");
                                Console.Read();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Nenhum jogador encontrado...");
                        Console.WriteLine("Insira qualquer tecla para retornar ao menu principal...");
                        Console.ReadLine();
                    }
                }
            }
        }

        private static bool MenuPrincipal()
        {
            Item Lança_Fiel = new Item();
            Lança_Fiel.Id = 1;
            Lança_Fiel.Name = "Lança Fiel";
            Lança_Fiel.Price = 40;
            Lança_Fiel.Efeito = "Volta ao seu dono depois de lançada";

            Item Escudo_de_Protenia = new Item();
            Escudo_de_Protenia.Id = 2;
            Escudo_de_Protenia.Name = "Escudo de Protenia";
            Escudo_de_Protenia.Price = 100;
            Escudo_de_Protenia.Efeito = "É capaz de repelir não só ataques físicos como maldições e feitiços fracos";

            Item Lampiao_Ajudante = new Item();
            Lampiao_Ajudante.Id = 3;
            Lampiao_Ajudante.Name = "Lampião Ajudante";
            Lampiao_Ajudante.Price = 50;
            Lampiao_Ajudante.Efeito = "Um lampião giado por uma mão fantasma, que ilumina areas escuras próximas para você";

            Item Capuz_da_Invisibilidade = new Item();
            Capuz_da_Invisibilidade.Id = 5;
            Capuz_da_Invisibilidade.Name = "Capuz da Invisibilidade";
            Capuz_da_Invisibilidade.Price = 75;
            Capuz_da_Invisibilidade.Efeito = "Com certeza não roubei isso de outra franquia";

            Console.Clear();
            Console.WriteLine("Entre com '1' para criar um jogador (necessário para entrar na loja).");
            Console.WriteLine("Entre com '2' para ver os jogadores criados.");
            Console.WriteLine("Entre com '3' para ver o seu inventário.");
            Console.WriteLine("Entre com '4' para entrar na loja.");
            Console.WriteLine("Entre com '5' para encerrar o programa.");

            switch (Console.ReadLine())
            {
                case "1":
                    CriarJogador();
                    return true;

                case "2":
                    VisualizarJogadores();
                    return true;

                case "3":
                    ChecarInv();
                    return true;

                case "4":
                    ItensdaLoja
                    (
                        Lança_Fiel, 
                        Escudo_de_Protenia, 
                        Lampiao_Ajudante, 
                        Capuz_da_Invisibilidade
                    );
                return true;

                case "5":
                return false;

                default:
                return true;
            }
        }
    }
}
