using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamesManager : IGamesService
    {
        public void AddToCart(Games games, Gamer gamer)
        {
            Console.WriteLine(games.GameName + " " + ":Game successfully added to" + " " + gamer.FirstName + "'s" + " cart");
        }

        public void BuyGame(Games games, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "Successfully bought:" + games.GameName);
        }
    }
}




