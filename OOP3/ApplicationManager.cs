using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager,ILoggerService loggerServices)
        {
            creditManager.Calculate();
            loggerServices.Log();
        }
        public void MakeCreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}
