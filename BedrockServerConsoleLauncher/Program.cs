using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using MinecraftLauncherConsole.Models;
using Newtonsoft.Json;

namespace MinecraftLauncherConsole
{
    class Program
    {
        private static string ConfigFile = "./Config/config.json";
        private static MinecraftLauncher launcher;

        static async Task Main(string[] args)
        {
            string json = File.ReadAllText(ConfigFile);
            var config = JsonConvert.DeserializeObject<Configuration>(json);
            if (args.Length > 0)
            {
                config.WorldName = args[0];
            }

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);

            launcher = new MinecraftLauncher(config);
            await launcher.Update();
            launcher.Start();

            while (true)
            {
                Thread.Sleep(5000);
            }
        }
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            Console.WriteLine("Stopping server...");
            launcher.Stop();
            launcher.Join();
            Console.WriteLine("...done");
        }
    }
}
