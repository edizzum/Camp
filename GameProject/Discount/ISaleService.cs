using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Discount
{
    interface ISaleService
    {
        void Calculate(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
