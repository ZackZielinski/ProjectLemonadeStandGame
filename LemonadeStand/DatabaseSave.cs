using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LemonadeStand
{
    public class DatabaseSave
    {
        SqlConnection connection;
        public DatabaseSave()
        {
            connection = new SqlConnection("Server=DESKTOP-6AKH47F;Database=LemonadeStandLeaderboard;Integrated Security=true");
        }
        public void Save(string Name, int DayOfTheWeek, int Lemons, int Sugar, int Ice, int Cups)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO LemonadeLeaderboard VALUES ('{Name}', '{DayOfTheWeek}', '{Lemons}', '{Sugar}', '{Ice}', '{Cups}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Game Saved");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
