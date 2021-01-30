using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.FirstName == "Ediz" && gamer.SurName == "Züm" 
                && gamer.BirthYear == 2001 && gamer.IdentitiyNumber == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
