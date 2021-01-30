using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                FirstName = "Ediz",
                SurName = "Züm",
                BirthYear = 2001,
                IdentitiyNumber = 12345678910,
            });

            gamerManager.Delete(new Gamer
            {
                FirstName = "Ediz",
                SurName = "Züm",
                BirthYear = 2001,
                IdentitiyNumber = 12345678910,
            });

            gamerManager.Update(new Gamer
            {
                FirstName = "Ediz",
                SurName = "Züm",
                BirthYear = 2001,
                IdentitiyNumber = 12345678910,
            });

            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Ediz";
            gamer1.SurName = "Züm";
            gamer1.BirthYear = 2001;
            gamer1.IdentitiyNumber = 12345678910;

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Umut";
            gamer2.SurName = "Mırrıkoğlu";
            gamer2.BirthYear = 2002;
            gamer2.IdentitiyNumber = 12345678911;

            Gamer gamer3 = new Gamer();
            gamer3.FirstName = "Güney";
            gamer3.SurName = "Taran";
            gamer3.BirthYear = 2002;
            gamer3.IdentitiyNumber = 12345678912;



            Games game1 = new Games();
            game1.GameName = "GAME1";
            game1.GameType = "WAR";
            game1.Price = 89.90;
            game1.Point = 4.2;

            Games game2 = new Games();
            game2.GameName = "GAME2";
            game2.GameType = "ADVENTURE";
            game2.Price = 90.90;
            game2.Point = 3.7;

            Games game3 = new Games();
            game2.GameName = "GAME3";
            game2.GameType = "STRATEGY";
            game2.Price = 85.90;
            game2.Point = 4.7;

            Games[] games = new Games[] { game1, game2, game3 };

            GamesManager gamesManager = new GamesManager();
            
            gamesManager.AddToCart(game1, gamer1);
            gamesManager.BuyGame(game2, gamer3);
        }
    }
}
