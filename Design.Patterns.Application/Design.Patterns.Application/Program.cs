using Design.Patterns.Application.ChainOfResponsibility;
using Design.Patterns.Application.Strategy;
using System.Text.RegularExpressions;

namespace Design.Patterns.Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleHeader();
            int menuOptions = -1;
            List<DesignPatterns> Patterns = new List<DesignPatterns>() {
                new DesignPatterns("Strategy"),
                new DesignPatterns("Chain of Responsibility"),
                new DesignPatterns("Observer"),
                new DesignPatterns("Factory Method")
            };
            string regexPattern = string.Join("|", Patterns.Select((s, i) => $"{Regex.Escape(s.PatternName)}|{i + 1}"));
            Regex regex = new Regex(regexPattern);
            while (menuOptions != 0)
            {
                Console.WriteLine(" ");
                for(int i=0; i< Patterns.Count; i++)
                {
                    Console.WriteLine($"| {i + 1}- {Patterns[i].PatternName}");
                    
                }

                Console.WriteLine("| 0- Sair");
                Console.Write("Escolhe uma opção: ");
                string input = Console.ReadLine();
                
                Console.Clear();
                
                if(regex.IsMatch(input))
                {
                    string patternName = Patterns[menuOptions + Int32.Parse(input)].PatternName;
                    ConsoleHeader();
                    Console.WriteLine($"| Você selecionou:{patternName}");
                    Console.WriteLine();
                    
                    DesignPatterns desginPattern = new DesignPatterns(patternName);

                    List<string> niveis = new List<string>() { "Iniciante", "Intermediário", "Avançado" };

                    for (int i = 0; i < niveis.Count; i++)
                    {
                        Console.WriteLine($"| {niveis[i]}");
                    }

                    Console.Write("Escolha seu nível: ");
                    string inputNivel = Console.ReadLine();

                    switch (patternName) 
                    {
                        case "Strategy":
                            desginPattern.ExecuteStrategy(inputNivel);
                            break;
                        case "Chain of Responsibility":
                            desginPattern.ExecuteChainOfResponsibility(inputNivel);
                            break;
                        case "Observer":
                            //desginPattern.ExecuteObserver(inputNivel);
                            break;
                        case "Factory Method":
                            //desginPattern.ExecuteFactory(inputNivel);
                            break;
                    }
                }
                else if (Regex.IsMatch(input,"^(0|sair)$"))
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }
                else
                {
                    // Opção inválida
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine();
                }
            }
        
        }

        static void ConsoleHeader()
        {
            Console.Clear();
            Console.WriteLine("|--------------------------------------------------------------|");
            Console.WriteLine("|------------------  Console Design Pattern  ------------------|");
        }
    }
}