using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game()
            {
                GameName = "GodOfWar",
                Price = 19

            };
            Gameservice gameservice = new Gameservice();
            gameservice.Create(game);

        }
    }
}