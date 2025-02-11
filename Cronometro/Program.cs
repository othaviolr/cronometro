using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Opções:");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("H = Hora => 1h = 1 hora");
            Console.WriteLine("R = Contagem Regressiva => 10r = 10 segundos regressivos");
            Console.WriteLine("P = Pomodoro (25 min trabalho, 5 min descanso)");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.ResetColor();

            string data = Console.ReadLine().ToLower();
            if (data == "0")
                System.Environment.Exit(0);

            if (data == "p")
            {
                Pomodoro();
                return;
            }

            if (string.IsNullOrWhiteSpace(data) || data == "0")
            {
                Console.WriteLine("Entrada inválida! Use algo como 10s, 5m, 2h ou 10r.");
                Thread.Sleep(1500);
                Menu();
                return;
            }

            bool countdown = data.EndsWith("r");

            int time;
            if (countdown)
            {
                data = data.Replace("r", "");
                if (!int.TryParse(data, out time) || time <= 0)
                {
                    Console.WriteLine("Formato inválido! Use algo como 10r para contagem regressiva.");
                    Thread.Sleep(2000);
                    Menu();
                    return;
                }

                PreStart(time, true);
                return;
            }

            char type = data[data.Length - 1];
            if (!int.TryParse(data.Substring(0, data.Length - 1), out time) || time <= 0)
            {
                Console.WriteLine("Formato inválido! Use algo como 10s, 5m ou 2h.");
                Thread.Sleep(2000);
                Menu();
                return;
            }

            int multiplier = 1;
            if (type == 'm') multiplier = 60;
            else if (type == 'h') multiplier = 3600;
            else if (type != 's')
            {
                Console.WriteLine("Tipo inválido! Use 's' para segundos, 'm' para minutos ou 'h' para horas.");
                Thread.Sleep(2000);
                Menu();
                return;
            }

            PreStart(time * multiplier, false);
        }

        static void Pomodoro()
        {
            int workTime = 25 * 60;
            int breakTime = 5 * 60;
            int cycles = 4;

            for (int i = 0; i < cycles; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"🍅 Pomodoro {i + 1} - Foco! (25 min)");
                Console.ResetColor();
                PreStart(workTime, countdown: true);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("☕ Hora do descanso! (5 min)");
                Console.ResetColor();
                PreStart(breakTime, countdown: true);
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("🎉 Parabéns! Você concluiu um ciclo completo de Pomodoro!");
            Console.ResetColor();

            Console.Beep();
            Thread.Sleep(1500);
            Menu();
        }

        static void PreStart(int time, bool countdown)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Agora!!!");
            Thread.Sleep(1000);
            Console.ResetColor();

            Start(time, countdown);
        }

        static void Start(int time, bool countdown)
        {
            int currentTime = countdown ? time : 0;

            while (countdown ? currentTime > 0 : currentTime < time)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Tempo {(countdown ? "restante" : "decorrido")}: {currentTime} segundos");

                int progressBarLength = 20;
                int progress = (time > 0) ? (currentTime * progressBarLength) / time : 0;
                Console.WriteLine("[" + new string('#', progress) + new string('-', progressBarLength - progress) + "]");

                Console.ResetColor();

                Thread.Sleep(1000);
                currentTime += countdown ? -1 : 1;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cronômetro finalizado!");
            Console.ResetColor();

            Console.Beep();
            Thread.Sleep(1500);
            Menu();
        }
    }
}
