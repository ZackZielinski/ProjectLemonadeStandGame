using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LemonadeStand
{
    public class DatabaseLoad
    {
        SqlConnection connection;

        public DatabaseLoad()
        {
            connection = new SqlConnection("Server=DESKTOP-6AKH47F;Database=LemonadeStandLeaderboard;Integrated Security=true");
        }

        public void LoadGame()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Name, Days, Lemons, Sugar, Ice, Cups FROM LemonadeLeaderboard", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Console.WriteLine("Name: {0} \nDay: {1} \nLemons: {2} \nSugar: {3} \nIce: {4} \nCups: {5}",
                        reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    Console.WriteLine("*******************************");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
