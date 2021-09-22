using BinaryToDecimal.Domain;
using BinaryToDecimal.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BinaryToDecimal
{
    sealed class Program
    {
        private readonly IBinaryToDecimalService _programService;
      
        public Program(IBinaryToDecimalService binaryToDecimalService)
        {
            _programService = binaryToDecimalService;
        }

        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();
        }

        private void Run()
        {
            var stopRunning = false;
            while (stopRunning == false)
            {
                Console.WriteLine("Digite uma sequência de números binários");
                var binarySequence = Console.ReadLine();
                var result = _programService.TransformBinaryToDecimal(binarySequence);
                Console.WriteLine(result);
                Console.WriteLine("Deseja parar?  S/N");
                var response = Console.ReadLine().ToUpper();
                if (response.Equals("S"))
                {
                    stopRunning = true;
                    Environment.Exit(0);
                }
                else if (response.Equals("N"))
                {
                    continue;
                }
            }
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                    services.AddTransient<IBinaryToDecimalService, BinaryToDecimalService>();
                });
        }
    }
}
