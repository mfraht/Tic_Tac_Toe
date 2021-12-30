using Microsoft.EntityFrameworkCore;

namespace Tic_Tac_Toe.Models
{
    #pragma warning disable CS1591
    public class TicTacToeContext : DbContext
    {
        public TicTacToeContext(DbContextOptions<TicTacToeContext> options)
            : base(options)
        {
        }
    }
    #pragma warning restore CS1591
}
