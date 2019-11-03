using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Autofac.Configuration;

namespace SoftwareDesignerLibrary
{
    public static class Engine
    {
        
        public static IContainer DIContainer;

        public static ContainerBuilder DIBuilder = new ContainerBuilder();

        public static bool IsRunning = false;
        public static void Run() {

            if (IsRunning) return;

            IsRunning = true;

            if (!IsAutofacModuleRegistered) RegisterAutofacModule("autofac.json");
            DIContainer = DIBuilder.Build();

        }

        private static bool IsAutofacModuleRegistered;
        public static void RegisterAutofacModule(string JsonFilePath)
        {
            IsAutofacModuleRegistered = true;

            var config = new ConfigurationBuilder();
            // config.AddJsonFile comes from Microsoft.Extensions.Configuration.Json
            // config.AddXmlFile comes from Microsoft.Extensions.Configuration.Xml
            config.AddJsonFile(JsonFilePath);

            // Register the ConfigurationModule with Autofac.
            var module = new ConfigurationModule(config.Build());
            DIBuilder.RegisterModule(module);
        }
    }
}
