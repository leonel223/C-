using salvo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salvo1.Repositories
{
    public class IPlayerRepository : IRepositoryBase<Player>
    {
        public List<Player> ObterTodos()
        {
            using (var context = new MinHubContext())
            {
                var todos = context.Player.ToList();
                return todos;
            }
        }
    }
}
