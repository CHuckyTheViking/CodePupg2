using Design_Patterns_Assignment.Observer.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Simulator
{
    class EmailSimulator
    {
        private List<IEMail> EmailList = new List<IEMail>();

        public void init()
        {
            EmailList = new();
            EmailList.Add(new EMail{Id = 1, From = "kalle@karlsson.se", Message = "Tjenare mannen, glöm inte att dricka vatten" });
            EmailList.Add(new EMail {Id = 2, From = "Nisse@nissesbil.se", Message = "Grym deal, kom och köp din nya Tesla! 50% rabatt pga svenska elpriserna så ingen handlar" });
            EmailList.Add(new EMail {Id = 3, From = "Eon@eon.se", Message = "Nytt elpris för samtliga kunder, 10kr kwh är vårat nya lägsta pris. Teckna nytt avtal och få en filt" });
        }

        public EMail GetRandomEmail()
        {
            Random rnd = new Random();
            var nr = rnd.Next(1, 4);
            foreach (var email in EmailList)
            {
                if (email.Id == nr)
                {
                    return (EMail)email;
                }
            }
            return null;
        }

    }
}
