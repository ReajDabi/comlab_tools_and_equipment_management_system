using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace ComlabManager.Infrastructure.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly string _connectionString;

        // The repository demands a connection string when it is created
        public EquipmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Equipment> GetAllEquipment()
        {
            // The 'using' block ensures the connection closes automatically when done
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Equipment";
                return connection.Query<Equipment>(sql).ToList();
            }
        }
    }
}