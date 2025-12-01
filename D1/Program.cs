// See https://aka.ms/new-console-template for more information
using System;

public class QuizDeus
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--Quem é o Deus--");

        // As variáveis globais 'r1' e 'r2' devem ser inicializadas para evitar erros de compilação
        string r1 = "";
        string r2 = "";

        Console.WriteLine("Faz parte do Olimpo? (sim/não)");
        // Lemos a resposta e convertemos para minúsculas para facilitar a comparação
        r1 = Console.ReadLine().ToLower().Trim();

        // --- INÍCIO DA ÁRVORE DE DECISÃO ---

        // 1. VERIFICAÇÃO PRINCIPAL: Faz parte do Olimpo?
        if (r1 == "sim" || r1 == "s")
        {
            // O deus está no Olimpo (Zeus, Poseidon, Ares)

            Console.WriteLine("Tem poder de água? (sim/não)");
            r2 = Console.ReadLine().ToLower().Trim();

            // 1.1. TEM PODER DE ÁGUA?
            if (r2 == "sim" || r2 == "s")
            {
                // É Poseidon
                Console.WriteLine("\nO Deus é **Poseidon**!");
            }
            // 1.2. NÃO TEM PODER DE ÁGUA (Pode ser Zeus ou Ares)
            else if (r2 == "não" || r2 == "n")
            {
                Console.WriteLine("Tem poder de raio? (sim/não)");
                string r3 = Console.ReadLine().ToLower().Trim();

                // 1.2.1. TEM PODER DE RAIO?
                if (r3 == "sim" || r3 == "s")
                {
                    // É Zeus
                    Console.WriteLine("\nO Deus é **Zeus**!");
                }
                // 1.2.2. NÃO TEM PODER DE RAIO
                else if (r3 == "não" || r3 == "n")
                {
                    // É Ares (A única opção que sobrou no Olimpo sem raio/água)
                    Console.WriteLine("\nO Deus é **Ares**!");
                }
                else
                {
                    Console.WriteLine("\nResposta inválida. Não foi possível identificar o deus.");
                }
            }
            else
            {
                Console.WriteLine("\nResposta inválida. Não foi possível identificar o deus.");
            }
        }
        // 2. VERIFICAÇÃO ELSE: NÃO faz parte do Olimpo?
        else if (r1 == "não" || r1 == "n")
        {
            // O deus é Hades (Submundo, não Olimpo)
            Console.WriteLine("\nO Deus é **Hades**!");
        }
        // 3. Resposta Inválida para a primeira pergunta
        else
        {
            Console.WriteLine("\nResposta inválida para a primeira pergunta. Fim do quiz.");
        }
    }
}