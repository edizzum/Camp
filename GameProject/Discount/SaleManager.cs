using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Discount
{
    class SaleManager : ISaleService
    {

        public void Calculate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " named campaign " + campaign.CampaignDiscountAmount + " discount calculated. ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " named campaign deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " named campaign updated.");
        }
    }
}
