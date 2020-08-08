using System;
using efc3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace efc3 {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine("主程序運行");
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<App>();
            serviceCollection.AddTransient<ContosouniversityContext,ContosouniversityContext>();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            Console.WriteLine("DI設定完成");


            Console.WriteLine("執行服務");
            serviceProvider.GetRequiredService<App>().AddItem();

            Console.ReadLine ();
        }
    }
}