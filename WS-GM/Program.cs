using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Liste des processus :");
        Console.WriteLine("---------------------");

        Process[] processes = Process.GetProcesses();

        foreach (Process process in processes)
        {
            Console.WriteLine($"ID: {process.Id}, Nom: {process.ProcessName}, Priorité: {process.BasePriority}, Taille mémoire virtuelle 64bits: {process.VirtualMemorySize64}");
        }

        Console.ReadLine();

        /*Process notepad = LaunchProcess("notepad.exe", "C:\\Windows\\win.ini", "edit");
        Process explorer = LaunchProcess("explorer.exe", "C:\\Windows", "explore");


        Console.WriteLine("Le programme principal a terminé son exécution.");*/
    }

    /*static Process LaunchProcess(string fileName)
    {
        Process process = new Process();
        process.StartInfo.FileName = fileName;

        process.Start();
        Console.WriteLine($"Processus {fileName} n° {process.Id} est lancé.");

        process.WaitForExit();
        return process;
    }*/
    /*static Process LaunchProcess(string fileName, string arguments = null)
    {
        Process process = new Process();
        process.StartInfo.FileName = fileName;
        process.StartInfo.Arguments = arguments;

        process.Start();
        Console.WriteLine($"Processus {fileName} n° {process.Id} est lancé.");

        process.WaitForExit();

        Thread.Sleep(2000);
        return process;
    }*/
    /*static Process LaunchProcess(string fileName, string arguments = null, string verb = "open")
    {
        Process process = new Process();
        process.StartInfo.FileName = fileName;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.Verb = verb;

        process.Start();
        Console.WriteLine($"Processus {fileName} n° {process.Id} est lancé.");

        process.WaitForExit();

        Thread.Sleep(2000);
        return process;
    }*/
    /*static Process LaunchProcess(string fileName, string arguments = null, string verb = "open")
    {
        Process process = new Process();
        process.StartInfo.FileName = fileName;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.Verb = verb;

        process.Start();
        Console.WriteLine($"Processus {fileName} n° {process.Id} est lancé.");

        // Attacher un gestionnaire d'événements au processus fils pour détecter sa finalisation
        process.Exited += ExitHandler;

        // Attendre que le processus se termine sans bloquer le thread principal
        ThreadPool.QueueUserWorkItem(state =>
        {
            process.WaitForExit();

            // Afficher si le processus est toujours actif ou non
            Console.WriteLine($"Processus {fileName} n° {process.Id} est {(process.HasExited ? "terminé" : "encore actif")}");
        });

        Thread.Sleep(2000);
        return process;
    }

    // Gestionnaire d'événements pour la finalisation du processus fils
    static void ExitHandler(object sender, EventArgs e)
    {
        Console.WriteLine("Le processus fils est terminé.");
    }*/
}
