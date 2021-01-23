using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager artisanCreditManager = new ArtisanCreditManager();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(vehicleCreditManager, fileLoggerService);
            Console.WriteLine("-----------------");
            applicationManager.MakeAnApplication(mortgageCreditManager, databaseLoggerService);
            Console.WriteLine("-----------------");
            applicationManager.MakeAnApplication(personalFinanceCreditManager, fileLoggerService);
            Console.WriteLine("-----------------");
            applicationManager.MakeAnApplication(artisanCreditManager, smsLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, vehicleCreditManager };
            //applicationManager.MakeCreditPreInformation(credits);
        }
    }
}
