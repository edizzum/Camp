using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
    
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("Gamer added");
            }
            else
            {
                Console.WriteLine("Gamer adding process is unsuccessfull");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine("Gamer Deleted");
            }
            else
            {
                Console.WriteLine("Gamer deleting process is unsuccessfull");
            }
            
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine("Gamer Updated");
            }
            else
            {
                Console.WriteLine("Gamer updating process is unsuccessfull");
            }
        }
    }
}
