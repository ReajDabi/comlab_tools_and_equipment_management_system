using comlab_tools_and_equipment_management_system;
using ComlabManager.Core.Interfaces;
using ComlabManager.Infrastructure.Repositories;
using ComLabManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

    

namespace ComLabManager.UI
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
            services.AddTransient<IUserRepository>(provider => new UserRepository(connectionString));



            // Register your main form
            services.AddTransient<MainForm>();




            services.AddTransient<LoginForm>();




            // 4. Build the factory and run the app
            var serviceProvider = services.BuildServiceProvider();
            
            using (var connection = new MySqlConnection(connectionString))
            {
                string realHash = BCrypt.Net.BCrypt.HashPassword("admin123");
                string updateSql = "UPDATE Users SET PasswordHash = @Hash WHERE Username = 'admin_reaj'";
                connection.Execute(updateSql, new { Hash = realHash });
            }
            // ------------------------------

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
      
            {
                // If login was successful, run the main application
                Application.Run(serviceProvider.GetRequiredService<MainForm>());
            }
            else
            {
                // If they click the "X" on the login screen, exit completely
                Application.Exit();
            }
        }
    }
}