using comlab_tools_and_equipment_management_system;
using ComlabManager.Core.Interfaces;
using ComlabManager.Infrastructure.Repositories;
using ComLabManager.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
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

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;



           
            var services = new ServiceCollection();



           
            services.AddTransient<IEquipmentRepository>(provider => new EquipmentRepository(connectionString));
            services.AddTransient<IUserRepository>(provider => new UserRepository(connectionString));



            
            services.AddTransient<MainForm>();




            services.AddTransient<LoginForm>();




            var serviceProvider = services.BuildServiceProvider();
            
            using (var connection = new MySqlConnection(connectionString))
            {
                string realHash = BCrypt.Net.BCrypt.HashPassword("admin123");
                string updateSql = "UPDATE Users SET PasswordHash = @Hash WHERE Username = 'admin_reaj'";
                connection.Execute(updateSql, new { Hash = realHash });
            }
          

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
      
            {
             
                Application.Run(serviceProvider.GetRequiredService<MainForm>());
            }
            else
            {
               
                Application.Exit();
            }
        }
    }
}