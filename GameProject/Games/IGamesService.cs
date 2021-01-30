using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamesService
    {
        void AddToCart(Games games, Gamer gamer);
        void BuyGame(Games games, Gamer gamer);
    }
}
