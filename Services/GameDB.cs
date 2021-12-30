using Microsoft.AspNetCore.Mvc;
using Tic_Tac_Toe.Models;
using static Tic_Tac_Toe.Controllers.GamesController;

namespace Tic_Tac_Toe.Services
{
    public class GameDB
    {
        private List<Game> games;

        public GameDB()
        {
            games = new List<Game>();
        }

        public Game Start(_playerJson request)
        {
            Prune();
            Game game = new Game(request);
            games.Add(game);
            return game;
        }

        public Game JoinGame(string id, char player)
        {
            Prune();
            Game game = games.Find(x => x.id == id);
            if (game != null && game.JoinGame(player)) { return game; }
            return null;
        }

        public Game JoinGame(char player)
        {
            Prune();
            Game game = games.Find(x => x.SecondPlayer == '-');
            if (game == null) { return null; }
            return JoinGame(game.id, player);
        }

        //internal static ActionResult<List<Game>> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public List<Game> Get()
        {
            Prune();
            return games;
        }

        public Game Get(string id)
        {
            Prune();
            return games.Find(x => x.id == id);
        }

        public bool Update(string id, Move move)
        {
            Prune();
                Game game = games.Find(x => x.id == id);
            if (game == null) { return false; }
            return game.Move(move);
        }

        public void Remove(string id)
        {
            games.Remove(games.Find(x => x.id == id));
        }

        public void Remove(Game game)
        {
            games.Remove(game);
        }

        public void Prune()
        {
            Game game;
            for (int i = 0; i < games.Count; i++)
            {
                game = games[i];
                if (games[i].LastMoveOn.AddMinutes(30).CompareTo(DateTime.Now) < 0)
                {
                    Remove(game);
                }
            }
        }
    }
}
