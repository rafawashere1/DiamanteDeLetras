namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDiamanteSuperior = 0;
            int tamanhoDiamante = 0;
            int letraDoMeio = 0;

            // Input de dados
            Console.WriteLine("-------- Diamante de Letras --------");
            Console.WriteLine();

            Console.WriteLine(">> Digite uma letra de A a Z para formar um diamante: ");
            Console.Write(">> ");
            char input = Convert.ToChar(Console.ReadLine().ToUpper());

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoSeparado = alfabeto.ToCharArray();

            // Coleta do tamanho do diamante e letra do meio
            for (int i = 0; i < alfabetoSeparado.Length; i++)
            {
                if (alfabetoSeparado[i] == input)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        tamanhoDiamanteSuperior = j;
                        letraDoMeio = j;
                    }
                    tamanhoDiamante = tamanhoDiamanteSuperior * 2 + 1;

                }

                else { }
            }

            int quantidadeEspacosEmBrancoSuperior = (tamanhoDiamante - 1) / 2;
            int quantidadeEspacosEmBrancoMeio = 0;
            int quantidadeEspacosEmBrancoInferior = 1;
            int quantidadeDeLinhas = (tamanhoDiamante - 1) / 2;
            int letraSuperior = 0;
            int letraInferior = letraDoMeio - 1;

            // Parte superior do diamante
            for (int linha = 0; linha <= quantidadeDeLinhas; linha++)
            {
                // Incrementador de espaços em branco à esquerda
                for (int i = 0; i < quantidadeEspacosEmBrancoSuperior; i++)
                {
                    Console.Write(" ");
                }

                // Primeira linha
                if (linha == 0)
                {
                    Console.Write(alfabetoSeparado[letraSuperior]);
                    for (int j = 1; j < quantidadeEspacosEmBrancoMeio; j++)
                    {
                        Console.Write(" ");
                    }
                    letraSuperior++;
                    Console.WriteLine();
                }

                // Seguintes linhas até o meio
                else if (linha > 0 && linha < alfabetoSeparado[letraDoMeio])
                {
                    for (int i = 0; i < tamanhoDiamante - 1; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write(alfabetoSeparado[letraSuperior]);
                            for (int j = 1; j < quantidadeEspacosEmBrancoMeio; j++)
                            {
                                Console.Write(" ");
                            }
                            letraSuperior++;
                            Console.WriteLine(alfabetoSeparado[letraSuperior - 1]);
                        }
                    }
                }
                
                // Linha do meio
                else if (linha == alfabetoSeparado[letraDoMeio])
                {
                    quantidadeEspacosEmBrancoMeio -= 3;

                    Console.Write(alfabetoSeparado[letraDoMeio]);

                    for (int i = 0; i < tamanhoDiamante - 2; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine(alfabetoSeparado[letraDoMeio]);
                    Console.WriteLine();
                }
                Console.WriteLine();
                quantidadeEspacosEmBrancoSuperior--;
                quantidadeEspacosEmBrancoMeio += 2;

            }

            quantidadeEspacosEmBrancoMeio -= 5;

            // Parte inferior do diamante
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                // Incrementador de espaços em branco à esquerda
                for (int i = 0; i < quantidadeEspacosEmBrancoInferior; i++)
                {
                    Console.Write(" ");
                }

                if (linha == 0)
                {
                    // Primeira linha após o centro
                    if (letraInferior == 0)
                    {
                        Console.WriteLine('A');
                        break;
                    }
                    else
                    {
                        Console.Write(alfabetoSeparado[letraInferior]);

                        for (int j = 0; j < quantidadeEspacosEmBrancoMeio; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine(alfabetoSeparado[letraInferior]);
                        letraInferior--;
                    }
                }
                // Seguintes linhas
                else if (linha > 0)
                {
                    for (int i = 0; i < tamanhoDiamante; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write(alfabetoSeparado[letraInferior]);
                            for (int j = 0; j < quantidadeEspacosEmBrancoMeio; j++)
                            {
                                Console.Write(" ");
                            }
                            letraInferior--;
                            if (letraInferior >= 0)
                            {
                                Console.WriteLine(alfabetoSeparado[letraInferior + 1]);
                            }
                            break;
                        }
                    }
                }
                Console.WriteLine();
                quantidadeEspacosEmBrancoInferior++;
                quantidadeEspacosEmBrancoMeio -= 2;
            }
        }
    }
}