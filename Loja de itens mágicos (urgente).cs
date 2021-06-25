using System;
using System.Collections.Generic;

public class Iten
{
    public string Name;

    public int Id;

    public int price;

    public string efeito;
}

public class Player
{
    public string nome;

    public int xp;

    public int gold;

    public List<Iten> Itens = new List<Iten>();
}

public class LP2_Trabalho
{
    static List<Player> Jogadores = new List<Player>();

    public static void Main(string[] args)
    {
        bool start = true;
        while (start)
        {
            start = Start();
        }
    }

    private static bool Start()
    {
        Iten Lança_Fiel = new Iten();
        Lança_Fiel.Id = 1;
        Lança_Fiel.Name = "Lança Fiel";
        Lança_Fiel.price = 55;
        Lança_Fiel.efeito = "Volta ao seu dono depois de lançada";

        Iten Escudo_de_Protenia = new Iten();
        Escudo_de_Protenia.Id = 2;
        Escudo_de_Protenia.Name = "Escudo de Protênia";
        Escudo_de_Protenia.price = 125;
        Escudo_de_Protenia.efeito = "É capaz de repelir não só ataques físicos como maldições e feitiços fracos";

        Iten Lampiao_Ajudante = new Iten();
        Lampiao_Ajudante.Id = 3;
        Lampiao_Ajudante.Name = "Lampião Ajudante";
        Lampiao_Ajudante.price = 75;
        Lampiao_Ajudante.efeito = "Um lampião giado por uma mão fantasma, que ilumina areas escuras próximas para você";

        Iten Capuz_da_Invisibilidade = new Iten();
        Capuz_da_Invisibilidade.Id = 4;
        Capuz_da_Invisibilidade.Name = "Capuz da Invisibilidade";
        Capuz_da_Invisibilidade.price = 300;
        Capuz_da_Invisibilidade.efeito = "Com certeza não roubei isso de outra franquia";

        Console.Clear();
        Console.WriteLine("Entre com '1' para criar um jogador.");
        Console.WriteLine("Entre com '2' para ver lista de jogadores;.");
        Console.WriteLine("Entre com '3' para ver o seu inventário.");
        Console.WriteLine("Entre com '4' para entrar na loja.");
        Console.WriteLine("Entre com '5' para encerrar o programa.");

        switch (Console.ReadLine())
        {
            case "1":

                Console.Clear();

                Console.Write("Digite o seu nome, aventureiro: ");
                var NomeJogador = Console.ReadLine();
                NomeJogador = NomeJogador.ToLower();

                Console.Write("Insira o quão experiente você é: ");
                var EXP = Console.ReadLine();

                Random GetEXP = new Random();
                var Moedas = GetEXP.Next(50, 350);

                Jogadores.Add(new Player { nome = NomeJogador, xp = Convert.ToInt32(EXP), gold = Moedas });

                Console.WriteLine("Jogador criado com sucesso");
                Console.WriteLine("");
                Console.WriteLine("Você começa com " + Moedas + " de ouro na sua conta");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.Read();
            return true;

            case "2":

                Console.Clear();

                for (int i = 0; i < Jogadores.Count; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Jogador:");
                    Console.WriteLine("Nome : " + Jogadores[i].nome);
                    Console.WriteLine("Experiência : " + Jogadores[i].xp);
                    Console.WriteLine("Ouro : " + Jogadores[i].gold);
                    Console.WriteLine("");
                }

                Console.Write("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            return true;

            case "3":

                Console.Clear();

                Console.WriteLine("Digite o nome do jogador para verificar o seu iventário:");

                var NomeJogador0 = Console.ReadLine();
                NomeJogador0 = NomeJogador0.ToLower();

                foreach (Player p in Jogadores)
                {
                    if (p.nome == NomeJogador0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Itens:");
                        Console.WriteLine("");
                        for (int i = 0; i < p.Itens.Count; i++)
                        {
                            Console.WriteLine("Item: " + p.Itens[i].Name);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Entre com qualquer tecla para continuar");
                        Console.Read();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Nenhum jogador encontrado... Presione qualquer tecla para retornar ao menu principal");
                        Console.Read();
                    }
                }
            return true;

            case "4":
                Console.Clear();
                Console.WriteLine("Digite o nome do jogador que vai acessar a loja: ");
                NomeJogador0 = Console.ReadLine();
                NomeJogador0 = NomeJogador0.ToLower();
                foreach (Player p in Jogadores)
                {
                    if (p.nome == NomeJogador0)
                    {
                        Console.WriteLine("Insira o ID do item que você deseja comprar:");
                        Console.WriteLine("");
                        Console.WriteLine(Lança_Fiel.Id + " - " + Lança_Fiel.Name + " " + Lança_Fiel.efeito);
                        Console.WriteLine("");
                        Console.WriteLine(Escudo_de_Protenia.Id + " - " + Escudo_de_Protenia.Name + " " + Escudo_de_Protenia.efeito);
                        Console.WriteLine("");
                        Console.WriteLine(Lampiao_Ajudante.Id + " - " + Lampiao_Ajudante.Name + " " + Lampiao_Ajudante.efeito);
                        Console.WriteLine("");
                        Console.WriteLine(Capuz_da_Invisibilidade.Id + " - " + Capuz_da_Invisibilidade.Name + " " + Capuz_da_Invisibilidade.efeito);
                        Console.WriteLine("");
                        var ic = Console.ReadLine();

                        if (ic == Lança_Fiel.Id.ToString())
                        {
                            Console.WriteLine("Está interessado em comprar " + Lança_Fiel.Name + " por " + Lança_Fiel.price + "G?");
                            Console.WriteLine("(S)/(N)");
                            Console.WriteLine("");
                            Console.WriteLine("Seu ouro:" + p.gold);
                            var resp = Console.ReadLine();

                            if (resp == "s")
                            {
                                if (p.gold >= Lança_Fiel.price)
                                {
                                    p.gold = p.gold - Lança_Fiel.price;
                                    p.Itens.Add(Lança_Fiel);
                                    Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                    Console.WriteLine("Pressione qualquer tecla para continuar..");
                                    Console.Read();
                                }
                                else
                                {
                                    Console.WriteLine("Saldo insuficiente");
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

                        else if (ic == Escudo_de_Protenia.Id.ToString())
                        {
                            Console.WriteLine("Está interessado em comprar " + Escudo_de_Protenia.Name + " por " + Escudo_de_Protenia.price + "G?");
                            Console.WriteLine("(S)/(N)");
                            Console.WriteLine("");
                            Console.WriteLine("Seu ouro:" + p.gold);
                            var resp = Console.ReadLine();
                            if (resp == "s")
                            {
                                if (p.gold >= Escudo_de_Protenia.price)
                                {
                                    p.gold = p.gold - Escudo_de_Protenia.price;
                                    p.Itens.Add(Escudo_de_Protenia);
                                    Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                    Console.WriteLine("Pressione qualquer tecla para continuar..");
                                    Console.Read();
                                }
                                else
                                {
                                    Console.WriteLine("Saldo insuficiente");
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

                        else if (ic == Lampiao_Ajudante.Id.ToString())
                        {
                            Console.WriteLine("Está interessado em comprar " + Lampiao_Ajudante.Name + " por " + Lampiao_Ajudante.price + "G?");
                            Console.WriteLine("(S)/(N)");
                            Console.WriteLine("");
                            Console.WriteLine("Seu ouro:" + p.gold);
                            var resp = Console.ReadLine();
                            resp = resp.ToLower();
                            if (resp == "s")
                            {
                                if (p.gold >= Lampiao_Ajudante.price)
                                {
                                    p.gold = p.gold - Lampiao_Ajudante.price;
                                    p.Itens.Add(Lampiao_Ajudante);
                                    Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                    Console.WriteLine("Pressione qualquer tecla para continuar..");
                                    Console.Read();
                                }
                                else
                                {
                                    Console.WriteLine("Saldo insuficiente");
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

                        else if (ic == Capuz_da_Invisibilidade.Id.ToString())
                        {
                            Console.WriteLine("Está interessado em comprar " + Capuz_da_Invisibilidade.Name + " por " + Capuz_da_Invisibilidade.price + "G?");
                            Console.WriteLine("(S)/(N)");
                            Console.WriteLine("");
                            Console.WriteLine("Seu ouro:" + p.gold);
                            var resp = Console.ReadLine();
                            resp = resp.ToLower();
                            if (resp == "s")
                            {
                                if (p.gold >= Capuz_da_Invisibilidade.price)
                                {
                                    p.gold = p.gold - Capuz_da_Invisibilidade.price;
                                    p.Itens.Add(Capuz_da_Invisibilidade);
                                    Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                    Console.WriteLine("Pressione qualquer tecla para continuar..");
                                    Console.Read();
                                }
                                else
                                {

                                    Console.WriteLine("Saldo insuficiente");
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
            return true;

            case "5":
                return false;

            default:
                return true;
        }
    }
}