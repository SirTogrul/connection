using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
      public class Gameservice
    {
        AppDbContext DbContext;
        public Gameservice()
        {
            this.DbContext = new AppDbContext();   
        }
        public void Create(Game game)
        {
            string command = $"insert into Game values('{game.GameName}','{game.Price}')";
            int result = DbContext.Nonquery(command);
        }
    }
}
