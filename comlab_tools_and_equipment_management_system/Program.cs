using comlab_tools_and_equipment_management_system;
using ComlabManager.Infrastructure.Repositories;
using ComLabManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Windows.Forms;

namespace ComlabManager.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Define your MySQL Connection String
            string connectionString = "Server=localhost;Port=3306;Database=LabManagerDb;Uid=root;Pwd=102425;";

            // 2. Setup the Dependency Injection Container
            var services = new ServiceCollection();

            // 3. Register your tools (Whenever the UI asks for IEquipmentRepository, give it this one)
            services.AddTransient<IEquipmentRepository>(provider => new EquipmentRepository(connectionString));

            // Register your main form
            services.AddTransient<MainForm>();

            // 4. Build the factory and run the app
            var serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }
    }
}