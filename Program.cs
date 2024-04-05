using System;

namespace Instrucoes
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Declaracoes()
            {
                int iA;
                int iB = 2, iC = 3;
                const int iD = 4;
                iA = 1;
                Console.WriteLine($"O valor de iA + iB + iC + iD = {(iA + iB + iC + iD)}");
                double dE = iA + iB + iC + iD;
                double dDividir = dE / iC;
                Console.WriteLine($"O valor de dDividir é: {dDividir}");
                string sTexto = string.Empty;
                Console.WriteLine($"O valor de  sTexto é : {sTexto}");
            }

            static void InstrucaoIf(string[] args)
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Nenhum argumento!");
                }
                else if (args.Length == 1)
                {
                    Console.WriteLine("Temos um argumento!");
                }
                else
                {
                    Console.WriteLine($"Temos {args.Length} argumentos!");
                }
            }

            static void InstrucaoSwitch(string[] args)
            {
                switch (args.Length)
                {
                    case 0:
                        Console.WriteLine("Nenhum argumento!");
                        break;
                    case 1:
                        Console.WriteLine("Temos um argumento!");
                        break;
                    default:
                        Console.WriteLine($"Temos {args.Length} argumentos!");
                        break;
                }
            }

            static void InstrucaoWhile(string[] args)
            {
                int iCount = 0;
                while (iCount < args.Length)
                {
                    Console.WriteLine($"Este é o valor: {args[iCount]}, na posição: {iCount}.");
                    iCount++;
                }

            }

            static void InstrucaoDo(string[] args)
            {
                int iCount = 0;
                do
                {
                    Console.WriteLine($"Este é o valor: {args[iCount]}, na posição: {iCount}.");
                    iCount++;
                }
                while (iCount < args.Length);

                string sTexto = string.Empty;
                do
                {
                    sTexto = Console.ReadLine();
                    Console.WriteLine($"Você digitou {sTexto}");
                }
                while (!String.IsNullOrEmpty(sTexto));
            }

            static void InstrucaoFor(string[] args)
            {
                for (int iCount = 0; iCount < args.Length; iCount++)
                {
                    Console.WriteLine($"Este é o valor: {args[iCount]}, na posição: {iCount}");
                }
            }

            static void InstrucaoForeach(string[] args)
            {
                int iCount = 0;
                foreach (string sArgs in args)
                {
                    Console.WriteLine($"Este é o valor: {sArgs}, na posição: {iCount}");
                    iCount++;
                }
            }

            static void InstrucaoBreak(string[] args)
            {
                bool bDigitar = false;
                while (true)
                {
                    string sMenu = "digitar";
                    Console.WriteLine("         Menu:");
                    Console.WriteLine("->   Digitar");
                    Console.WriteLine("     Parar");
                    ConsoleKeyInfo ckiMover = Console.ReadKey();
                    if (ckiMover.Key == ConsoleKey.Enter)
                    {
                        if (sMenu.Equals("digitar"))
                            bDigitar = true;
                        else
                            bDigitar = false;
                        break;
                    }
                    if (ckiMover.Key == ConsoleKey.DownArrow)
                    {
                        Console.WriteLine("         Menu:");
                        Console.WriteLine("     Digitar");
                        Console.WriteLine("->   Parar");
                        sMenu = "parar";
                    }
                    if (ckiMover.Key == ConsoleKey.UpArrow)
                    {
                        Console.WriteLine("         Menu:");
                        Console.WriteLine("->   Digitar");
                        Console.WriteLine("     Parar");
                        sMenu = "digitar";
                    }
                }
                if (bDigitar)
                {
                    while (true)
                    {
                        string sTexto = Console.ReadLine();

                        if (string.IsNullOrEmpty(sTexto))
                            break;

                        Console.WriteLine($"Você digitou: {sTexto}");
                    }
                }

            }

            static void InstrucaoContinue(string[] args)
            {
                for (int iCount = 0; iCount < args.Length; iCount++)
                {
                    if (string.IsNullOrEmpty(args[iCount]))
                        continue;
                    if (args[iCount].StartsWith("/"))
                        continue;

                    Console.WriteLine($"O valor do argumento: {args[iCount]}, na posição: {iCount}");
                }
            }

            static void InstrucaoReturn(string[] args)
            {
                int Somar(int iA, int iB)
                {
                    return iA + iB;
                }

                Console.WriteLine($"O valor de 5 + 5 = {Somar(5, 5)}");
                Console.WriteLine($"O valor de 1 + 3 = {Somar(1, 3)}");
                Console.WriteLine($"O valor de 2 + 4 = {Somar(2, 4)}");
                return;
            }

            static void InstrucaoTryCatchFinallyThrow(string[] args)
            {
                double Dividir(double dX, double dY)
                {
                    if (dY == 0)
                        throw new DivideByZeroException("Impossivel divisão por 0!");
                    return dX / dY;
                }

                try
                {
                    if (args.Length != 2)
                        throw new InvalidOperationException("Informe 2 numeros!");

                    double dX = Convert.ToDouble(args[0]);
                    double dY = Convert.ToDouble(args[1]);
                    Console.WriteLine($"A divisão {dX} / {dY} = {Dividir(dX, dY)}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Operação invalida: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro genérico {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Até mais!");
                }
            }

            static void InstrucaoUsing(string[] args)
            {
                using (System.IO.TextWriter twArquivo = System.IO.File.CreateText($@"{AppDomain.CurrentDomain}/teste.txt"))
                {
                    twArquivo.WriteLine("linha 1");
                    twArquivo.WriteLine("linha 2");
                    twArquivo.WriteLine("linha 3");
                }
            }

        }
    }
}
